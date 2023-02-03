using UnityEngine;

namespace _GAME.src.core.LevelObject
{
    public class SpawnInfo
    {
        public LevelObjectType type = LevelObjectType.NONE;
        public Transform parent = null;
        public Vector3 position = Vector3.zero;
        public Quaternion rotation = Quaternion.identity;
        public bool startOnSpawn = false;
    }
}