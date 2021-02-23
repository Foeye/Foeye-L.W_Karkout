using System;
using System.Collections.Generic;
using Framewrok.System;
using Logic.Controller;

namespace Framewrok.Core
{
    public class GameCore
    {
        private readonly Dictionary<Type, ISystem> mSystem = new Dictionary<Type, ISystem>()
        {
            {typeof(EntitySystem), new EntitySystem()},
            {typeof(BricksSystem), new BricksSystem()},
            {typeof(CollisionSystem), new CollisionSystem()}
        };

        private SlotController mController;
        
        public T GetSystem<T>() where T : ISystem
        {
            return (T)mSystem[typeof(T)];
        }

        public void StartPlay()
        {
            foreach (var system in mSystem)
            {
                system.Value.StartPlay();
            }
        }
        
        /// <summary>
        /// 系统初始化
        /// </summary>
        public void SystemInitialize()
        {
            foreach (var system in mSystem)
            {
                system.Value.Initialize(this);
            }

            mController = new SlotController(this);
        }
        
        /// <summary>
        /// 系统更新
        /// </summary>
        public void SystemUpdate()
        {
            foreach (var system in mSystem)
            {
                system.Value.Update();
            }
        }
    }
}