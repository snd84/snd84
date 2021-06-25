using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class okkus : MonoBehaviour {

public Image[] bl = new Image[20];
public Image[] rb = new Image[20];
public Image[] it = new Image[20];
public Image[] vq = new Image[20];

public Image to;
public RectTransform rc;
public GameObject hk;
public GameObject mr;
public GameObject dn;
public GameObject dl;
public GameObject dlb;
public GameObject pi;
public GameObject tr;
public GameObject rk;
public GameObject et;
public GameObject wid;



public MeshFilter mf;
public Slider sl1;
public Slider sl2;
public Slider sl3;

public Slider[] sl = new Slider[6];
public Text[] xt = new Text[6];

Vector3 vl = Vector3.one;
Vector3 vs = Vector3.zero;
Vector3 vl2 = Vector3.one;
Vector3 vs2 = Vector3.zero;

bool key = true;
	
Vector3 rt;
float sz = 1f;
GameObject pg;
Ray r;
RaycastHit h;
public LayerMask lm;
//int c;
int nb;
int deb=0;
GameObject g;
Vector3 ht = new Vector3(0,0.5f,0);
float tks;
public Text[] tx = new Text[5];
int dct = 10;

Vector2 movh;
Vector2 movp;
GameObject[] mqg = new GameObject[20];
public RectTransform pnl;
bool ofn=true;

	// Use this for initialization
	void Start () {
		g = hk;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 v = Input.mousePosition;
		v.y = 720*(v.y/Screen.height);
		v.x = 1280*(v.x/Screen.width);
			if(v.y < 640 && v.x > 240 && ofn){
			//	if(pi.activeSelf==false){pi.SetActive(true);}
			
				r = Camera.main.ScreenPointToRay(Input.mousePosition);
				if(g.tag!=("del")){

				if(Physics.Raycast(r,out h,Mathf.Infinity,lm)){
					if(h.collider.tag == "zimen"){
					pi.transform.position = h.point + ht;
					if(Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1)){
					
						//pg =  Instantiate(g,pi.transform.position,Quaternion.identity);
						//pg.transform.localScale = Vector3.one * sz;
						//pg.transform.eulerAngles = rt;
						
						if(g.tag == ("it")){
							pg = Instantiate(g,pi.transform.position,Quaternion.identity);
							pg.name = (""+nb);
							pg.transform.eulerAngles = vs;	
							pg.transform.localScale = vl;//Vector3.one * sz;
							//pg.transform.position += new Vector3(0,pg.transform.localScale.y,0);
							pg.SetActive(true);
						}

						if(g.tag == ("arm")||g.tag == ("wepn")||g.tag == ("coin")){
							pg =  Instantiate(g,pi.transform.position,Quaternion.identity);
							pg.name = (""+nb);
							pg.transform.eulerAngles = vs;	
							pg.transform.localScale = vl*0.2f;//Vector3.one * sz;
							pg.transform.position += new Vector3(0,pg.transform.localScale.y,0);
							pg.SetActive(true);
						}
						if(g.tag == ("bl")){
							pg =  Instantiate(g,pi.transform.position,Quaternion.identity);
							pg.name = (""+nb);
							pg.transform.eulerAngles = vs2;	
							pg.transform.localScale = vl2;// Vector3.one * (sz * 2f);
							pg.SetActive(true);
						}
						if(g.tag == ("wk")|| g.tag == ("camp") || g.tag == ("itms")|| g.tag == ("enag")|| g.tag == ("tree")){
							pg =  Instantiate(g,pi.transform.position,Quaternion.identity);
							pg.name = (""+nb);
							pg.transform.eulerAngles = vs;	
							pg.transform.localScale = vl2;// Vector3.one * (sz * 2f);
							pg.SetActive(true);
						}
						if(g.tag == ("del")){
							//pg.transform.localScale = Vector3.one * (sz * 5f);
						}

						if(g.tag == ("glp1") || g.tag == ("glp2") || g.tag == ("glp3")){
							pg =  Instantiate(g,pi.transform.position,Quaternion.identity);
							rovoko r = pg.GetComponent<rovoko>();
							rovoko y = g.GetComponent<rovoko>();
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
							
							tks = pg.GetComponent<CapsuleCollider>().height;
							tks += pg.GetComponent<CapsuleCollider>().center.y;
							tks = (tks/2f)*(sl[1].value*0.1f);
							pg.transform.position = new Vector3(pg.transform.position.x,pg.transform.position.y + tks,pg.transform.position.z);
							pg.transform.eulerAngles = vs2;
							pg.transform.localScale = vl2;
							pg.SetActive(true);
						}
						
						pg = null;
						}
						if(dct <= 0 && Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
						if(g.tag == ("Fire")){
							pg =  Instantiate(g);
//							pg.name = (""+nb);
							Vector3 k = Input.mousePosition;
							//pg.transform.localScale = Vector3.one * (sz * 0.2f);
							pg.transform.localScale = vl*0.2f;
							k.z = 10f;
							pg.transform.position = Camera.main.ScreenToWorldPoint(k);
							pg.transform.LookAt(h.point);
							dct = 10;
							pg.SetActive(true);
							pg = null;
						}
						}else{
							if(dct>0){dct--;}
						}
					}
					if(h.collider.tag == "del"){
						if(dct <= 0 && Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
							if(g.tag == ("Fire")){
							pg = Instantiate(g);//,pi.transform.position,Quaternion.identity);
							//pg.transform.localScale = Vector3.one * sz;
//							pg.name = (""+nb);
							Vector3 k = Input.mousePosition;
							pg.transform.localScale = vl * 0.2f;// Vector3.one * (sz * 0.2f);
							k.z = 10f;
							pg.transform.position = Camera.main.ScreenToWorldPoint(k);
							pg.transform.LookAt(h.point);
							dct = 10;
							pg.SetActive(true);
							pg = null;
							}
						}else{
							if(dct>0){dct--;}
						}
					}
					
				}
				}else{
					if(Physics.Raycast(r,out h,Mathf.Infinity,lm)){
						pi.transform.position = h.point;
						pi.transform.localScale = vl;
						pi.transform.eulerAngles = Vector3.zero;
					if(Input.GetMouseButtonDown(0) && !Input.GetMouseButtonDown(1)){
						Collider[] ns;
						switch(deb){
						case 0:
							ns = Physics.OverlapCapsule(new Vector3(h.point.x,150,h.point.z),
							new Vector3(h.point.x,-50,h.point.z),sl[0].value*0.05f);
							for(int i=0;i<ns.Length;i++){
							if(ns[i].gameObject.layer == 12){
								Destroy(ns[i].gameObject.transform.parent.gameObject);
							}	
							if(ns[i].tag ==  ("it") || ns[i].tag == ("glp1") || ns[i].tag == ("glp2") || ns[i].tag == ("glp3")|| ns[i].tag == ("itms")|| ns[i].tag == ("enag")){
								Destroy(ns[i].gameObject);
							}

							}
						break;
						case 1:
							ns = Physics.OverlapSphere(h.point,sl[0].value*0.05f);
							for(int i=0;i<ns.Length;i++){
							if(ns[i].gameObject.layer == 12){
								Destroy(ns[i].gameObject.transform.parent.gameObject);
							}	
							if(ns[i].tag ==  ("it") || ns[i].tag == ("glp1") || ns[i].tag == ("glp2") || ns[i].tag == ("glp3")|| ns[i].tag == ("itms")|| ns[i].tag == ("enag")){
								Destroy(ns[i].gameObject);
							}
							}
						break;
						}

					}
					}

				}
			}else{
			//	pi.SetActive(false);
			}
		if(Input.GetMouseButton(1) && Input.mouseScrollDelta.y!=0){
			if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl)){sl1.value += Input.mouseScrollDelta.y*0.5f;}
			if(Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl)){sl2.value += Input.mouseScrollDelta.y;}
			if(!Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftControl)){sl3.value += Input.mouseScrollDelta.y*5;}


		}
		//if(!Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.F)){sl2.value += 0.1f;}
		//if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.F)){sl2.value -= 0.1f;}
		//if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.R) && !Input.GetKey(KeyCode.F)){sl3.value += 1f;}
		//if(Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.F)){sl3.value -= 1f;}
		

	}
	public void htc(float f){
		ht.y = f;
		tx[0].text = (""+ht.y);
	}
	public void relo(){
		to.sprite = null;
		for(int i=0;i<20;i++){
			if(date.bl[i] != null){
			bl[i].sprite = date.blsp[i];
			}else{
			bl[i].sprite = null;
			}
			if(date.rb[i] != null){
			rb[i].sprite = date.rbsp[i];
			}else{
			rb[i].sprite = null;
			}
			if(date.it[i] != null){
			it[i].sprite = date.itsp[i];
			}else{
			it[i].sprite = null;	
			}
			if(date.vq[i] != null){
			vq[i].sprite = date.vqsp[i];
			}else{
			vq[i].sprite = null;	
			}

		}
	}

	public void csrb(int n){
		if(date.rb[n] != null){		
		g = date.rb[n];
	//	to.sprite=date.rbsp[n];
		rc.localPosition = Vector3.zero;
		mf.mesh = null;//date.rb[n].GetComponent<MeshFilter>().sharedMesh;
		}
	}

	public void csbl(int n){		
		if(date.bl[n] != null){		
		g = date.bl[n];
	//	to.sprite=date.blsp[n];
		rc.localPosition = Vector3.zero;
		//Mesh[] mu = new Mesh[g.transform.childCount];
		CombineInstance[] ci = new CombineInstance[g.transform.childCount];

		for(int k=0;k<g.transform.childCount;k++){
			ci[k].mesh = g.transform.GetChild(k).gameObject.GetComponent<MeshFilter>().mesh;
			ci[k].transform = g.transform.GetChild(k).transform.localToWorldMatrix;
		}
		mf.mesh = null;
		mf.mesh.CombineMeshes(ci);// = date.bl[n].GetComponent<MeshFilter>().sharedMesh;
		}
	}
	public void csit(int n){		
		if(date.it[n] != null){		
		g = date.it[n];
	//	to.sprite=date.itsp[n];
		rc.localPosition = Vector3.zero;
		nb = n;
		if(g.tag!="Fire"){
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
		}else{
		mf.mesh = null;	
		}
		}
	}
	public void csvq(int n){		
		if(date.vq[n] != null){
			if(mqg[n]==null){		

			mqg[n] = Instantiate(date.vq[n]);
			/*
			vlocs vl = mqg[n].GetComponent<vlocs>();
			vlocs vq = date.vq[n].GetComponent<vlocs>();
			for(int k=0;k<5;k++){
			if(vq.ovp(k)!=null){
			vl.pro(k,vq.ovp(k).Length);
			vq.ovp(k).CopyTo(vl.ovp(k),0);
			vq.ovr(k).CopyTo(vl.ovr(k),0);
			vq.ovt(k).CopyTo(vl.ovt(k),0);
			}
			}
			vl.ins(vq.ous());
			vl.intp(vq.outp());
			*/
			mqg[n].SetActive(true);
			rc.localPosition = Vector3.zero;
			}else{
				Destroy(mqg[n]);
			}
		}
	}

	public void hkc(){
		g = hk;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void mrc(){
		g = mr;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void drc(){
		g = dn;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = null;
	}
	public void rkt(){
		g = rk;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = null;
	}
	public void del(){
		g = dl;
		deb = 0;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void delb(){
		g = dlb;
		deb = 1;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}

	public void tri(){
		g = tr;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void entu(){
		g = et;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void wind(){
		g = wid;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void jury(){
		g = wid;
		to.sprite = null;
		rc.localPosition = Vector3.zero;
		mf.mesh = g.GetComponent<MeshFilter>().sharedMesh;
	}
	public void hitn(float f){
		ht.y = f;
		tx[0].text = (""+ht.y);
	}
	public void rotn(float f){
		rt.y = f;
		tx[2].text = (""+rt.y);
		pi.transform.eulerAngles = rt;
	}
	public void szhn(float f){
		sz = f*0.1f;
		tx[1].text = (""+sz);
		pi.transform.localScale = Vector3.one * (transform.localScale.x / transform.lossyScale.x)*sz;
	}
	public void vlh(float f){
		if(!Input.GetMouseButton(1)){
		vl.x = sl[0].value*0.1f;xt[0].text = ("x:"+sl[0].value*0.1f);
		vl.y = sl[1].value*0.1f;xt[1].text = ("y:"+sl[1].value*0.1f);
		vl.z = sl[2].value*0.1f;xt[2].text = ("z:"+sl[2].value*0.1f);
		pi.transform.localScale = new Vector3((pi.transform.localScale.x/pi.transform.lossyScale.x)*vl.x,(pi.transform.localScale.y/pi.transform.lossyScale.y)*vl.y,(pi.transform.localScale.z/pi.transform.lossyScale.z)*vl.z);
		}else{
			if(key){
				key = false;
				vl.x = f*0.1f;sl[0].value = f;xt[0].text = ("x:"+f*0.1f);
				vl.y = f*0.1f;sl[1].value = f;xt[1].text = ("y:"+f*0.1f);
				vl.z = f*0.1f;sl[2].value = f;xt[2].text = ("z:"+f*0.1f);
				key = true;
				pi.transform.localScale = new Vector3((pi.transform.localScale.x/pi.transform.lossyScale.x)*vl.x,(pi.transform.localScale.y/pi.transform.lossyScale.y)*vl.y,(pi.transform.localScale.z/pi.transform.lossyScale.z)*vl.z);
			}			
		}
		vl2 = Vector3.one * vl.y;
	}
	public void vsh(float f){
		if(!Input.GetMouseButton(1)){
		vs.x = sl[3].value*5;xt[3].text = ("x:"+sl[3].value*5);
		vs.y = sl[4].value*5;xt[4].text = ("y:"+sl[4].value*5);
		vs.z = sl[5].value*5;xt[5].text = ("z:"+sl[5].value*5);
		}else{
		vs.x = Mathf.Round((sl[3].value/18))*90;xt[3].text = ("x:"+vs.x);
		sl[3].value = vs.x;
		vs.y = Mathf.Round((sl[4].value/18))*90;xt[4].text = ("y:"+vs.y);
		sl[4].value = vs.y;
		vs.z = Mathf.Round((sl[5].value/18))*90;xt[5].text = ("z:"+vs.z);
		sl[5].value = vs.z;
		}
		pi.transform.eulerAngles = vs;
		vs2 = Vector3.up * (f*0.1f);

	}

	public void mov(){
		movh = Input.mousePosition;
		movp = pnl.anchoredPosition;
		ofn=false;
	}
	
	public void movc(){
		Vector2 vm = movh - (Vector2)Input.mousePosition;
		pnl.anchoredPosition = movp - vm;
		if(pnl.anchoredPosition.x < -200){pnl.anchoredPosition = new Vector2(-200,pnl.anchoredPosition.y);}
		if(pnl.anchoredPosition.x > 760){pnl.anchoredPosition = new Vector2(760,pnl.anchoredPosition.y);}
		if(pnl.anchoredPosition.y > 580){pnl.anchoredPosition = new Vector2(pnl.anchoredPosition.x,580);}
		if(pnl.anchoredPosition.y < 75){pnl.anchoredPosition = new Vector2(pnl.anchoredPosition.x,75);}
	}
	public void movf(){
		ofn = true;
	}


}
