using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Destructible")
        Destroy(collision.gameObject);
    }

}
