using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TettekeKobo.Singleton.Sample
{
    public class StartSceneManager : MonoBehaviour
    {
        [SerializeField] private string message;
        
        private void Update()
        {
            if (MyStartSceneInputController.Instance.ChangeSceneKey)
            {
                SceneConnectController.Instance.SetMessage(message);
                SceneManager.LoadScene("SingletonScene_End");
            }
        }
    }
}
