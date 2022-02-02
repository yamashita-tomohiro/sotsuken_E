using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour

{
    float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定

        //Randomメソッドを使って落下速度がエネミーごとに変わる
        this.fallSpeed = 0.03f + 0.1f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
       
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject.Find("Canvas").GetComponent<UIController>().AddZanki();
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
        }
    }
}
