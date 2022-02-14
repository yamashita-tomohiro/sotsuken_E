using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UIController;

public class GameOverController : MonoBehaviour
{

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
    }
}
