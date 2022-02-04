using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;  //�����G�t�F�N�g��Prefab
    // ���ʉ�
    public AudioClip se;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPS��144�ɐݒ�
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

   void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy001")
        {

            // �Փ˂����Ƃ��ɃX�R�A���X�V����
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

            //�����G�t�F�N�g�𐶐�����
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // ���ʉ��Đ�
            AudioSource.PlayClipAtPoint(se, new Vector3(0.0f, 0.0f, -5.0f));

            Destroy(coll.gameObject);  //�Ԃ����������j��
            Destroy(gameObject);       //�e��j��
            
        }
    }



}
