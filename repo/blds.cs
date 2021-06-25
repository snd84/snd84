using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class blds : MonoBehaviour {
public int[] pr = new int[18];
int i;
int j;
int k;
int pi;
int pj;
public int pk;
int t=0;
float f;
float sw;
public Vector3 vc;
Vector3 jp;
//Vector3 rt;
public GameObject gm;
public Collider co;
public LayerMask lm;
Rigidbody rb;

GameObject[] gc = new GameObject[10];
public bool on =true;
GameObject[] cld;
Texture tp;
Sprite tmg;
public int li=5;
	// Use this for initialization
	public void set(int[] n){
		n.CopyTo(pr,0);
	}
	public int[] get(){
		return pr;
	}
	public void ggt(int n){
		if(gm!=null){Destroy(gm);}
		gm = Instantiate(date.rb[n],transform.position,transform.rotation,transform);
		gm.transform.localScale = transform.localScale;
		rovoko r = gm.GetComponent<rovoko>();
		rovoko y = date.rb[n].GetComponent<rovoko>();
		r.ins(y.ous());
		r.inmt0(y.ouc(0),y.oulc(0));
		r.inmt1(y.ouc(1),y.oulc(1));
		r.inmt2(y.ouc(2),y.oulc(2));
		r.inmt3(y.ouc(3),y.oulc(3));
		r.inmt4(y.ouc(4),y.oulc(4));
		r.inmt5(y.ouc(5),y.oulc(5));
		r.inmt6(y.ouc(6),y.oulc(6));
		r.inmt7(y.ouc(7),y.oulc(7));
		r.inmt8(y.ouc(8),y.oulc(8));
		
		r.onwk(y.ouwk());
		tmg = date.rbsp[n];
	}
	public void igt(int g){
		if(gm!=null){Destroy(gm);}
		gm = Instantiate(date.it[g],transform.position,transform.rotation,transform);
		gm.transform.localScale = transform.localScale;
		tmg = date.rbsp[g];
	}
	public int[] ongm(){
		return pr;
	}

	void Start () {
		vc = transform.position;
		pi = (int)vc.x/2;
		pj = (int)vc.z/2;
		//if(pr[0]==1){vc.y = date.izm[i,j].x;}
		//transform.position = vc;
		cld = new GameObject[transform.childCount];
		for(int i=0;i<cld.Length;i++){
			cld[i] = transform.GetChild(i).gameObject;
		}
		pr[17] = 100;
//		if(pr[2]==1){
//			r = new rovoko[pr[5]];
//			gc = new GameObject[pr[5]];
//		}
		if(pr[2]==0){
			pr[17] = 50;
		}	
		if(pr[2]==4){
		}
		if(pr[2]==3){
			if(pi<=0){pi=1;}
			if(pi>=141){pi=140;}
			if(pj<=0){pj=1;}
			if(pj>=141){pj=140;}

			sw = pr[4]*0.05f;
			pr[1]=1;
		}
		if(pr[2]==6){
			co = GetComponent<Collider>();
			co.enabled = false;
		}
		if(pr[2]==7){
		k=0;
		sw=0;
		pr[1]=0;
		gameObject.AddComponent<SphereCollider>();
		GetComponent<SphereCollider>().radius = 0;
		GetComponent<SphereCollider>().isTrigger=on;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(date.tiz==10){
		if(pr[0]==1){
			if(vc.y < date.izm[pi,pj].x || vc.y > date.izm[pi,pj].x+0.05f){
		//		RaycastHit h;
		//		Physics.Raycast(new Vector3(vc.x,150,vc.z),Vector3.down,out h,Mathf.Infinity,lm);
		//			if(h.collider.tag == "zimen"){
						vc.y = date.izm[pi,pj].x+0.05f; //h.point.y;
						transform.position = vc;
			}
		}else{
			if(vc.y < date.izm[pi,pj].x){
				on=false;
				gameObject.layer = 0;
			}else{
				on=true;
				gameObject.layer = 12;
			}
		}
		if(pr[1]==1){
			if(date.umi>vc.y || ((date.izm[pi,pj].x <= vc.y)&&(date.izm[pi,pj].z>vc.y)) ){
				on = false;
				gameObject.layer = 0;
			}
			if(date.umi <vc.y && (date.izm[pi,pj].z < vc.y+0.1f)){
				on = true;
				gameObject.layer = 12;
			}
		}
	}
		if(on){
		switch(pr[2]){
			case 0:
			break;
			case 1:
			break;
			case 2:
			break;
			case 3:
			if(date.tiz==10){
			if(pr[4]>0){
			if(date.izm[pi,pj].y <pr[4]){
			date.izm[pi,pj].y += sw;}
			}else if(pr[4]<0){
				if(date.izm[pi,pj].y > sw){
				date.izm[pi,pj].y += sw;
				}else{
				date.izm[pi,pj].y = 0;
				}			
			}
			}
			if(date.tiz<6){date.tiz = 11;}

			break;
			case 4:
			if(pr[16]==0 && gm!=null){
			if(t<0){
				t=pr[5];
				rbet();
			}
			t--;
			}
			break;
			case 5:
			break;
			case 6:
			break;
			case 7:
			if(date.tiz==9){
			izm.sgp[pi,pj].x = pk;
			izm.sgp[pi,pj].z = Mathf.Abs(pr[14]);
			izm.sgp[pi,pj].w = izm.q;
			}
			
			/*
			if(date.tiz==9){
			if(pk!=0){
			for(int q=pi-(int)(pr[10]/10);q<pi+(pr[10]/10);q++){
				for(int n=pj-(int)(pr[12]/10);n<pj+(pr[12]/10);n++){
					if(q>0&&q<141&&n>0&&n<141){
					izm.sgp[q,n].x = pk;
					izm.sgp[q,n].z = Mathf.Abs(pr[14]);
					izm.sgp[pi,pj].w=izm.q;
					}
				}
			}			
			}
			}
			*/
			if(date.tiz<6){date.tiz = 11;}	
			
			break;
			}
		}
	}
	public float wk(){
		return pr[4];
	}
	public float kk(){
		return pr[4]*0.1f;
	}
	public float pkimn(){
		return pr[0];
	}
	public float kimn(){
		return pr[5];
	}
	public bool ons(){
		return on;
	}
	public void onc(){
		if(on==true){
			on=false;
			for(i=0;i<cld.Length;i++){
				cld[i].layer = 15;
			}
		}else{
			on=true;
			for(i=0;i<cld.Length;i++){
				cld[i].layer = 12;
			}

		}
	}
	public int rtrt(){
		return pr[2];
	}
	public int get0(int n){
		return pr[n];
	}
	public Vector3 getp(){
		return transform.position;
	}
	public Vector3 getr(){
		return transform.eulerAngles;
	}
	public Vector3 gets(){
		return transform.lossyScale;
	}

	public void set0(int n,int k){
		pr[n] = k;
	}

	public void damg(int n){
		pr[17] -= Mathf.Abs(n);
		if(pr[17]<0){
		Destroy(gameObject);
		}
	}
	public void sopc(bool b){
		if(b){
		gameObject.tag = ("itms");
		}else{
		gameObject.tag = ("enag");
		}
	}
	public string tagr(){
		return gameObject.tag;
	}

	public void tgvc(Vector3 v){
	pr[10] = (int)v.x;
	pr[11] = (int)v.y;
	pr[12] = (int)v.z;
	}
	public void intsp(Sprite s){
		tmg = s;
	}
	public Sprite ousp(){
		return tmg;
	}

	public void prfc(Vector3 vv,Vector3 vr){
		pr[10] = (int)vv.x;
		pr[11] = (int)vv.y;
		pr[12] = (int)vv.z;
		pr[13] = (int)vr.x;
		pr[14] = (int)vr.y;
		pr[15] = (int)vr.z;
	}

	public void coby(){
		switch(pr[4]){
		case 0:
		if(GetComponent<BoxCollider>()!=null){
			Destroy(GetComponent<BoxCollider>());
		}
		if(GetComponent<SphereCollider>()==null){
			gameObject.AddComponent<SphereCollider>();
		}
		GetComponent<SphereCollider>().radius = pr[10]*0.05f;
		GetComponent<SphereCollider>().isTrigger=on;	
		break;

		case 1:
		if(GetComponent<BoxCollider>()==null){
			gameObject.AddComponent<BoxCollider>();	
		}
		GetComponent<BoxCollider>().size = new Vector3(pr[10]*0.1f,pr[11]*0.1f,pr[12]*0.1f);
		GetComponent<BoxCollider>().isTrigger=on;	
		if(GetComponent<SphereCollider>()!=null){
			Destroy(GetComponent<SphereCollider>());
		}
		break;

		case 2:
		if(GetComponent<BoxCollider>()!=null){
			Destroy(GetComponent<BoxCollider>());

		}
		if(GetComponent<SphereCollider>()!=null){
			Destroy(GetComponent<SphereCollider>());
		}
		break;
		
		}
		pk=0;
		if((int)pr[13]!=0 || (int)pr[15]!=0){
			if(Mathf.Abs(pr[13])>Mathf.Abs(pr[15])){
				if(pr[13]>0){pk=13;}else{pk=17;}
				k = Mathf.Abs(pr[13]);
			}else{
				if(pr[15]>0){pk=11;}else{pk=15;}
				k = Mathf.Abs(pr[15]);
			}
		}
	}

	void OnCollisionExit(Collision co){
//		if(co.gameObject.tag == "glp1" || co.gameObject.tag == "glp2" || co.gameObject.tag == "glp3"){}	
	}

	void OnCollisionEnter(Collision co){
		switch(pr[2]){
		case 2:
		co.rigidbody.velocity += new Vector3(pr[13],pr[14],pr[15]);
		break;
		case 4:
		if(pr[16]==2 && gm!=null){
			rbet();
		}
		break;
		}
	}
	void OnTriggerStay(Collider co){
		if(pr[2]==7 && gameObject.layer == 12){
		co.attachedRigidbody.AddForce(pr[13]*0.1f,pr[14]*0.1f,pr[15]*0.1f);
		//co.attachedRigidbody.velocity = new Vector3(pr[13],pr[14],pr[15]);
		}
	}

	public void rbet(){

//				for(k=0;k<pr[5];k++){
		for(k=0;k<pr[4];k++){
		if(gc[k]==null){
			if(gm.layer == 10){
				gc[k] = Instantiate(gm,transform.position,transform.rotation);
				gc[k].transform.position += new Vector3(pr[10]*0.05f,pr[11]*0.05f,pr[12]*0.05f) * transform.lossyScale.x;
				//gc[k].transform.eulerAngles += new Vector3(pr[13]*0.01f,pr[14]*0.01f,pr[15]*0.01f);
				gc[k].transform.localScale = Vector3.one;
				gc[k].transform.parent = null;
				rovoko r = gc[k].GetComponent<rovoko>();
				rovoko y = gm.GetComponent<rovoko>();
				//r.inc(y.ouc(),y.ous());
				r.inmt0(y.ouc(0),y.oulc(0));
				r.inmt1(y.ouc(1),y.oulc(1));
				r.inmt2(y.ouc(2),y.oulc(2));
				r.inmt3(y.ouc(3),y.oulc(3));
				r.inmt4(y.ouc(4),y.oulc(4));
				r.inmt5(y.ouc(5),y.oulc(5));
				r.inmt6(y.ouc(6),y.oulc(6));
				r.inmt7(y.ouc(7),y.oulc(7));
				r.inmt8(y.ouc(8),y.oulc(8));
				r.onwk(y.ouwk());
				gc[k].SetActive(true);
				break;
				}
			if(gm.layer == 13){
					gc[k] = Instantiate(gm,transform.position,transform.rotation);
					gc[k].transform.position += new Vector3(pr[10]*0.05f,pr[11]*0.05f,pr[12]*0.05f) * transform.lossyScale.x;
					gc[k].transform.eulerAngles += new Vector3(pr[13]*0.05f,pr[14]*0.05f,pr[15]*0.05f);
					gc[k].transform.localScale = transform.lossyScale*0.2f;
					gc[k].SetActive(true);
					break;
				}
			}
		}
	}


}
