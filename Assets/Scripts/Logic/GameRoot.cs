using System;
using System.Collections.Generic;
using Framewrok.Core;
using Framewrok.System;
using UnityEngine;

namespace Logic
{
    public class GameRoot : MonoBehaviour
    {
        private GameCore mGameCore;
        
        private void Start()
        {
            mGameCore = new GameCore();
            mGameCore.SystemInitialize();
        }

        private void Update()
        {
            mGameCore.SystemUpdate();
        }
    }
}