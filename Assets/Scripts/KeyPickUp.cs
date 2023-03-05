using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnCollision : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnCollisionEnter(Collision collision) {
        sound.Play();
    }
}
