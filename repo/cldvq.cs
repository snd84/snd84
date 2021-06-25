using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cldvq : MonoBehaviour
{
public vlocs vs;
	public void OnCollisionEnter(){
		vs.hits();
	}
}
