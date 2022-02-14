using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScoreController : MonoBehaviour
{
    //UIController.AddScore();
    int result = 0;
    GameObject resultText;

    public void AddResult()
    {
        this.result += 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.resultText = GameObject.Find("Result");

    }

    // Update is called once per frame
    void Update()
    {
        resultText.GetComponent<Text>().text = "Result:" + result.ToString("D3");
    }
}
