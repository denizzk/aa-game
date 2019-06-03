using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Spawner : MonoBehaviour {

    public GameObject gameObj;

    public Text score;
    public int counter;
    public GameObject circle;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale == 1f)
        {
            Spawn();
        }
        
    }

    void LateUpdate()
    {
        counter = circle.transform.childCount;
        score.text =  counter.ToString();
    }

    public void Spawn ()
    {
        
        Instantiate(gameObj, transform.position, transform.rotation);
       

        
    }
}
