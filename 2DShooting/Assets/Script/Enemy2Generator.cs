using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Generator : MonoBehaviour
{
    public GameObject Enemy2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPS��144�ɐݒ�

        //InvokeRepeating�֐��͑������̊֐���������̕b�����ƂɎ��s���Ă����֐�("GenEnemy",�l��,�b)
        InvokeRepeating("GenEnemy2", 1, 1);
    }

    void GenEnemy2()
    {
        //�����_���Ȉʒu�ɃG�l�~�[����
        Instantiate(Enemy2Prefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
