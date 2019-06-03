using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    
    public float speed = 100f;


    void Update()
    {

       
        if (transform.childCount < 10)
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }else
        {
            transform.Rotate(0, 0, -speed/2 * Time.deltaTime);
        }
        
        

    }

   
    
}
