using UnityEngine;

namespace gcore.core
{
    public class Loger
    {
        public static void log(object message)
        {
            Debug.Log(message);
        }
        
        public static void log(object message, Object context)
        {
            Debug.Log(message, context);
        }
    }
}