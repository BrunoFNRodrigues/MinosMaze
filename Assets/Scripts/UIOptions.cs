using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
    public class UIOptions : MonoBehaviour
    {
        public void TestButton() 
        {
            Debug.Log("O TESTE FOI UM SUCESSO");
            SceneManager.LoadScene(0);
        }
    }

}
