using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


  
    public Text scoreText;
    public GameObject ui;
    public Color color;
    public string nextLevel;

	public void gameOver ()
    {
     
        scoreText.text= "Your Score : " + FindObjectOfType<Spawner>().counter.ToString();
        ui.SetActive(true);
        FindObjectOfType<Spawner>().score.color=color ;
            Time.timeScale = 0f;
        
	}

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Level01");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }

 }
