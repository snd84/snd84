using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hole : MonoBehaviour {

public Text ht;
public LayerMask lm;

public RectTransform mmr;
public Image mg;

public MeshFilter mf;
public Mesh c;
public Mesh p;
public Mesh b;
public Mesh u;
public Mesh k;

public Image[] im;

public bool bc = false;
public RawImage pig;
public RectTransform piv;
public RectTransform pip;
public RectTransform psp;
public RawImage psmp;
public Material mt;
public Image img;
public Image tkp;
public Image tsp;
public RectTransform cpc;
public RectTransform hnk;

int cx=0;
int cy=0;
int cl=0;
int pct=0;
int chp=1;
int stc=0;
int stmpc=1;
bool elz=false;
Vector2 hnip;
Vector2 hnkp;

float brt = 0.01f;
float cra=1;
Color cr = Color.white;
Color[] cs = new Color[400];
Color32[] ct;
public RectTransform twp;
Vector2 vmp;
bool bl;
void Start (){
	pcor(0);
	
	for(int i=0;i <8;i++){
	date.stmp[i] = new Texture2D(32,32,TextureFormat.RGBA32,false);
	date.stmp[i].filterMode = FilterMode.Point;	
	}
	Color[] c = new Color[32*32];
	for(int i=0;i <c.Length;i++){
	c[i] = Color.white;
	}
	for(int i=0;i <8;i++){
	date.stmp[i].SetPixels(c);
	date.stmp[i].Apply();
	}

}

void  Update (){

	Ray r = 
	Camera.main.ScreenPointToRay(Input.mousePosition);
	RaycastHit h = new RaycastHit();

	if(Physics.Raycast(r,out h,Mathf.Infinity,lm)){
		if(h.collider.tag == ("del")){
			
		}else{
		if(h.collider.tag==("zimen")){
			transform.position = h.point;

			if(Input.GetMouseButton(0) && bl){
				//Ray q = new Ray (transform.position,Vector3(0,-1,0));
				Collider[] ns = Physics.OverlapCapsule(new Vector3(transform.position.x,150,transform.position.z),
														new Vector3(transform.position.x,-50,transform.position.z),date.hpw,256);
				for(int i=0;i<ns.Length;i++){
					if(ns[i].tag == ("zimen")){
					if(bc){
					ns[i].gameObject.SendMessage("nm",transform.position);
					}else{				
					int px = (int)((h.point.x/280f)*1024);
					int py = (int)((h.point.z/280f)*1024);
					int hp = (int)date.hpw*2;
					ct = date.ftx.GetPixels32();
					Color c;
					if(chp==0||chp==1){
					for(int n=px-hp;n <=px+hp;n++){
						for(int k=py-hp;k <=py+hp;k++){
							if(n>0 && n <1024 && k>0 && k < 1024) {
								if(chp==0 || ((n-px)*(n-px)) + ((k-py)*(k-py))<(hp*hp)){
									c = ct[k*1024 + n];
									c.b += ((cr.b-c.b)*(cra*cra));
									c.r += ((cr.r-c.r)*(cra*cra));
									c.g += ((cr.g-c.g)*(cra*cra));
									ct[k*1024 + n] = c;
								}
							}
						}
					}
					}else if(chp==2){
						Color[] cs = date.stmp[stc].GetPixels();
						float ix = hp*2;
						int xx = date.stmp[stc].width;
						int yy = date.stmp[stc].height;
						int xq;
						int yq;
						Color crs;
						for(int n=px-hp;n <px+hp;n++){
							if(n>0 && n <1024){
								xq = (n-(px-hp));
								xq = (int)(((float)xq / ix)*xx);							
							for(int k=py-hp;k <py+hp;k++){
							if(k>0 && k < 1024){
								yq = (k-(py-hp));
								yq = (int)(((float)yq / ix)*yy);
								crs = cs[(yq*yy) + xq];
								c = ct[k*1024 + n];
								c.b += ((crs.b-c.b)*crs.a)*cra;
								c.r += ((crs.r-c.r)*crs.a)*cra;
								c.g += ((crs.g-c.g)*crs.a)*cra;
								ct[k*1024 + n] = c;
								}
							}
							}
						}
					}else if(chp==3){
						Color[] cs = date.stmp[stc].GetPixels();
						float ix = hp*2;
						int xx = date.stmp[stc].width;
						int yy = date.stmp[stc].height;
						int xq;
						int yq;
						Color crs;
						for(int n=px-hp;n <px+hp;n++){
							if(n>0 && n <1024){
								xq = (int)((float)n%ix);
								xq = (int)(((float)xq / ix)*xx);
				
							for(int k=py-hp;k <py+hp;k++){
							if(k>0 && k < 1024){
								yq = (int)((float)k%ix);
								yq = (int)(((float)yq / ix)*yy);
			
								crs = cs[(yq*yy) + xq];
								c = ct[k*1024 + n];
								c.b += ((crs.b-c.b)*crs.a)*cra;
								c.r += ((crs.r-c.r)*crs.a)*cra;
								c.g += ((crs.g-c.g)*crs.a)*cra;
								ct[k*1024 + n] = c;
								}
							}
							}
						}
					}

					date.ftx.SetPixels32(ct);
					date.ftx.Apply();
					return;
					}
					}else{
					if(bc){
					if(ns[i].tag==("bl") || ns[i].tag==("it")){
							ns[i].attachedRigidbody.WakeUp();
						}
					}
					}
				}
			}
			}		
		}
	}
}

public void  moves (){
	Vector3[] v = new Vector3[4];
	twp.GetWorldCorners(v);
	Vector2 i = Input.mousePosition - v[0];
	i.y = (i.y/(v[2].y-v[0].y))*160;
	i.x = (i.x/(v[2].x-v[0].x))*160;

	if(i.x<1){i.x = 1;}
	if(i.x>160){i.x = 160;}
	if(i.y<1){i.y = 1;}
	if(i.y>160){i.y = 160;}

	mmr.anchoredPosition = i;
	i.x = i.x*0.625f;
	i.y = i.y*0.625f;

	i.y = Mathf.Round(i.y)-50;
	date.hsz = i.y;
	mg.color = new Color(1-(i.y * 0.01f),1-(i.y * 0.01f),1-(i.y * 0.01f));
	
	mmr.sizeDelta = new Vector2(10+i.x/5,10+i.x/5);
	transform.localScale = new Vector3(1+(i.x*0.5f),50,1+(i.x*0.5f));
	date.hpw = i.x*0.25f;
	ht.text = (""+Mathf.Round(i.y)+"\n"+Mathf.Round(i.x));
}

	public void smpp(){
		Vector2 i = Input.mousePosition;
		Vector3[] v = new Vector3[4];
		psp.GetWorldCorners(v);
		i.y = 720*((i.y-v[0].y)/Screen.height);
		i.x = 1280*((i.x-v[0].x)/Screen.width);

		Color32[] ch = date.stmp[stc].GetPixels32();
		int y = date.stmp[stc].height;
		int x = date.stmp[stc].width;
		if(i.x>=0 && i.x <256 && i.y>=0 && i.y <256){
			int yy = (int)((i.y/256)*y);
			int xx = (int)((i.x/256)*x);
			for(int k=yy-stmpc+1;k < yy+stmpc;k++){
				for(int j=xx-stmpc+1;j < xx+stmpc;j++){
				if(k>=0 && k <y && j>=0 && j <x) {
					if(elz==false){
					ch[(k*y)+j] = cr;
					}else{
					ch[(k*y)+j] = Color.clear;
					}
				}
				}
			}
			date.stmp[stc].SetPixels32(ch);
			date.stmp[stc].Apply();
		}
	}

	public void stmpcc(int n){
		stmpc = n;
	}
	public void stmpbl(bool b){
		elz = b;
	}

	public void hkpz(){
		Vector2 i= Input.mousePosition;
		i.y = 720*(i.y/Screen.height);
		i.x = 1280*(i.x/Screen.width);
		hnip = i;
		hnkp = hnk.anchoredPosition;
	}
	public void hkpzm(){
		Vector2 i= Input.mousePosition;
		i.y = 720*(i.y/Screen.height);
		i.x = 1280*(i.x/Screen.width);
		Vector2 v = hnip - i;
		hnk.anchoredPosition = hnkp - v;
		if(hnk.anchoredPosition.x<-1000){hnk.anchoredPosition = new Vector2(-1000,hnk.anchoredPosition.y);}
		if(hnk.anchoredPosition.x>0){hnk.anchoredPosition = new Vector2(0,hnk.anchoredPosition.y);}
		if(hnk.anchoredPosition.y>365){hnk.anchoredPosition = new Vector2(hnk.anchoredPosition.x,365);}
		if(hnk.anchoredPosition.y<0){hnk.anchoredPosition = new Vector2(hnk.anchoredPosition.x,0);}

	}

	public void	blo(bool b){
		bl = b;
	}
	public void birt(float n){
		brt = n;
		pcor(cl);
	}

	public void pcor(float f){
		int i = (int)f;
		cl = i;
		if(f<=35){
		cr = new Color(1f,0f,((1f/255f)*(i*7.3f)));
		}
		if(35<f && f<=70){
		i-=35;
		cr = new Color((1f-(1f/255f)*(i*7.3f)),0f,1f);
		}
		if(70<f && f<=105){
		i-=70;
		cr = new Color(0f,((1f/255f)*(i*7.3f)),1f);
		}
		if(105<f && f<=140){
		i-=105;
		cr = new Color(0f,1f,(1f-(1f/255f)*(i*7.3f)));
		}
		if(140<f && f<=175){
		i-=140;
		cr = new Color(((1f/255f)*(i*7.3f)),1f,0f);
		}
		if(175<f && f<=210){
		i-=175;
		cr = new Color(1f,(1f-(1f/255f)*(i*7.3f)),0f);
		}
		Color a = new Color(cr.r/19f,cr.g/19f,cr.b/19f,1f);
		for(i=0;i<20;i++){
			cs[i] = Color.black + (a * (float)i);
			for(int j=1;j<20;j++){
				cs[(j*20)+i] = cs[i] + (new Color(brt,brt,brt,0f)*j);//(new Color(0.025f,0.025f,0.025f,0f)*j);
			}
		}
		for(i=1;i<20;i++){
			cs[i*20] = new Color(0.0527f,0.0527f,0.0527f,1f) * i;
		}
		Texture2D t = new Texture2D(20,20);
		t.SetPixels(cs);
		t.Apply();
		t.filterMode = FilterMode.Point;
		pig.texture = t;
		pig.texture.wrapMode = TextureWrapMode.Clamp;
		cr = cs[cx+(cy*20)];
		cr.a = cra;
		img.color = cr;

	}
	public void pcorr(){
		Vector3[] v = new Vector3[4];
		piv.GetWorldCorners(v);
		int mx = (int)(((Input.mousePosition.x-v[0].x)/Screen.width)*1280f);
		int my = (int)(((Input.mousePosition.y-v[0].y)/Screen.height)*720f);

		if(mx>=0&&mx<100 && my>=0&&my<100){
			cx = mx/5;
			cy = my/5;
			cr = cs[cx+(cy*20)];
			switch(pct){
				case 1:
				mt.color = cr;
				tkp.color = cr;
				break;
				case 2:
				mt.SetColor("_OutlineColor",cr);
				tsp.color = cr;
				break;		
			}

			//cr.a = (date.hsz+50) * 0.01f;
			img.color = cr;	
			pip.anchoredPosition = new Vector2(2.5f+(cx*5)-50,2.5f+(cy*5)-50);
		}
	}

	public void pcc(int c){
		pct = c;
	}
	public void chpt(int c){
		chp = c;
		cpc.localPosition = Vector2.zero;
	}
	public void psmc(int c){
		stc = c;
		psmp.texture = date.stmp[c];
	}
	public void psma(float f){
		cra = f;
		pcor(cl);
	}

public void chos(int n){
switch(n){
	case 0:
	t1();
	bc=true;
	break;
	case 1:
	t2();
	bc=true;
	break;
	case 2:
	t3();
	bc=true;
	break;
	case 3:
	t4();
	bc=true;
	break;
	case 4:
	im[date.hol].color = Color.gray;
	im[4].color = new Color(1,1,0.3f,1);
	date.hol=4;
	cr = cs[cx+(cy*20)];
	img.color = cr;
	//cr.a = (date.hsz+50) * 0.01f;
	mf.mesh = k;
	psmp.texture = date.stmp[stc];
	bc=false;
	break;
	case 5:
	im[date.hol].color = Color.gray;
	im[5].color = new Color(1,1,0.3f,1);
	date.hol=5;
	cr = new Color(1,1,1,0);
	mf.mesh = null;
	bc=false;
	break;

}
}
void  t1 (){
	im[date.hol].color = Color.gray;
	im[0].color = new Color(1,1,0.3f,1);
	date.hol=0;
	mf.mesh = c;
//	ht.text = (""+(mhl));
}
void  t2 (){
	im[date.hol].color = Color.gray;
	im[1].color = new Color(1,1,0.3f,1);
	date.hol=1;
	mf.mesh = p;
//	ht.text = (""+(mhl));
}
void  t3 (){
	im[date.hol].color = Color.gray;
	im[2].color = new Color(1,1,0.3f,1);
	date.hol=2;
	mf.mesh = b;
//	ht.text = (""+(mhl+50));
}
void  t4 (){
	im[date.hol].color = Color.gray;
	im[3].color = new Color(1,1,0.3f,1);
	date.hol=3;
	mf.mesh = u;
//	ht.text = (""+(mhl+50));
}

}