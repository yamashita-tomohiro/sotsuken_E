using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPS��144�ɐݒ�
        
        //InvokeRepeating�֐��͑������̊֐���������̕b�����ƂɎ��s���Ă����֐�("GenEnemy",�l��,�b)
        InvokeRepeating("GenEnemy", 1, 1);
    }

    void GenEnemy()
    {
        //�����_���Ȉʒu�ɃG�l�~�[����
        Instantiate(EnemyPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
