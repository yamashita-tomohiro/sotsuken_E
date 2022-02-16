using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour   
{
    public GameObject bulletPrefab;
    public float speed;
    private AudioSource bulletSE; //発砲SE

    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定
        bulletSE= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //左移動
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        //右移動
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        //スペースキーが押されたら弾発射
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //発砲音
            bulletSE.PlayOneShot(bulletSE.clip);

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
