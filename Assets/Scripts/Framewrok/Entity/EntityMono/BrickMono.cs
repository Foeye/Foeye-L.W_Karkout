using System;
using Karkout.Framework.Entity.Define;
using UnityEngine;

namespace Karkout.Framework.Entity.EntityMono
{
    public class BrickMono : CollisionMono
    {
        private CollisionDelegate mCollisionDelegate;

        protected override void OnCollisionExit(Collision other)
        {
            base.OnCollisionExit(other);
            if (other.transform.GetComponent<BallMono>() != null)
                gameObject.SetActive(false);
        }
    }
}