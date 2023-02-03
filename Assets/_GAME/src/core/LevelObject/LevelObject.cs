using System;
using UnityEngine;

namespace _GAME.src.core.LevelObject
{
    public class LevelObject : MonoBehaviour
    {
        private LevelObjectsManager _levelObjectsManager;
        
        public void init(LevelObjectsManager levelObjectsManager)
        {
            _levelObjectsManager = levelObjectsManager;
        }

        public void initData()
        {
            
        }
        
        public void startPlay()
        {
            
        }

        private void OnDestroy()
        {
            _levelObjectsManager.removeLevelObject(this);
        }
    }
}