using System.Collections.Generic;
using Framewrok.Core;
using Karkout.Framework.Entity;
using Karkout.Framework.Entity.EntityMono;
using Logic;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Framewrok.System
{
    public class EntitySystem : ISystem
    {
        private Ball mBallEntity;
        private Brick[] mBricksEntity;
        
        public void Initialize(GameCore core)
        {
            mBallEntity = new Ball();
            
            BrickMono[] brickMonos = Object.FindObjectsOfType<BrickMono>();
            mBricksEntity = new Brick[brickMonos.Length];
            for (int i = 0; i < brickMonos.Length; i++)
            {
                mBricksEntity[i] = new Brick(core.GetSystem<CollisionSystem>()) {mBrickMono = brickMonos[i]};
            }
        }

        public void StartPlay()
        {
            mBallEntity.ForceMovement(DebugCenter.Center.ForceStart);
        }

        public void Update()
        {
            
        }
    }
}