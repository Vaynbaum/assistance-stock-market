using coursework.db;
using coursework.Exceptions;
using coursework.Factories;
using coursework.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace coursework.Controllers
{
    public class DBContr
    {
        public event AttachedMessage<List<Market>> GettedAllMarkets;
        public DBContr()
        {
        }

        public void AddAccount(Account account)
        {
            TAccount taccount = new TAccount(account);
            using (InvestmentContainer db = new InvestmentContainer())
            {
                db.TAccount.Add(taccount);
                db.SaveChanges();
            }
        }

        public Account GetAccountByLogin(string login)
        {
            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TAccount taccount in db.TAccount.ToList())
                {
                    if(taccount.Login == login)
                    {
                        AccountFactory factory = new AccountFactory();
                        Account account = factory.Create(taccount.Login, taccount.Password);
                        return account;
                    }
                }
                throw new GettedAccountException("Данного аккаунта нет"); 
            }
        }

        public void DeleteAsset(Asset asset)
        {
            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TAsset tasset in db.TAsset.ToList())
                {
                    if (tasset.CompareAssets(asset))
                    {
                        db.TAsset.Remove(tasset);
                        db.SaveChanges();
                        return;
                    }
                }
            }
        }

        public void DeleteMarket(Market market)
        {
            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TMarket tmarket in db.TMarket.ToList())
                {
                    if (tmarket.CompareMarkets(market))
                    {
                        foreach (TAsset tasset in tmarket.TAsset.ToList())
                        {
                            db.TAsset.Remove(tasset);
                        }
                        db.TMarket.Remove(tmarket);
                        db.SaveChanges();
                        return;
                    }
                }
            }
        }

        public void AddAsset(Market market, Asset asset)
        {
            TAsset tasset = new TAsset(asset);

            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TMarket tmarket in db.TMarket.ToList())
                {
                    if (tmarket.CompareMarkets(market))
                    {
                        tasset.TMarket = tmarket;
                        db.TAsset.Add(tasset);
                        db.SaveChanges();
                        return;
                    }
                }
            }
        }

        public void AddMarket(Account account, Market market)
        {
            TMarket tmarket = new TMarket(market);
            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TAccount taccount  in db.TAccount.ToList())
                {
                    if (taccount.CompareAccounts(account))
                    {
                        tmarket.Account = taccount;
                        db.TMarket.Add(tmarket);
                        db.SaveChanges();
                        return;
                    }
                }
            }
        }

        public void GetMarketsByAccount(Account account)
        {
            List<Market> marketsReturned = new List<Market>();
            MarketFactory marketFactory = new MarketFactory();
            AssetFactory assetFactory = new AssetFactory();
            using (InvestmentContainer db = new InvestmentContainer())
            {
                foreach (TAccount taccount in db.TAccount)
                {
                    if(taccount.CompareAccounts(account))
                    {
                        foreach (TMarket tMarket in taccount.TMarkets)
                        {
                            Market market = marketFactory.Create(
                                tMarket.Abbreviation,
                                tMarket.MIC,
                                tMarket.Country,
                                tMarket.Timezone
                            );

                            foreach (TAsset tAsset in tMarket.TAsset)
                            {
                                Asset asset = assetFactory.Create(
                                    tAsset.Abbreviation,
                                    tAsset.Country,
                                    tAsset.Currency,
                                    tAsset.InstrumentName,
                                    tAsset.Type
                                );
                                market.AddAsset(asset);
                            }
                            marketsReturned.Add(market);
                        }
                        GettedAllMarkets?.Invoke(marketsReturned);
                        return;
                    }
                }
            }
        }
    }
}
