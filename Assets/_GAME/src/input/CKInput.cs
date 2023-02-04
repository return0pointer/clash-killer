using System;
using gcore.input;
using UnityEngine;

namespace _GAME.src.input
{
    public class CKInput : GInput
    {
        public override void updateInput(double delta)
        {
            foreach (string key in _binding.Keys)
            {
                if (isExecuteKey(key))
                {
                    foreach (Action action in _binding[key])
                    {
                        action.Invoke();
                    }
                }
            }
            
            foreach (string key in _bindingX.Keys)
            {
                double x = getXValueForKey(key);
                foreach (Action<double> action in _bindingX[key])
                {
                    action.Invoke(x);
                }
            }
            
            foreach (string key in _bindingX.Keys)
            {
                Vector2 pos = getXYValueForKey(key);
                foreach (Action<Vector2> action in _bindingXY[key])
                {
                    action.Invoke(pos);
                }
            }
        }

        private double getXValueForKey(string key)
        {
            switch (key)
            {
                
            }

            return 0;
        }
        
        private Vector2 getXYValueForKey(string key)
        {
            switch (key)
            {
                
            }

            return new Vector2();
        }

        protected override bool isExecuteKey(string key)
        {
            string[] parts = key.Split('_');
            if (parts.Length != 2)
                return false;
            return isExecuteByActionAndKey(parts[0], parts[1]);
        }

        protected bool isExecuteByActionAndKey(string action, string key)
        {
            switch (action)
            {
                case KeyActionType.DOWN:
                    return Input.GetKeyDown(key);
                case KeyActionType.UP:
                    return Input.GetKeyUp(key);
                case KeyActionType.PRESS:
                    return Input.GetKey(key);
                
            }

            return false;
        }

        public class KeyActionType
        {
            public const string DOWN = "DOWN";
            public const string UP = "UP";
            public const string PRESS = "PRESS";
        }
        
    }

}