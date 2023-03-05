using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnCollisionEnter(Collision collision) {
        sound.Play();
    }
}
