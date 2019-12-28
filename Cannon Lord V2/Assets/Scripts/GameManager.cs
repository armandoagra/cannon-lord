using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public int currentScore;
    public int highScore;
    [SerializeField] Text currentScoreTxt;

    private void Awake()
    {
        instance = this;
        highScore = PlayerPrefs.GetInt("Highscore");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        currentScoreTxt.text = "PONTOS: " + currentScore.ToString();

    }

    void OnDeath()
    {
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("Highscore", currentScore);
            highScore = currentScore;
            // Flag mostrando que mudou o score
            // Chamar painel

        }
    }
}
