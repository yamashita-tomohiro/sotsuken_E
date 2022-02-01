using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;

    public void AddScore()
    {
        this.score += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
