using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PinMove : MonoBehaviour {


    public float speed = 10;
    public bool isPinned = false;
   
    


    void Update ()
    {
        if(!isPinned)
        transform.Translate(Vector2.up *speed* Time.deltaTime);

        
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Rotator")
        {
            isPinned = true;
            transform.SetParent(c.transform);
           
           
           

        }
        if (c.gameObject.tag == "Pin")
        {
            Debug.Log("gameover");
            FindObjectOfType<GameOver>().gameOver();



        }
        
    }

   
}
