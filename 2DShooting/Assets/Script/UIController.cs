using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    int zanki = 3;
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject zankiText;

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore()
    {
        this.score += 10;
    }

    public void AddZanki()
    {
        this.zanki -= 1;
        if (zanki <= 0)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            if(zanki<=-1)
            {
                  SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.zankiText = GameObject.Find("Zanki");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D3");
        zankiText.GetComponent<Text>().text = "Zanki:" + zanki.ToString("D2");
    }
}
