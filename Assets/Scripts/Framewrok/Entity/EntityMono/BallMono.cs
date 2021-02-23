using System;
using Karkout.Framework.Entity.Define;
using UnityEngine;

namespace Karkout.Framework.Entity.EntityMono
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallMono : CollisionMono
    {
        private Rigidbody mRigidbody;
        
        private void Awake()
        {
            mRigidbody = GetComponent<Rigidbody>();
        }

        /// <summary>
        /// 施加力运动，此处将Z强制归零
        /// </summary>
        /// <param name="force"></param>
        public void ForceMovement(Vector3 force)
        {
            force.z = 0;
            mRigidbody.velocity = force;
        }
    }
}