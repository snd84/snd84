using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class kfkl : MonoBehaviour {

//public RectTransform ch;
//public MeshFilter cr;
public GameObject core;
public GameObject part;
//public GameObject rnt;
public Slider sx;
public Slider sy;
public Slider sz;
public Slider stm;
public Slider smi;
public Slider srs;
　
//public Image[] ri;
//public GameObject[] go = new GameObject[21];
public RectTransform[] re = new RectTransform[21];
public RectTransform ra;
public Slider[] msl = new Slider[21]; 
public Image[] ir = new Image[42];
public Image[] im = new Image[30];
//int[,] reit = new int[2,21];

public Camera ca;
public GameObject cag;

public Text te;
public Text ret;
public Text radt;
public Text rads;
bool bord=true;
public Text[] ppt = new Text[3];
public Text[] pobt = new Text[19];

public RectTransform chs;
public Image[] rbs = new Image[10];
public GameObject[] liev = new GameObject[20];
public Sprite sidr;

public GameObject plan;
public GameObject cr;

public Material mtd;
public GameObject coht;

Image rim;

GameObject[] pob = new GameObject[21];



Vector3[,,] rmj = new Vector3[9,22,300];

int[] rmt = new int[9];
int[,] rmi = new int[9,21];
int[] rmc = new int[20];


int m=1;
int o;
int cm;
int bn = 0;
int ct = 0;
int rd;

int reseze =0;
//int rtmi;
int vi;
int j;

Vector3 v;
Vector3 vr;
Vector2 mp;
float fs = 10f;
int ff=0;
int so;

int p;
bool sv=false;
public Image pa;
public Sprite[] ik3;
public RectTransform rlt;
public GameObject cand;
public GameObject canr;
public GameObject canu;


	void Start () {
		pob[0] = core;
		for(int a=0;a<9;a++){
			rmt[a] = 1;
			for(int b=0;b<21;b++){
				rmi[a,b] = 0;
				for(int c=0;c<300;c++){
					rmj[a,b,c] = Vector3.zero;
				}
			}
		}
		/*
		for(int c=0;c<300;c++){
			rmj[0,22,c] = Vector3.zero;
			rmj[1,22,c] = Vector3.zero;
			rmj[2,22,c] = Vector3.zero;
			rmj[3,22,c] = Vector3.zero;
			rmj[4,22,c] = Vector3.zero;
			rmj[5,22,c] = Vector3.zero;
			rmj[6,22,c] = Vector3.zero;
			rmj[7,22,c] = Vector3.zero;
			rmj[8,22,c] = Vector3.zero;
		}
		*/
		m=1;
		plan.transform.position = Vector3.zero;
		cag.transform.position = Vector3.zero;
		core.transform.parent = null;
		core.transform.localScale = Vector3.one;
		core.transform.parent = plan.transform;
		core.GetComponent<MeshFilter>().mesh=null;

		coht.transform.parent = null;
		coht.transform.localPosition = Vector3.zero;
		coht.transform.localScale = Vector3.one;
		coht.transform.parent = plan.transform;
	}

	void Update(){

		anime();
		//ht();
		motip();
	}

	public void cct(float f){
		ct = (int)f;
	}

	public void btn(int n){
		bn = n;
		stm.maxValue = rmt[bn];
		stm.value = 0;
		smi.maxValue = rmt[bn];
		smi.value = rmi[bn,cm];
		te.text=(ct+"/"+smi.value+"/"+rmt[bn]);
		ra.localPosition = Vector3.zero;
		sx.value = rmj[bn,cm,ct].x;
		sy.value = rmj[bn,cm,ct].y;
		sz.value = rmj[bn,cm,ct].z;
		for(vi=0;vi<m;vi++){
			msl[vi].maxValue = rmt[bn];
			msl[vi].value = rmi[bn,vi];
		}
		core.transform.localPosition = rmj[bn,21,ct];		

	}
	public void anm(){
	
		for(vi=0;vi<m;vi++){
			if(ct<=rmi[bn,vi]){
			pob[vi].transform.localEulerAngles = rmj[bn,vi,ct];
			}
		}
		if(ct <=rmi[bn,0]){
		core.transform.localPosition = rmj[bn,21,ct];
		}
		sx.value = rmj[bn,cm,ct].x;
		sy.value = rmj[bn,cm,ct].y;
		sz.value = rmj[bn,cm,ct].z;
		stm.value = ct;
	}
	void anime(){
		switch (p){
			case 0:
			
			break;

			case 1:
			
			if(ct<=rmt[bn]){
				anm();
				ct++;
			}
			break;

			case 2:
			if(ct<=rmt[bn]){
				anm();
				ct++;
			}else{
			ct=0;	
			}
			
			break;
		}
	}

	public void py(){
		p++;
		if(p >=3){p=0;}
		pa.sprite = ik3[p];
	}

	public void msnu(){
		for(vi=0;vi<50;vi++){
			if(date.ms[vi] != null){
				im[vi].sprite = date.se[vi];
			}else{
				im[vi].sprite = null;
			}
		}
		for(vi=0;vi<20;vi++){
			if(date.rb[vi] != null){
				rbs[vi].sprite = date.rbsp[vi];
			}else{
				rbs[vi].sprite = null;
			}
		}

	}
/*
	void ht(){
		for(vi=1;vi<m;vi++){
			if(re[vi].parent.gameObject==rnt){
				if(vi==cm){vi++;if(vi>m){break;}}
				Vector2 vv= re[vi].anchoredPosition;
			for(j=vi+1;j <m;j++){
				if(//reit[0,vi]>0 || 
					j==cm){break;}
				Vector2 vj= re[j].anchoredPosition;
			if((vv.y > vj.y-40&&vv.y < vj.y+40)
			&&(vv.x > vj.x-80&&vv.x < vj.x+80))
			{
				vv += (vv - vj)*0.05f;
				vj -= (vv - vj)*0.05f;
			
				if(vv.x<60){vv.x=60;}
				if(vv.x>250){vv.x=250;}
				
				if(vv.y<20){vv.y = 20;}
				if(vv.y>470){vv.y = 470;}

				if(vj.x<60){vj.x=60;}
				if(vj.x>250){vj.x=250;}
				
				if(vj.y<20){vj.y = 20;}
				if(vj.y>470){vj.y = 470;}

				re[vi].anchoredPosition = vv;
				re[j].anchoredPosition = vj;
			}
		}
			
		}

	}

}
*/
	public void chos(int i){
		if(date.ms[i]!=null){
		//ch.localPosition = new Vector3(0,0,0);
		o = i;
		add();
		}
	}
	public void meshout(){
		pob[cm].GetComponent<MeshFilter>().mesh =null;
		ir[21+cm].sprite =null;
		sv = false;
	}

	public void chois(int i){
		ir[cm].color = new Color(1f,1f,1f,0.25f);
		cm = i;
		ir[cm].color = new Color(1f,1f,0.8f,0.8f);
		smi.value = rmi[bn,cm];
		sx.value = rmj[bn,cm,ct].x;
		sy.value = rmj[bn,cm,ct].y;
		sz.value = rmj[bn,cm,ct].z;
		ppt[0].text =("x:"+pob[cm].transform.position.x);
		ppt[1].text =("y:"+pob[cm].transform.position.y);
		ppt[2].text =("z:"+pob[cm].transform.position.z);
		te.text=(ct+"/"+smi.value+"/"+rmt[bn]);
	}


	public void sbpt(){
		if(m<21){	
		re[m].gameObject.SetActive(true);
		pob[m] = Instantiate(part,core.transform.position,Quaternion.identity,core.transform);
		pob[m].layer = 9;
		rmc[m-1] = 0;
		msl[m].maxValue = rmt[bn];
		msl[m].value = rmi[bn,m];
		pobt[m].text = ("1");
		m++;
			for(vi=1;vi<m;vi++){
				mp = re[vi].anchoredPosition;
				mp.y = 560f-((560f/(m-1))*(vi-1));
				re[vi].anchoredPosition = mp;
			}
//		Vector3[,] vb = new Vector3[m,rmt[bn]];
//		for(vi=0;vi<m;vi++){
//			if(vi==m-1){
//					for(j=0;j<rmt[bn];j++){
				//		vb[vi,j] = new Vector3(0,0,0);
//					}
//				}else{
//					for(j=0;j<rmi[bn,cm];j++){
				//		vb[vi,j] = rmj[bn][vi,j];
//				}
//					}
//			}
		//rmj[bn] = new  Vector3[m,rmt[bn]];
		//rmj[bn] = vb;
		}
	}

	public void sbpd(){
		if(m>1){
		m--;
		if(m==cm){chois(0);}
		re[m].gameObject.SetActive(false);
		Destroy(pob[m]);
		rmc[m-1] = 0;
		pobt[cm].text = ("1");
		//Destroy(pob[m].gameObject);
			for(vi=1;vi<m;vi++){
				mp = re[vi].anchoredPosition;
				mp.y = 560f-((560f/(m-1))*(vi-1));
				re[vi].anchoredPosition = mp;
			}
		}
	}

	public void add(){
			if(cm==0){sv=true;}
			pob[cm].GetComponent<MeshFilter>().mesh = Instantiate(date.ms[o]);
			MeshRenderer mr = pob[cm].GetComponent<MeshRenderer>();
			if(date.mt[o]!=null){
			mr.material = Instantiate(date.mt[o]);
			}else{
			mr.material = mtd;
			}
			//mr.material.mainTexture = Instantiate(date.tx[o]);
			ir[21+cm].sprite = date.se[o];
			//if(cm==0){
					 //core.GetComponent<MeshFilter>().mesh =date.obj[i];// mseve.part[o];
					 // rim.texture = mseve.gr[o]; 
					  //pob[0] = core;
			//		 }
			//else{
			//pob[cm].GetComponent<MeshFilter>().mesh = date.obj[i];//mseve.part[o];
			//rim.texture = mseve.gr[o];
			//}
		/*
		if(mseve.part[o]!=null){
			if(cm==0){core.GetComponent<MeshFilter>().mesh = mseve.part[o];
					  rim.texture = mseve.gr[o]; 
					  pob[0] = core;
					 }
			else{
			pob[cm].GetComponent<MeshFilter>().mesh = mseve.part[o];
			rim.texture = mseve.gr[o]; 
			}
		}
		*/
		/*
			if(pob[cm]==null){
				//var ob = Instantiate(part,core.transform.position,Quaternion.identity,core.transform);
				//pob[cm] = ob;
				pob[cm].GetComponent<MeshFilter>().mesh = mseve.part[o];
				rim.texture = mseve.gr[o]; 
				//cmtr s = part.GetComponent<cmtr>();
				//s.pgsc(o,ob);
				}else{
				pob[cm].GetComponent<MeshFilter>().mesh = mseve.part[o];
				rim.texture = mseve.gr[o]; 	
				}
			}
		}
		*/
	}

	void motip(){
		if(m>12){
		Vector2 vp = Input.mousePosition;
		vp.x = (1280*(vp.x/Screen.width));
		vp.y = (720*(vp.y/Screen.height));
		vi= 560/(m);
		if(vp.x<400){
		
		for(j=1;j<m;j++){
				if(re[j].anchoredPosition.y < vp.y+50 &&
				   re[j].anchoredPosition.y > vp.y-50){
					if(j>2 && re[j].anchoredPosition.y > re[j-1].anchoredPosition.y-40){
						re[j-1].anchoredPosition += new Vector2(0,4);
						}
					if(j <m-2&& re[j].anchoredPosition.y < re[j+1].anchoredPosition.y+40){
						re[j+1].anchoredPosition -= new Vector2(0,4);
					}
				}else{
					if(j>1 && j <m-1 &&re[j].anchoredPosition.y+20 > re[j-1].anchoredPosition.y){
						re[j].anchoredPosition -= new Vector2(0,4);
						}
					if(j>1 &&j <m-1 && re[j].anchoredPosition.y-20 < re[j+1].anchoredPosition.y){
						re[j].anchoredPosition += new Vector2(0,4);
						}
				}
		}

		}
	}				
}

	public void tjs(){
		ct = (int)smi.value;
		stm.value = ct;
	}


	public void bd(int n){
		Image i = re[cm].transform.GetComponent<Image>();
		i.color = new Color(1f,1f,1f,0.66f);
		//if(cm!=0){re[cm].sizeDelta = new Vector2(80,40);}


		cm = n;

		i = re[cm].transform.GetComponent<Image>();
		i.color = new Color(0.8f,0.8f,0.8f,0.66f);
		//if(cm!=0){re[cm].sizeDelta = new Vector2(80,40);}
		mp = Input.mousePosition;
	//	mp.x +=29;
	//	mp.y +=12;
		mp.x = (1280*(mp.x/Screen.width));
	//	if(mp.x　<40){mp.x=40;}
	//	if(mp.x >270){mp.x=270;}
		mp.y = (720*(mp.y/Screen.height));
	//	if(mp.y >470){mp.y=470;}
	//	if(mp.y <20){mp.y=20;}

		
		smi.value = rmi[bn,cm];
	}


	public void rv(){
		if(cm!=0){
		Vector2 f = Input.mousePosition;
		f.x = (1280*(f.x/Screen.width));
	//	if(mp.x　<40){mp.x=40;}
	//	if(mp.x >270){mp.x=270;}
		//f.x = re[21+cm].anchoredPosition.x;
		f.y = (720*(f.y/Screen.height));
		//if(f.y >480){f.y=480;}
		f = f-mp;
		f.x += 29;
		f.y += 20;
		if(f.y <0){f.y=0;}
		re[20+cm].anchoredPosition = f;
	}

/*		
		if(Vector2.Distance(mp,f)>40 && reit[0,cm]>0){
			reit[1,reit[0,cm]]-=reit[1,cm];
			j=reit[0,cm];
			for(;vi<20;){
			if(j==0){break;}
			else{
				reit[1,j]-=reit[1,cm];
				j=reit[0,j];	
			}

			reit[0,cm]=0;
			re[cm].transform.SetParent(rnt.transform);	
			}
		}
	}
*/
	}

	
	public void dp(){
	Vector2 f = Input.mousePosition;
	f.y = (720*(f.y/Screen.height));
		for(vi=0;vi<m;vi++){
			if(f.y > re[vi].anchoredPosition.y-20 &&
			   f.y < re[vi].anchoredPosition.y+20 && cm>vi){
				pobt[20+cm].text = (""+vi); 
				pob[cm].transform.parent = pob[vi].transform;
				break;
			}
		
		}
		re[20+cm].anchoredPosition = new Vector2(29,12);
	}

/*
	void sr(){
		for(vi=1;vi<m+1;vi++){
			if(reit[0,vi]>0){
					re[vi].transform.SetParent(re[reit[0,vi]].transform,true);
			}else{
			re[vi].transform.SetParent(rnt.transform,true);
			}
		}
		for(vi=1;vi<m+1;vi++){
			if(reit[1,vi]>0){
				int k=1;
				for(j=1;j<m+1;j++){
					if(reit[0,j]==vi){
						re[j].anchoredPosition = new Vector2(55f,20f+(k*-40f));
						k+=reit[1,j];
					}
				}

			}
		}

	}
*/
	//public void ed(int n){
	//	Image i = go[n].transform.GetComponent<Image>();
	//	i.color = new Color(1f,1f,1f,0.66f);
	//}





	public void rad(){
		switch(rd){
			case 0:
			rd =1;
			radt.text = ("15");
			break;
			case 1:
			rd =2;
			radt.text = ("90");
			break;
			case 2:
			rd =0;
			radt.text = ("1");
			break;

		}

	}
	public void xrt(int i){
		if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
				if(i==0){
					vi = (int)sx.value;
					vi = (vi/10)*10;
					sx.value = vi;
				}
				if(i==1){
					vi = (int)sy.value;
					vi = (vi/10)*10;
					sy.value = vi;
				}
				if(i==2){
					vi = (int)sz.value;
					vi = (vi/10)*10;
					sz.value = vi;
				}
		}
		//if(180<=f){f-=360;}
		//if(-180>=f){f+=360;}
		//pob[cm].transform.eulerAngles = new Vector3(pob[cm].transform.eulerAngles.x,f,pob[cm].transform.eulerAngles.z);
		//pob[cm].transform.Rotate(Vector3.up * f);
		pob[cm].transform.localEulerAngles  = new Vector3(sx.value,sy.value,sz.value);
	}
