using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    float fallSpeed;            //�������x
    private float pointY;       //�v���C���[�Ɍ������Ă���Y���̈ʒu
    private float vx;           //X���̈ړ���
    private GameObject player;  //�v���C���[�I�u�W�F�N�g�擾

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPS��144�ɐݒ�

        //�v���C���[�Ɍ������Ă���Y���̈ʒu
        pointY = Random.Range(2.0f, 3.0f);
        //�G�̏����ʒu�ƃv���C���[�̈ʒu�ɂ����X���̈ړ����������肷��
        vx = 2.0f;
        player = GameObject.Find("Player");
        if (player.transform.position.x < transform.position.x)
        {
            vx = -vx;
        }

        //�������x
        this.fallSpeed = 0.01f + 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        // ���̈ʒu�ɂȂ�ƃv���C���[�Ɍ������Ĉړ�����
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
