using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject ball;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (BallController.enemyMove == true)
        {
            transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);
        }
    }
}