/*	public void yrt(float f){
		//v.x = f;
		//Quaternion q = Quaternion.LookRotation(new Vector3(f,0,0));
		pob[cm].transform.eulerAngles = new Vector3(sy.value,sx.value,sz.value);

		//Quaternion.AngleAxis(f,Vector3.right);
		//pob[cm].transform.eulerAngles =new Vector3(pob[cm].transform.eulerAngles.x,v.y,v.z);
		//if()
		//pob[cm].transform.Rotate(Vector3.forward * v.z);
	}
*/

/*
	public void zrt(float f){
		Vector3 v = pob[cm].transform.eulerAngles;
		v.z = f;
		pob[cm].transform.eulerAngles = v;
		//if()
		//pob[cm].transform.Rotate(Vector3.forward * v.z);
	}
*/


	/*
	public void liti(){
	mp.x = Input.mousePosition.x;
	mp.y = rmt[bn];
	}
	public void lime(){
		float x = Input.mousePosition.x-mp.x;
		x = x*0.25f;
		rmt[bn] = (int)mp.y+(int)x;
		if(rmt[bn]<1){rmt[bn]=1;}
		if(rmt[bn]>500){rmt[bn]=500;}
		if(ct>rmt[bn]){ct = rmt[bn];}

		te.text=(ct+"/"+rmt[bn]);
		stm.maxValue = rmt[bn];
		smi.maxValue = rmt[bn];

	}
	*/
	public void rmtver(float f)
	{
		//te.text = (ct+"/"+smi.value+"/"+f);
		ret.text = (smi.value+"/"+f);
		reseze = (int)f;
	}
	public void rmtvcan(){
		//te.text = (ct+"/"+smi.value+"/"+rmt[bn]);
		int i = rmt[bn];
		int j = (int)smi.value;
		ret.text = (j+"/"+i);
		srs.value = rmt[bn];

	}

	public void rmjs(){
		sx.value = rmj[bn,cm,ct].x;
		sy.value = rmj[bn,cm,ct].y;
		sz.value = rmj[bn,cm,ct].z;
	}

	public void limf(){
		//float x = Input.mousePosition.x-mp.x;
		//x = x*0.25f;
		//rmt[bn] = (int)mp.y+(int)x;
		//if(rmt[bn]<1){rmt[bn]=1;}
		//if(rmt[bn]>500){rmt[bn]=500;}
		//if(ct>rmt[bn]){ct = rmt[bn];}

//		if(rmt[bn]<reseze){
//			Vector3[,] vb = new Vector3[m,reseze];
//			vb = rmj[bn];
//			rmj[bn] = new Vector3[m,reseze];
		if(reseze >rmt[bn]){
			for(int i=0;i<m;i++){
				for(vi=rmt[bn]+1;vi<reseze+1;vi++){
//					rmj[bn][i,vi] = vb[i,vi];
//					}else{
					rmj[bn,i,vi] = new Vector3(0,0,0);
					}
				}
			}
//		}


		rmt[bn] = reseze;
		te.text=(ct+"/"+smi.value+"/"+rmt[bn]);
		ret.text=(ct+"/"+rmt[bn]);
		stm.maxValue = rmt[bn];
		stm.value = 0;
		smi.maxValue = rmt[bn];
		for(vi=0;vi<m;vi++){
			msl[vi].maxValue = rmt[bn];
			msl[vi].value = rmi[bn,vi];
		}

	}
	public void trcc(float f){
		ct = (int)f;
		if(cm!=0){
				if(ct<=rmi[bn,cm]){
				pob[cm].transform.localEulerAngles  = rmj[bn,cm,ct];
				sx.value = rmj[bn,cm,ct].x;
				sy.value = rmj[bn,cm,ct].y;
				sz.value = rmj[bn,cm,ct].z;
				}else{
				pob[cm].transform.localEulerAngles  = Vector3.zero;
				}
			}else{
			for(vi=0;vi<m;vi++){
				if(ct<=rmi[bn,vi]){
				pob[vi].transform.localEulerAngles  = rmj[bn,vi,ct];
				}else{
				pob[vi].transform.localEulerAngles  = Vector3.zero;
				}
			}
				if(ct<=rmi[bn,0]){
				sx.value = rmj[bn,0,ct].x;
				sy.value = rmj[bn,0,ct].y;
				sz.value = rmj[bn,0,ct].z;
				}
				if(ct <=rmi[bn,0]){
				core.transform.localPosition = rmj[bn,21,ct];
				}
			}

		te.text=(ct+"/"+smi.value+"/"+rmt[bn]);

	}

	public void midm(){
		if(p==0){
		int t = (int)stm.value-(int)smi.value;
		int si = (int)smi.value;
		Vector3 ve;

			if(t>0){
				//if(rmj[bn][cm,si]==null){ve = new Vector3(sx.value,sy.value,sz.value);
				//}else{
				//rmj[bn][cm,(int)stm.value] = new Vector3(sx.value,sy.value,sz.value);
				ve = new Vector3( (rmj[bn,cm,si].x-sx.value)/t,(rmj[bn,cm,si].y-sy.value)/t,(rmj[bn,cm,si].z-sz.value)/t);
				for(vi=0;vi<=t;vi++){
				rmj[bn,cm,si+vi] = rmj[bn,cm,si]+(ve*-vi);
				}
				smi.value = stm.value;
				rmi[bn,cm] = (int)stm.value;
				msl[cm].value = (int)stm.value;
				if(cm==0){
					ve = (rmj[bn,21,si]-core.transform.localPosition)/t;
					for(vi=0;vi<=t;vi++){
					rmj[bn,21,si+vi] = rmj[bn,21,si]+(ve*-vi);
					}
				}
			}						
			if(t<0){
				for(vi=t+1;vi<=0;vi++){
				rmj[bn,cm,si+vi] = Vector3.zero;
				}
				smi.value = stm.value; 
				rmi[bn,cm] = (int)stm.value;
				msl[cm].value = (int)stm.value;
				if(cm==0){
					for(vi=t+1;vi<=0;vi++){
					rmj[bn,21,si+vi] = Vector3.zero;
					}
				}

			}
			if(stm.value==0){
				rmj[bn,cm,0] = new Vector3(sx.value,sy.value,sz.value);
				msl[cm].value = 0;
				if(cm==0){
					rmj[bn,21,0] = core.transform.localPosition;
				}
			}
		te.text=(stm.value+"/"+smi.value+"/"+rmt[bn]);

		}
	}

	public void lpcp(){
		rmc[cm-1]++;
		if(rmc[cm-1]>cm-1){rmc[cm-1] = cm-1;}
		pob[cm].transform.SetParent(pob[rmc[cm-1]].transform,false);
		pobt[cm].text = (""+(1+rmc[cm-1]));
	}
	public void lpcm(){
		rmc[cm-1]--;
		if(rmc[cm-1]<=0){rmc[cm-1] = 0;}
		pob[cm].transform.SetParent(pob[rmc[cm-1]].transform,false);
		pobt[cm].text = (""+(1+rmc[cm-1]));
	}


	public void mcm(){
		mp = Input.mousePosition;
		v = pob[cm].transform.localPosition;
	}


