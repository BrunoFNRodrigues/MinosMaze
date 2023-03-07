using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KillOnCollision : MonoBehaviour
{
    public List<GameObject> walls;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            foreach(GameObject wall in walls) 
            {
                Destroy(wall);
            }
        }
    }

}
