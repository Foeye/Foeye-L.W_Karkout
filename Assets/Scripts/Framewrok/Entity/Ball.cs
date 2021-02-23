using Karkout.Framework.Entity.EntityMono;
using UnityEngine;

namespace Karkout.Framework.Entity
{
    public class Ball
    {
        private BallMono mBallMono;
        
        //TODO 初始化将改为实例化，不再写死，这里只是测试
        public Ball()
        {
            mBallMono = GameObject.Find("Ball").GetComponent<BallMono>();
        }
        
        public void ForceMovement(Vector3 force)
        {
            mBallMono.ForceMovement(force);
        }
    }
}