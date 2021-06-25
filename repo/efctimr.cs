using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efctimr : MonoBehaviour
{
	public ParticleSystem ps;
    void Update()
    {
	if(!ps.isPlaying){
		Destroy(gameObject);
	}        
    }
}
