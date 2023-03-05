using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Destructible"){
            sound.Play();
            Destroy(collision.gameObject);
        }
    }

}
