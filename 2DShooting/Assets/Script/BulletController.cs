using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;  //爆発エフェクトのPrefab
    // 効果音
    public AudioClip se;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 144; //FPSを144に設定
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

            // 衝突したときにスコアを更新する
            GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

            //爆発エフェクトを生成する
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            // 効果音再生
            AudioSource.PlayClipAtPoint(se, new Vector3(0.0f, 0.0f, -5.0f));

            Destroy(coll.gameObject);  //ぶつかった相手を破壊
            Destroy(gameObject);       //弾を破壊
            
        }
    }



}
