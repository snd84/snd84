using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tenk : MonoBehaviour {
public GameObject wl;
public RectTransform ty;
public Slider sx;
public Slider sy;
public Light wt;
public Text tx;

public Slider ac;
public Slider bc;
public Slider gc;


Vector2 vc;
Vector2 vp;

public RectTransform rc;
public GameObject gm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void tymv(){
		Vector2 v = (Vector2)Input.mousePosition - vc;
		v.y = 720*(v.y/Screen.height);
		v.x = 1280*(v.x/Screen.width);
		v = v+vp;
		if(v.x<40){v.x = 40;}
		if(v.x>360){v.x = 360;}
		if(v.y<150){v.y = 150;}
		if(v.y>470){v.y = 470;}
		ty.anchoredPosition = v;
		v.x = (v.x-200)*0.1f;
		v.y = (v.y-310)*0.1f;

		wl.transform.position = new Vector3(v.x,20,v.y);
		wl.transform.transform.LookAt(gm.transform);
	}
	public void tix(){
		wl.transform.eulerAngles = new Vector3(sx.value,sy.value,0);
	}
	public void wtl(float f){
		wt.intensity = f;
	}
	public void wss(float f){
		wt.shadowStrength = f;
	}
	public void wsb(float f){
		wt.shadowNormalBias = f;
	}


	public void txe(float f){
		tx.text = (""+(int)f);
		date.pt = (int)f;
	}
	public void butm(int i){
		date.tm = i;
	}

	public void on(){
		vc = Input.mousePosition;
		vp = ty.anchoredPosition;
	}
	public void lcc(){
		wt.color = new Color(ac.value*0.1f,gc.value*0.1f,bc.value*0.1f);
	}
	public void cdon(bool b){
		if(b){wt.shadows = LightShadows.Soft;}
		if(!b){wt.shadows = LightShadows.None;}

	}


}
