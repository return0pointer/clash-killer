using gcore.core;

namespace gcore.locale
{
    public class LocalizationManager
    {
        private static LocalizationManager _instance = null;

        public static void setInstance(LocalizationManager instance) => _instance = instance;

        public static LocalizationManager get()
        {
            if (_instance == null)
            {
                _instance = new LocalizationManager();
                Loger.log("LocalizationManager set default instance");
            }

            return _instance;
        }
        
        public string getLocalizedString(string key, string category)
        {
            switch (key)
            {
                case "NOT LOCALIZE STRING":
                    return "LOCALIZE STRING";
            }
            return key;
        }
    }
}