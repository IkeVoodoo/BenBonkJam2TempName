using UnityEngine;

namespace GameJamUtils
{
    namespace GameObjectUtils
    {
        public class GameObjectUtils
        {
            public static float distance(GameObject a, GameObject b)
            {
                return Vector3.Distance(a.transform.position, b.transform.position);
            }
        }
    }
}