/*
	public void mcx(int n){
		Vector2 f = Input.mousePosition;
		f = (f-mp)*0.01f;
		switch(n){
			case 0:
				{
				if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = v + new Vector3(f.x,0f,0f);
			}
				if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = new Vector3((Mathf.Round((v.x+f.x)*10f))*0.1f,v.y,v.z);
				}
			}
			ppt[0].text = ("x:"+pob[cm].transform.localPosition.x);
			break;

			case 1:{
				if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = v + new Vector3(0f,f.x,0f);
			}
				if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = new Vector3(v.x,(Mathf.Round((v.y+f.x)*10f))*0.1f,v.z);
				}
			}
			ppt[1].text = ("y:"+pob[cm].transform.localPosition.y);
			break;
			
			case 2:{
				if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = v + new Vector3(0f,0f,f.x);
			}
				if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
				pob[cm].transform.localPosition = new Vector3(v.x,v.y,(Mathf.Round((v.z+f.x)*10f))*0.1f);
				}
			}
			ppt[2].text = ("z:"+pob[cm].transform.localPosition.z);
			break;
		}
	}
*/	
	public void mcd(){
		Vector2 f = Input.mousePosition;
		f = (f-mp)*0.01f;
		
		//f = f.normalized;
		if(Input.GetMouseButton(0)){

		pob[cm].transform.position = new Vector3(v.x+f.x,v.y+f.y,v.z);
			if(pob[cm].transform.localPosition.x <-5){pob[cm].transform.localPosition = new Vector3(-5,pob[cm].transform.localPosition.y,pob[cm].transform.localPosition.z);}
			if(pob[cm].transform.localPosition.x > 5){pob[cm].transform.localPosition = new Vector3(5,pob[cm].transform.localPosition.y,pob[cm].transform.localPosition.z);}
			if(pob[cm].transform.localPosition.y <-1){pob[cm].transform.localPosition = new Vector3(pob[cm].transform.localPosition.x,-1,pob[cm].transform.localPosition.z);}
			if(pob[cm].transform.localPosition.y >10){pob[cm].transform.localPosition = new Vector3(pob[cm].transform.localPosition.x,10,pob[cm].transform.localPosition.z);}
		
		}
		if(!Input.GetMouseButton(0) &&Input.GetMouseButton(1)){
		pob[cm].transform.position = new Vector3(v.x,v.y,v.z+f.y);
			if(pob[cm].transform.localPosition.z <-5){pob[cm].transform.localPosition = new Vector3(pob[cm].transform.localPosition.x,pob[cm].transform.localPosition.y,-5);}
			if(pob[cm].transform.localPosition.z > 5){pob[cm].transform.localPosition = new Vector3(pob[cm].transform.localPosition.x,pob[cm].transform.localPosition.y,5);}
		}

	}
	public void mcc(){
		mp = Input.mousePosition;
		//vr.x = cag.transform.position.y;
		vr.x = cag.transform.eulerAngles.x;
		vr.y = cag.transform.eulerAngles.y;
		v = pob[cm].transform.localPosition;
	}

	public void mmcc(){
		mp = Input.mousePosition;
		v = pob[cm].transform.localScale;
	}

	public void mlc(){
		Vector2 f = Input.mousePosition;
		f.y = (f.y-mp.y)*0.0025f;
		pob[cm].transform.localScale = v + new Vector3(f.y,f.y,f.y);
		if(cm==0){
		if(pob[cm].transform.localScale.x<0.01f){pob[cm].transform.localScale=new Vector3(0.01f,0.01f,0.01f);}
		if(pob[cm].transform.localScale.x>0.2f){pob[cm].transform.localScale=new Vector3(0.2f,0.2f,0.2f);}
		}else{
		if(pob[cm].transform.localScale.x<0.05f){pob[cm].transform.localScale=new Vector3(0.05f,0.05f,0.05f);}
		if(pob[cm].transform.localScale.x>2f){pob[cm].transform.localScale=new Vector3(2f,2f,2f);}
		}
	}
	public void mca(){
		Vector2 f = Input.mousePosition;
		f.x = (f.x-mp.x)*0.0025f;
		f.y = (f.y-mp.y)*0.0025f;
		if(Input.GetMouseButton(2)){
		cag.transform.eulerAngles = new Vector3(vr.x+(f.y*100),vr.y+(-f.x*100),cag.transform.eulerAngles.z);

		//cag.transform.position = new Vector3(cag.transform.position.x,vr.x+f.y,cag.transform.position.z);
		//if(cag.transform.eulerAngles.x>270f){cag.transform.eulerAngles = new Vector3(0f,v.y+f.x,v.z);}
		//if(cag.transform.eulerAngles.x>90f ){cag.transform.eulerAngles = new Vector3(90f,v.y+f.x,v.z);}
		}
		if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
		pob[cm].transform.localPosition = v + new Vector3(f.x,f.y,0f);
		pob[cm].transform.position = new Vector3((Mathf.Round(pob[cm].transform.position.x*fs))/fs,(Mathf.Round(pob[cm].transform.position.y*fs))/fs,pob[cm].transform.position.z);
		}
		if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
		pob[cm].transform.localPosition = v + new Vector3(0f,0f,f.x);
		pob[cm].transform.position = new Vector3(pob[cm].transform.position.x,pob[cm].transform.position.y,(Mathf.Round(pob[cm].transform.position.z*fs))/fs);
		}
		ppt[0].text =("x:"+(Mathf.Round((pob[cm].transform.position.x)*1000))*0.001f);
		ppt[1].text =("y:"+(Mathf.Round((pob[cm].transform.position.y)*1000))*0.001f);
		ppt[2].text =("z:"+(Mathf.Round((pob[cm].transform.position.z)*1000))*0.001f);
	}

	public void mcu(){
		if(!Input.GetMouseButton(1)){
		ca.transform.localPosition += new Vector3(0f,0f,Input.mouseScrollDelta.y);
		if(ca.transform.localPosition.z>-1){ca.transform.localPosition = new Vector3(ca.transform.localPosition.x,ca.transform.localPosition.y,-1f);}
		if(ca.transform.localPosition.z<-30){ca.transform.localPosition = new Vector3(ca.transform.localPosition.x,ca.transform.localPosition.y,-30f);}
		}
	/*
		if(Input.GetMouseButton(1)){
			cag.transform.localPosition += new Vector3(0f,Input.mouseScrollDelta.y*0.5f,0f);
			if(cag.transform.localPosition.y>9){cag.transform.localPosition = new Vector3(0f,9f,cag.transform.localPosition.z);}
			if(cag.transform.localPosition.y<-3){cag.transform.localPosition = new Vector3(0f,-3f,cag.transform.localPosition.z);}
		}
	}
	*/
	}
	public void rdrt(){
		if(bord){
		rads.text = ("360");
		sx.minValue = -360;
		sx.maxValue = 360;
		sy.minValue = -360;
		sy.maxValue = 360;
		sz.minValue = -360;
		sz.maxValue = 360;
		bord=false;
		}else{
		rads.text = ("180");
		sx.minValue = -180;
		sx.maxValue = 180;
		sy.minValue = -180;
		sy.maxValue = 180;
		sz.minValue = -180;
		sz.maxValue = 180;
		bord=true;
		}
	}

	public void soc(int n){
		so = n;
		chs.localPosition = new Vector3(0f,0f,0f);
	}
	public void zrp(){
		pob[cm].transform.position = Vector3.zero;
		plan.transform.position = Vector3.zero;
		cag.transform.position = Vector3.zero;
		cag.transform.eulerAngles = new Vector3(30,0,0);
		ca.transform.position = new Vector3(0,3,-5);
	}
	public void fsp(){
		ff++;
		if(ff>2){ff=0;}
		switch(ff){
		case 0:	fs=1f;break;
		case 1:	fs=10f;break;
		case 2:	fs=100f;break;
		}
		ppt[3].text = (""+1f/fs);
	}


	public void savd(){
		if(sv){
		if(date.rb[so]==null){
		Invoke("dasv",0.1f);
		}else{
		canr.SetActive(true);
		}
		}
	}

	public void dasv(){
		btn(0);
		trcc(0);
		foreach ( Transform n in liev[so].transform )
		{
		GameObject.Destroy(n.gameObject);
		}
		//liev[so].GetComponent<MeshFilter>().mesh = Instantiate(core.GetComponent<MeshFilter>().mesh);
		//core.GetComponent<MeshFilter>().mesh = null;
		//liev[so].GetComponent<MeshRenderer>().material = Instantiate(core.GetComponent<MeshRenderer>().material);
		//core.GetComponent<MeshRenderer>().material =null;
		//liev[so].transform.position = core.transform.position;
		//liev[so].transform.rotation = core.transform.rotation;
		//liev[so].transform.localScale = core.transform.localScale;

		//new Vector3((core.transform.localScale.x / core.transform.lossyScale.x)*pob[0].transform.localScale.x,
		//	(core.transform.localScale.y / core.transform.lossyScale.y)*pob[0].transform.localScale.x,(core.transform.localScale.z / core.transform.lossyScale.z)*pob[0].transform.localScale.x);

		for(int i=0;i<300;i++){
			if(rmt[0]>=i){rmj[0,0,i].y =  rmj[0,0,i].y+180;}
			if(rmt[1]>=i){rmj[1,0,i].y =  rmj[1,0,i].y+180;}
			if(rmt[2]>=i){rmj[2,0,i].y =  rmj[2,0,i].y+180;}
			if(rmt[3]>=i){rmj[3,0,i].y =  rmj[3,0,i].y+180;}
			if(rmt[4]>=i){rmj[4,0,i].y =  rmj[4,0,i].y+180;}
			if(rmt[5]>=i){rmj[5,0,i].y =  rmj[5,0,i].y+180;}
			if(rmt[6]>=i){rmj[6,0,i].y =  rmj[6,0,i].y+180;}
			if(rmt[7]>=i){rmj[7,0,i].y =  rmj[7,0,i].y+180;}
			if(rmt[8]>=i){rmj[8,0,i].y =  rmj[8,0,i].y+180;}
		}
		rovoko rk = liev[so].GetComponent<rovoko>();
		rk.strt(pob,rmt,m);
		rk.inc(rmj,rmt);
		pob[0].transform.parent = liev[so].transform;
		for(vi=0;vi<m;vi++){
		pob[vi].layer = 10;
		pob[vi] = null;
		}
		core = Instantiate(cr,Vector3.zero,Quaternion.identity,plan.transform);
		sav();
		Start();
		cm=0;
		ir[0].color = new Color(1f,1f,0.8f,0.8f);
		ir[21].sprite = null;
		smi.maxValue = 0;
		stm.maxValue = 0;
		msl[0].value = 0;
		msl[0].maxValue = 1;
		for(vi=1;vi<21;vi++){
			re[vi].gameObject.SetActive(false);
			msl[vi].value = 0;
			msl[vi].maxValue = 1;
			ir[vi].color = new Color(1f,1f,1f,0.25f);
			ir[21+vi].sprite = sidr;
		}
		date.rb[so] = liev[so];
		date.rb[so].GetComponent<rovoko>().ret();
		sv=false;
	}
	public void loadd(){
		if(date.rb[so]!=null){
		if(m==1 && rmt[0]==1 && rmt[1]==1 && rmt[2]==1 && rmt[3]==1 && rmt[4]==1 && rmt[5]==1 && rmt[6]==1 && rmt[7]==1 && rmt[8]==1){
		loadmotion();
		}else{
		cand.SetActive(true);
		}
	}
	}
	public void deload(){
		btn(0);
		trcc(0);
		for(;0<m;m--)
		{
		Destroy(pob[m]);
		}
		m=1;
		Start();
		cm=0;
		ir[0].color = new Color(1f,1f,0.8f,0.8f);
		ir[21].sprite = null;
		smi.maxValue = 0;
		stm.maxValue = 0;
		msl[0].value = 0;
		msl[0].maxValue = 1;
		for(vi=1;vi<21;vi++){
			re[vi].gameObject.SetActive(false);
			msl[vi].value = 0;
			msl[vi].maxValue = 1;
			ir[vi].color = new Color(1f,1f,1f,0.25f);
			ir[21+vi].sprite = sidr;
		}
		date.rb[so] = liev[so];
		date.rb[so].GetComponent<rovoko>().ret();
		sv=false;
		loadmotion();
	}
	public void loadmotion(){
			rovoko rk = liev[so].GetComponent<rovoko>();
			int li= rk.oub();
			int h;
			int u=0;
			GameObject[] g = rk.ougc();
			for(h=0;h<li-1;h++){
			sbpt();
			}
			for(h=0;h<li;h++){
				if(g[h].GetComponent<MeshFilter>().mesh.vertices.Length>0){
				pob[h].GetComponent<MeshFilter>().mesh = g[h].GetComponent<MeshFilter>().mesh;
				pob[h].GetComponent<MeshRenderer>().material = g[h].GetComponent<MeshRenderer>().material;
				ir[21+h].sprite = date.rbsp[so];
				}
			for(u=0;u<h;u++){
				if(g[h].transform.parent==g[u].transform){
				pob[h].transform.parent = pob[u].transform;
				pob[h].transform.localPosition = g[h].transform.localPosition;
				pob[h].transform.localScale = g[h].transform.localScale;
				pobt[h].text = (""+(u+1));
				rmc[h-1] = u;
				}
			}
			pob[h].layer = 9;
			}
			Vector3[,,] v = rk.oucld();
			Array.Copy(v,0,rmj,0,59400);
			rk.oulm().CopyTo(rmt,0);
			pob[0].transform.parent = null;
			pob[0].transform.localScale = g[0].transform.localScale;
			pob[0].transform.parent = plan.transform;
			//new Vector3((g[0].transform.localScale.x/g[0].transform.lossyScale.x)*g[0].transform.localScale.x,
			//	(g[0].transform.localScale.y/g[0].transform.lossyScale.y)*g[0].transform.localScale.y,(g[0].transform.localScale.z/g[0].transform.lossyScale.z)*g[0].transform.localScale.z);
			coht.transform.parent = null;
			coht.transform.position = date.rb[so].GetComponent<CapsuleCollider>().center;
			coht.transform.localScale = new Vector3(date.rb[so].GetComponent<CapsuleCollider>().radius*2,date.rb[so].GetComponent<CapsuleCollider>().height/2,date.rb[so].GetComponent<CapsuleCollider>().radius*2);

			coht.transform.parent = plan.transform;
			for(u=0;u<li;u++){
			rmi[0,u] = rmt[0];
			rmi[1,u] = rmt[1];
			rmi[2,u] = rmt[2];
			rmi[3,u] = rmt[3];
			rmi[4,u] = rmt[4];
			rmi[5,u] = rmt[5];
			rmi[6,u] = rmt[6];
			rmi[7,u] = rmt[7];
			rmi[8,u] = rmt[8];

			}
			for(int i=0;i<300;i++){
			rmj[0,0,i].y =  rmj[0,0,i].y-180;
			rmj[1,0,i].y =  rmj[1,0,i].y-180;
			rmj[2,0,i].y =  rmj[2,0,i].y-180;
			rmj[3,0,i].y =  rmj[3,0,i].y-180;
			rmj[4,0,i].y =  rmj[4,0,i].y-180;
			rmj[5,0,i].y =  rmj[5,0,i].y-180;
			rmj[6,0,i].y =  rmj[6,0,i].y-180;
			rmj[7,0,i].y =  rmj[7,0,i].y-180;
			rmj[8,0,i].y =  rmj[8,0,i].y-180;
			}
		ra.SetParent(rlt.transform);
		btn(cm);
		sv = true;
	}

	public void dert(){
		//liev[so].GetComponent<MeshFilter>().mesh = null;
		//liev[so].GetComponent<MeshRenderer>().material = null;
		core.GetComponent<MeshFilter>().mesh = null;
		foreach ( Transform n in liev[so].transform )
		{
		GameObject.Destroy(n.gameObject);
		}
		liev[so].GetComponent<rovoko>().ret();
		date.rb[so] = null;
		date.rbsp[so] = null;
		rbs[so].sprite = null;
		date.rbtx[so] =null;
	}	

	void sav(){
		Sprite sp = Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		date.rbsp[so] = sp;
		rbs[so].sprite = sp;
		date.rbtx[so] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.rbtx[so]);

	}
}
