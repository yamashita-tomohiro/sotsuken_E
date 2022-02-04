using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    float fallSpeed;            //落下速度
    private float pointY;       //プレイヤーに向かってくるY軸の位置
    private float vx;           //X軸の移動量
    private GameObject player;  //プレイヤーオブジェクト取得

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定

        //プレイヤーに向かってくるY軸の位置
        pointY = Random.Range(2.0f, 3.0f);
        //敵の初期位置とプレイヤーの位置によってX軸の移動方向を決定する
        vx = 2.0f;
        player = GameObject.Find("Player");
        if (player.transform.position.x < transform.position.x)
        {
            vx = -vx;
        }

        //落下速度
        this.fallSpeed = 0.01f + 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        // 一定の位置になるとプレイヤーに向かって移動する
        if (transform.position.y < pointY)
        {
            transform.position += new Vector3(vx, 0, 0) * Time.deltaTime;
        }

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
        }
    }

}
