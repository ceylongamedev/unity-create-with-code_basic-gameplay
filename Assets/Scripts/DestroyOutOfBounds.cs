using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 40;
    public float lowerBound = -20;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            print("Game Over!");
            Destroy(this.gameObject);
        }
    }//Update


}//class
