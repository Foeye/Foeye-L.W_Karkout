using Karkout.Framework.Entity.Define;
using UnityEngine;

namespace Karkout.Framework.Entity.EntityMono
{
    public class CollisionMono : MonoBehaviour
    {
        protected CollisionDelegate mCollisionEnterDelegate;
        protected CollisionDelegate mCollisionExitDelegate;
        
        public void SetCollisionEnterTrigger(CollisionDelegate cDelegate)
        {
            mCollisionEnterDelegate += cDelegate;
        }
        
        public void SetCollisionExitTrigger(CollisionDelegate cDelegate)
        {
            mCollisionEnterDelegate += cDelegate;
        }
        
        /// <summary>
        /// Mono碰撞进入
        /// </summary>
        /// <param name="other"></param>
        protected virtual void OnCollisionEnter(Collision other)
        {
            mCollisionEnterDelegate?.Invoke(other);
        }
        
        /// <summary>
        /// Mono碰撞进入
        /// </summary>
        /// <param name="other"></param>
        protected virtual void OnCollisionExit(Collision other)
        {
            mCollisionExitDelegate?.Invoke(other);
        }
    }
}