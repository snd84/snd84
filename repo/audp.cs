using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audp : MonoBehaviour
{
public AudioSource ac;

    // Update is called once per frame
    void Update()
    {
        if(!ac.isPlaying){
        	Destroy(gameObject);
        }
    }
}
