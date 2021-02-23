using System;
using UnityEngine;

namespace Logic.Controller
{
    public class SlotMono : MonoBehaviour
    {
        public float HorizontalSpeed;
        private SlotController mController;
        private Vector3 mLastMousePosition = Vector3.zero;
        private bool mIStart;

        public Vector3 position
        {
            get { return gameObject.transform.position; }
            set { gameObject.transform.position = value; }
        }

        public void SetController(SlotController controller)
        {
            mController = controller;
        }
        
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                mController.StartPlay();
                mIStart = true;
            }

            if (!mIStart || Camera.main == null) return;
            Vector3 s2w = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position = new Vector3(s2w.x, position.y, 0);
        }
    }
}