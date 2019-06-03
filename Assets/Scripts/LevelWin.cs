using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelWin : MonoBehaviour {

    public GameObject ui;
    public string nextLevel;
    public Text score;
    public int scoreToWin;

    void Start()
    {
        ui.SetActive(false);
    }

	void Update()
    {
        if (FindObjectOfType<Spawner>().counter >= scoreToWin)
        {
            ui.SetActive(true);
            Time.timeScale = 0f;
            score.color = Color.clear;
        }

    }

    public void NextLevel()
    {

        ui.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevel);
    }
}
