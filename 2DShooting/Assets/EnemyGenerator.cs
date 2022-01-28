using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenEnemy", 1, 1);
    }

    void GenEnemy()
    {
        Instantiate(EnemyPrefab, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
