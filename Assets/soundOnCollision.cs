using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private static AudioSource blast;
    void Start()
    {
        blast = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void blastSound()
    {
        blast.Play();
    }
}
