using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class gifff : MonoBehaviour {
	public Sprite[] anm;
	public Image sr;
	bool b = false;
	int i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(b){
			anie();
		}
	}
	public void enter(){
		b = true;
	}
	public void anie(){
		sr.sprite = anm[i];
		i++;
		if(i>anm.Length-1){i=0;}
	}
	public void anio(){
		sr.sprite = anm[0];
		i=0;
		b = false;
	}

}
