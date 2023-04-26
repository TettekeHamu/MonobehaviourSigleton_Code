using System;
using UnityEngine;

namespace TettekeKobo.Singleton.Sample
{
    public class MyEndSceneInputController : MonoSingletonBase<MyEndSceneInputController>
    {
        private bool showLogKey;

        public bool ShowLogKey => showLogKey;

        private void Update()
        {
            showLogKey = Input.GetKeyDown(KeyCode.Space);
        }
    }
}
