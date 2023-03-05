using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Transform player;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Enemy"){
            //player.transform.position = new Vector3(0,0,0);
            SceneManager.LoadScene(0);
        }
    }

}
