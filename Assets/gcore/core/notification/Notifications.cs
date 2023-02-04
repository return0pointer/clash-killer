using System;
using System.Collections.Generic;

namespace gcore.core.notification
{
    public class Notifications
    {
        private static Notifications _instance;
        
        public static Notifications get()
        {
            if (_instance == null)
            {
                _instance = new Notifications();
            }

            return _instance;
        }

        public static void setInstance(Notifications instance)
        {
            _instance = instance;
        }

        private Dictionary<string, List<Observer<Action>>> _noParamObservers;
        private Dictionary<string, List<Observer<Action<object>>>> _observers;

        public void addObserver(string name, Action action, object data = null)
        {
            if (!_noParamObservers.ContainsKey(name))
            {
                _noParamObservers.Add(name, new List<Observer<Action>>());
            }
            Observer<Action> observer = new Observer<Action>(action, data);
            _noParamObservers[name].Add(observer);
        }
        
        public void addObserver(string name, Action<object> action, object data = null)
        {
            if (!_noParamObservers.ContainsKey(name))
            {
                List<Observer<Action<object>>> list = new List<Observer<Action<object>>>();
                _observers.Add(name, list);
            }
            Observer<Action<object>> observer = new Observer<Action<object>>(action, data);
            _observers[name].Add(observer);
        }

        public void postNotification(string name, object data = null)
        {
            if (_noParamObservers.ContainsKey(name))
            {
                List<Observer<Action>> notifications = _noParamObservers[name];
                foreach (Observer<Action> notif in notifications)
                {
                    notif.action.Invoke();
                }
            }
            
            if (_observers.ContainsKey(name))
            {
                List<Observer<Action<object>>> notifications = _observers[name];
                foreach (Observer<Action<object>> notif in notifications)
                {
                    if (notif.data != null && data != null && notif.data != data)
                    {
                        notif.action.Invoke(data);
                    }
                    else if(data == null)
                    {
                        notif.action.Invoke(notif.data);
                    }
                }
            }
        }
        
        private struct Observer<T>
        {
            public T action;
            public object data;
        
            public Observer(T action, object data)
            {
                this.action = action;
                this.data = data;
            }
        }
        
    }
}