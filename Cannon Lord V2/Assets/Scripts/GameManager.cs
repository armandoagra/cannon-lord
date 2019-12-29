using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public int currentScore;
    public int highscore;
    public CanvasManager canvasManager;
    [SerializeField] Button resumeButton;
    [SerializeField] Button pauseButton;
    [SerializeField] MonsterSpawner spawner;
    [SerializeField] GameObject endPanel;
    [SerializeField] Button fireButton;
    [SerializeField] BoxCollider2D playerBase;
    bool gameIsOver;

    private void Awake()
    {
        instance = this;
        highscore = PlayerPrefs.GetInt("Highscore");
        Time.timeScale = 0;
        canvasManager.UpdateHighscore();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        pauseButton.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(false);
        fireButton.gameObject.SetActive(true);
        spawner.canSpawn = true;
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
        fireButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        canvasManager.UpdateValues();

    }

    public void GameOver()
    {
        Debug.Log("Game over!");
        if (currentScore > highscore)
        {
            PlayerPrefs.SetInt("Highscore", currentScore);
            highscore = currentScore;
        }
        canvasManager.OnDeath();
        fireButton.interactable = false;
        spawner.canSpawn = false;
        playerBase.enabled = false;
        gameIsOver = true;
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        fireButton.gameObject.SetActive(false);
    }

}
