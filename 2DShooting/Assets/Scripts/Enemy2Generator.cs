using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Generator : MonoBehaviour
{
    public GameObject Enemy2Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定

        //InvokeRepeating関数は第一引数の関数を第二引数の秒数ごとに実行してくれる関数("GenEnemy",人数,秒)
        InvokeRepeating("GenEnemy2", 1, 1);
    }

    void GenEnemy2()
    {
        //ランダムな位置にエネミー生成
        Instantiate(Enemy2Prefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
