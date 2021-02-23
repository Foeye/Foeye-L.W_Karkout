using UnityEngine;

namespace Logic
{
    public class DebugCenter : MonoBehaviour
    {
        public static DebugCenter Center;
        //初始小球的力
        public Vector3 ForceStart;
        
        public DebugCenter()
        {
            Center = this;
        }
    }
}