using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverUI;
    int playerScore = 0;
    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
    public void playerDied()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
