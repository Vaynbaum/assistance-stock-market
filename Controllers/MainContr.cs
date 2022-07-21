using coursework.Exeptions;
using coursework.Fields;
using coursework.Model;
using System;
using System.Collections.Generic;

namespace coursework.Controllers
{
    public class MainContr
    {
        // События
        public event EmptyMessage MarketChangedEvent;
        public event EmptyMessage AssetChangedEvent;
        public event EmptyMessage QuotesGettedEvent;
        public event AttachedMessage<int> CurrentAssetChangeEvent;
        public event AttachedMessage<int> CurrentMarketChangeEvent;
        public event ErrorMessage NoGettedQoutes;
        public event EmptyMessage EnableFunction;
        public event EmptyMessage DisableFunction;

        // Свойства
        // Возвращает список активов выбранной биржи
        public List<Asset> Assets => session.Assets;
        // Возвращает поля отображения бирж
        public List<Field> MarketFields => session.MarketFields;
        // Возвращает поля отображения активов
        public List<Field> AssetFields => session.AssetFields;
        // Возвращает список бирж, сохраненных в аккаунте
        public List<Market> Markets
        {
            get
            {
                if (account != null)
                    return account.Markets;
                else
                    return new List<Market>();
            }
        }
        // Возвращает выбранный актив
        public Asset CurrentAsset => session.GetCurrentAsset();

        private Account account { get; set; }
        private DBContr _DBContr { get; set; }
        private MarketContr marketController { get; set; }
        private AssetContr assetContr { get; set; }
        private QuoteContr quoteController { get; set; }
        private AuthContr authController { get; set; }
        private Session session { get; set; }

        // Конструктор
        public MainContr()
        {
            session = new Session();
            marketController = new MarketContr();
            assetContr = new AssetContr();
            quoteController = new QuoteContr();
            _DBContr = new DBContr();
            _DBContr.GettedAllMarkets += _DBController_GettedAllMarkets;
            marketController.MarketAddedEvent += MarketController_MarketAddedEvent;
            assetContr.AssetAddedEvent += AssetController_AssetAddedEvent;
            quoteController.QuotesGettedEvent += gettedQuotesHandler;
            quoteController.NoGettedQoutes += noGettedQoutesHandler;
            marketController.GetAllMarkets();
        }

        // Удаляет выбранный актив из выбранной биржи
        public void DeleteCurrentAsset()
        {
            _DBContr.DeleteAsset(CurrentAsset);
            assetContr.DeleteAsset(session.GetCurrentMarket(), CurrentAsset);
            session.DeleteCurrentAsset();
            AssetChangedEvent?.Invoke();
            CurrentAssetChangeEvent?.Invoke(session.Assets.IndexOf(session.GetCurrentAsset()));
        }

        // Авторизация в системе
        public void Auth()
        {
            authController = new AuthContr();
            authController.Logined += AuthController_Logined;
            authController.Registrated += AuthController_Registrated;
        }

        // Выход из личного кабинета
        public void Exit()
        {
            account = null;
            session.DeleteCurrentMarket();
            MarketChangedEvent?.Invoke();
            AssetChangedEvent?.Invoke();
            DisableFunction?.Invoke();
        }

        // Обработчик события регистрации контроллера авторизации
        private void AuthController_Registrated(Account obj)
        {
            account = obj;
            GetAllMarketFromDB(account);
            EnableFunction?.Invoke();
        }


        // Обработчик события входа в систему контроллера авторизации
        private void AuthController_Logined(Account obj)
        {
            account = obj;
            GetAllMarketFromDB(account);
            EnableFunction?.Invoke();
        }

        // Удаление выбранной биржы из аккаунта
        public void DeleteCurrentMarket()
        {
            _DBContr.DeleteMarket(session.GetCurrentMarket());
            marketController.DeleteMarket(account, session.GetCurrentMarket());
            session.DeleteCurrentMarket();
            MarketChangedEvent?.Invoke();
            AssetChangedEvent?.Invoke();
        }

        // Обработчки события добавления актива контроллера активов
        private void AssetController_AssetAddedEvent(Asset obj)
        {
            _DBContr.AddAsset(session.GetCurrentMarket(), obj);
            AssetChangedEvent?.Invoke();
            CurrentAssetChangeEvent?.Invoke(session.Assets.IndexOf(session.GetCurrentAsset()));
        }

        // Обработчки события добавления биржи контроллера бирж
        private void MarketController_MarketAddedEvent(Market obj)
        {
            _DBContr.AddMarket(account, obj);
            MarketChangedEvent?.Invoke();
            CurrentMarketChangeEvent?.Invoke(account.Markets.IndexOf(session.GetCurrentMarket()));
        }

        // Получение всех бирж, связанных с текущим аккаунтом
        private void GetAllMarketFromDB(Account account)
        {
            _DBContr.GetMarketsByAccount(account);
        }

        // Обработчки события получения бирж контроллера работы с БД
        private void _DBController_GettedAllMarkets(List<Market> obj)
        {
            foreach (Market market in obj)
            {
                account.AddMarket(market);
            }
            if (account.Markets.Count > 0)
            {
                MarketChangedEvent?.Invoke();
            }
        }

        // Задает выбранную биржу текущей
        public void SetCurrentMarket(Market market)
        {
            session.SetCurrentMarket(market);
            AssetChangedEvent?.Invoke();
            CurrentMarketChangeEvent?.Invoke(account.Markets.IndexOf(session.GetCurrentMarket()));
            CurrentAssetChangeEvent?.Invoke(session.Assets.IndexOf(session.GetCurrentAsset()));
        }

        // Задает выбранный актив текущем
        public void SetCurrentAsset(Asset asset)
        {
            session.SetCurrentAsset(asset);
            CurrentAssetChangeEvent?.Invoke(session.Assets.IndexOf(session.GetCurrentAsset()));
        }

        // Обработчки события ошибки получения котировок
        private void noGettedQoutesHandler(string msg)
        {
            NoGettedQoutes?.Invoke(msg);
        }

        // Добавление биржи в аккаунт
        public void AddMarket()
        {
            if (marketController.AllMarkets.Count > 0)
            {
                marketController.AddMarket(account, MarketFields);
            }
            else
            {
                throw new AddMarketException("Пожалуйста подождите, идет загрузка бирж...");
            }
        }

        // Добавление актива в выбранную биржу
        public void AddAsset()
        {
            if (session.GetCurrentMarket() != null)
            {
                assetContr.AddAsset(session.GetCurrentMarket(), session.AssetFields);
            }
            else
            {
                throw new Exception(Properties.Resources.ErroeMessageWarningNotSelectedMarket);
            }
        }

        // Обработчки события получения котировок контроллера котировок
        private void gettedQuotesHandler()
        {
            QuotesGettedEvent?.Invoke();
        }

        // Получение котировок текущего актива, в заданном временном интервале
        public void GetQuotes(DateTime beginDate, DateTime endDate)
        {
            quoteController.AddQoutes(CurrentAsset, session.GetCurrentMarket(),
                beginDate, endDate);
        }
    }
}
