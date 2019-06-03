using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

    public GameObject ui;
    public Color color;
    public Text credits;


    void Awake()
    {
        FindObjectOfType<Spawner>().score.color = Color.clear;
        credits.color = Color.clear;
        ui.SetActive(true);
        Time.timeScale = 0f;
    }

	
	public void StartFunc ()
    {

        FindObjectOfType<Spawner>().score.color = color;
        ui.SetActive(false);
        Time.timeScale = 1f;

	}
	
    public void Credits()
    {
        Time.timeScale = 0f;
        if(credits.color==Color.clear)
        {
            credits.color = Color.white;
        }else
        {
            credits.color = Color.clear;
        }
       
    }

    
 }



