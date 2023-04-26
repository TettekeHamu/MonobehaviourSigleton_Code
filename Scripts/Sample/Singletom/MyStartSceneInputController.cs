using System;
using UnityEngine;

namespace TettekeKobo.Singleton.Sample
{
    public class MyStartSceneInputController : MonoSingletonBase<MyStartSceneInputController>
    {
        private bool changeSceneKey;
        
        public bool ChangeSceneKey => changeSceneKey;

        private void Update()
        {
            changeSceneKey = Input.GetKeyDown(KeyCode.Return);
        }
    }
}
