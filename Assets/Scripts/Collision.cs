using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    public GameObject pan;
    public GameObject FinishPnl;
    private AudioSource victorySound;


    void Start()
    {
        victorySound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Spikes"))
        {
            Debug.Log("Collision Detected");
            soundOnCollision.blastSound();
            GameObject e = Instantiate(explosion) as GameObject;
            
            e.transform.position = transform.position;  //At position of Collision
            this.gameObject.SetActive(false);
            pan.SetActive(true);


        }

        if (collision.gameObject.name == "flag1")
        {
            victorySound.Play();
            FinishPnl.SetActive(true);
        }

        if(collision.gameObject.CompareTag("Bombs"))
        {
            Debug.Log("Collision Detected");
            soundOnCollision.blastSound();
            GameObject e = Instantiate(explosion) as GameObject;
            
            e.transform.position = transform.position;  //At position of Collision
            this.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
            pan.SetActive(true);
            
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
