using gcore.core;

namespace gcore.locale
{
    public class Localizer
    {
        
        public static string get(string key, string category = null)
        {
            return LocalizationManager.get().getLocalizedString(key, category);
        }
    }
}