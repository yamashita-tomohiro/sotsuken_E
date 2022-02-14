using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UIController.cs;

public class GameOverController : MonoBehaviour
{
    //UIController scoree;
    //GameObject score2 = GameObject.Find("Result");
    //UIController scoree = score2.GetComponent();

    GameObject resultText;

    public void SwitchScene()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.resultText = GameObject.Find("Result");
    }

    // Update is called once per frame
    void Update()
    {
        //resultText.GetComponent<Text>().text = "Score:" + score.ToString("D3");
    }
}
