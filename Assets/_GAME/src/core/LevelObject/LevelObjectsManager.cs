using System.Collections.Generic;
using UnityEngine;

namespace _GAME.src.core.LevelObject
{
    public class LevelObjectsManager : MonoBehaviour
    {
        private List<LevelObject> _levelObjects;

        public LevelObject spawn(SpawnInfo info)
        {
            LevelObject prefab = getPrefabByType(info.type);
            LevelObject levelObject = Instantiate<LevelObject>(prefab, info.position, info.rotation, info.parent);
            
            levelObject.initData();
            levelObject.init(this);
            if (info.startOnSpawn)
                levelObject.startPlay();
            
            _levelObjects.Add(levelObject);
            return levelObject;
        }

        public void destoyLevelObject(LevelObject levelObject)
        {
            removeLevelObject(levelObject);
            Destroy(levelObject);
        }

        public LevelObject getPrefabByType(LevelObjectType type)
        {
            return null;
        }

        public void removeLevelObject(LevelObject levelObject)
        {
            if (levelObject == null)
                return;
            if (_levelObjects.Contains(levelObject))
            {
                _levelObjects.Remove(levelObject);
            }
        }
    }
}