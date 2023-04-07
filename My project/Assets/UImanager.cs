using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] buttons;
    public bool gameOver;
    public Text scoreText;
    int score;
    void Start()
    {
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 1f);
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + score;
    }
    void scoreUpdate()
    {
        if (!gameOver)
        {
            score += 1;
        }

    }
    public void gameOverActivated()
    {
        gameOver = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void pause()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void replay()
    {
        pause();
        SceneManager.LoadScene("SampleScene");
    }
    public void menu()
    {
        SceneManager.LoadScene("MENU");
    }
    public void exit()
    {
        Application.Quit();
    }
    
}
