using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        //Destory the whole block
        Destroy(gameObject);


    }
}
