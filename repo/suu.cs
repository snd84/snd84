using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class suu : MonoBehaviour
{
	public float pw = 5;
	public Text[] txp = new Text[2];
	void Update(){
		int x = (int)(transform.position.x/2f);
		int z = (int)(transform.position.z/2f);
		float sc = transform.localScale.x/5f;
		int h;
	for(int i=x-(int)sc;i<x+(int)sc;i++){
		for(int j=z-(int)sc;j<z+(int)sc;j++){
			if(i>=0&&i<=140 && j>=0&&j<=140){
				if(date.izm[i,j].z > transform.position.y-sc){
				h = ((x-i)*(x-i)) + ((z-j)*(z-j));
				if(h<(sc*sc)){
				izm.sgp[i,j].y = -((((sc*sc)-h)/(sc*sc))*pw);
				if(date.tiz<6){date.tiz=11;}
				}
				}
			}
		}
	}
	}
	void OnTriggerStay(Collider co){
		if(co.attachedRigidbody!=null){
			co.attachedRigidbody.velocity = (transform.position - co.transform.position).normalized * pw;

		}
	}
	public void trlc(float f){
		transform.localScale = Vector3.one * f;
		txp[0].text = (""+f);
	} 
	public void trpw(float f){
		if(f>0){f+=5;}else{f-=5;}
		pw = f;
		txp[1].text = (""+f);
	} 

}
