using System;
using UnityEngine;

namespace TettekeKobo.Singleton.Sample
{
    public class EndSceneManager : MonoBehaviour
    {
        private void Update()
        {
            if(MyEndSceneInputController.Instance.ShowLogKey) SceneConnectController.Instance.ShowMessage();
        }
    }
}
