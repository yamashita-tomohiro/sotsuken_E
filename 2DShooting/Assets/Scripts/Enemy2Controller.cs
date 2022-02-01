using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定

        //落下速度
        this.fallSpeed = 0.01f + 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);
        transform.position = new Vector3(Mathf.PingPong(Time.time, 2), transform.position.y, transform.position.z);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }

    }
}
