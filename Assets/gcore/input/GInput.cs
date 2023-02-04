using System;
using System.Collections.Generic;
using gcore.core;
using UnityEngine;

namespace gcore.input
{
    public class GInput
    {
        private static GInput _instance = null;

        public static void setInstance(GInput instance) => _instance = instance;

        public static GInput get()
        {
            if (_instance == null)
            {
                _instance = new GInput();
                Loger.log("GInput set default instance");
            }

            return _instance;
        }

        protected Dictionary<string,List<Action>> _binding;
        protected Dictionary<string, List<Action<double>>> _bindingX;
        protected Dictionary<string, List<Action<Vector2>>> _bindingXY;

        public virtual void bind(string key, Action action)
        {
            if (!_binding.ContainsKey(key))
            {
                _binding.Add(key, new List<Action>()); 
            }
            _binding[key].Add(action);
        }
        
        public virtual void bind(string key, Action<double> action)
        {
            if (!_bindingX.ContainsKey(key))
            {
                _bindingX.Add(key, new List<Action<double>>()); 
            }
            _bindingX[key].Add(action);
        }

        public virtual void bind(string key, Action<Vector2> action)
        {
            if (!_bindingXY.ContainsKey(key))
            {
                _bindingXY.Add(key, new List<Action<Vector2>>()); 
            }
            _bindingXY[key].Add(action);
        }

        public virtual void unbind(string key, Action action)
        {
            if (_binding.ContainsKey(key))
            {
                if (_binding[key].Contains(action))
                {
                    _binding[key].Remove(action);
                }
            }
        }
        
        public virtual void unbind(string key, Action<double> action)
        {
            if (_bindingX.ContainsKey(key))
            {
                if (_bindingX[key].Contains(action))
                {
                    _bindingX[key].Remove(action);
                }
            }
        }

        public virtual void unbind(string key, Action<Vector2> action)
        {
            if (_bindingXY.ContainsKey(key))
            {
                if (_bindingXY[key].Contains(action))
                {
                    _bindingXY[key].Remove(action);
                }
            }
        }

        public virtual void updateInput(double delta)
        {
            
        }
        
        protected virtual bool isExecuteKey(string key)
        {
            return false;
        }

    }
}