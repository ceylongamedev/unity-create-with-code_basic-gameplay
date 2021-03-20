using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
   
    void OnTriggerEnter(Collider target)
    {

        //Destroy this gameObject
        Destroy(this.gameObject);
        Destroy(target.gameObject);

        //score++
        //Win the game
        //game over!

    }//OnTriggerEnter

}//class
