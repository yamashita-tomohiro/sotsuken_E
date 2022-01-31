using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour   
{
    public GameObject bulletPrefab;
    public float speed;

    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定
        
    }

    // Update is called once per frame
    void Update()
    {
        //左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        //右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        //スペースキーが押されたら弾発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector2(
             //エリア指定して移動する
             Mathf.Clamp(transform.position.x + moveX, -2.5f, 2.5f),
             Mathf.Clamp(transform.position.y + moveY, -4.5f, 4.5f)
             );
    }
}
