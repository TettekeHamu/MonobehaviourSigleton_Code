using UnityEngine;

namespace TettekeKobo.Singleton.Sample
{
    public class SceneConnectController : MonoDontDestroySingletonBase<SceneConnectController>
    {
        private string message;

        public void SetMessage(string str)
        {
            message = str;
        }

        public void ShowMessage()
        {
            Debug.Log(message);
        }
    }
}
