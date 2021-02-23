using Framewrok.Core;
using UnityEngine;

namespace Logic.Controller
{
    public class SlotController
    {
        private SlotMono mSlotMono;
        private GameCore mCore;
        public SlotController(GameCore core)
        {
            mSlotMono = GameObject.Find("Slot").GetComponent<SlotMono>();
            mSlotMono.SetController(this);
            mCore = core;
        }

        public void StartPlay()
        {
            mCore.StartPlay();
        }
    }
}