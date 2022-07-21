using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace coursework.Model
{
    public class KeyToAPI
    {
        public string KeyApi { get; private set; }
        private static KeyToAPI _key;
        private KeyToAPI()
        {
            if(Properties.Settings.Default.KeyForDownload != "")
            {
                KeyApi = Properties.Settings.Default.KeyForDownload;
            }
            else 
            {
                Reset();
            }
        }

        public static KeyToAPI Key()
        {
            if (_key == null)
                _key = new KeyToAPI();
            return _key;
        }

        public string Reset()
        {
            return KeyApi = Properties.Settings.Default.DefaultKeyForDownload;
        }

        public string EnterKey(string key)
        {
            Properties.Settings.Default["KeyForDownload"] = key;
            Properties.Settings.Default.Save();
            return KeyApi = key;
        }
    }
}
