using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    [SerializeField] Text currentScoreTxt;
    [SerializeField] Text highscoreTxt;
    [SerializeField] GameObject endPanel;
    [SerializeField] Text finalScoreTxt;
    [SerializeField] Text finalHighscoreTxt;
    [SerializeField] Text finalTimeSurvivedTxt;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDeath() {
        endPanel.SetActive(true);
        finalScoreTxt.text = "PONTUAÇÃO: " + GameManager.instance.currentScore.ToString();
        finalHighscoreTxt.text = "HIGHSCORE: " + GameManager.instance.highscore.ToString();
        finalTimeSurvivedTxt.text = "Você sobreviveu por: " + Mathf.Round(Time.timeSinceLevelLoad).ToString() + " segundos";

    }

    public void UpdateValues()
    {
        currentScoreTxt.text = "PONTOS: " + GameManager.instance.currentScore.ToString();
    }

    public void UpdateHighscore()
    {
        highscoreTxt.text = "HIGHSCORE: " + GameManager.instance.highscore.ToString();
    }


}
