using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TateScroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * speed);

        if (transform.position.y <= -16.0f)
        {
            transform.position = new Vector2(0, 16.0f);
        }

    }
}
