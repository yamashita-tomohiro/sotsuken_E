using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour   
{
    public GameObject bulletPrefab;
    public float speed;
    private AudioSource bulletSE; //���CSE

    void Start()
    {
        Application.targetFrameRate = 144; //FPS��144�ɐݒ�
        bulletSE= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //���ړ�
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        //�E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
        //�X�y�[�X�L�[�������ꂽ��e����
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //���C��
            bulletSE.PlayOneShot(bulletSE.clip);

        }

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector2(
             //�G���A�w�肵�Ĉړ�����
             Mathf.Clamp(transform.position.x + moveX, -2.5f, 2.5f),
             Mathf.Clamp(transform.position.y + moveY, -4.5f, 4.5f)
             );
    }
}
