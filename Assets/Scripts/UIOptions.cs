using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    public class UIOptions : MonoBehaviour
    {
        public void RestartButton() 
        {
            SceneManager.LoadScene("Main");
        }
        
        public void QuitToMenuButton() 
        {
            SceneManager.LoadScene("Menu");
        }

        public void QuitButton() 
        {
            Application.Quit();
        }

        public void StartButton() 
        {
            SceneManager.LoadScene("Main");
        }
    }
    

}
