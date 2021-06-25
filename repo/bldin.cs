using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bldin : MonoBehaviour {
public GameObject obj;
public GameObject dto;
public GameObject pnl;
public Material dfmt;
public GameObject cp;
public GameObject cmr;
public GameObject bas;
public Image[] bs = new Image[20];
public Image[] pts = new Image[30];
public Image[] risp = new Image[20];
public Image[] itsp = new Image[20];

public Toggle[] tgl = new Toggle[3];
//public bool[] bol = new bool[3];
public Image im;
public Image sp;
public Slider[] sl = new Slider[10];
public Text[] tx = new Text[10];
public RectTransform ktd;
public RectTransform ccc;
public MeshFilter ms;
public MeshRenderer mr;
public GameObject[] gm = new GameObject[7];

public GameObject[] bild = new GameObject[20];
public GameObject point;
public RectTransform[] rct = new RectTransform[7];
Vector2 vct;
Vector2 vt;
Vector3 vp;

public GameObject gp;
public int[] pr = new int[17];
Vector2 mp;
Vector3 vc;
Vector3 vr;
int hz = 0;
int rbi =0;
//bool et = false;
GameObject[] gms = new GameObject[16];
GameObject[] gmc = new GameObject[100];
int[] gmi = new int[10];
Material[] mtc = new Material[16];
Mesh[] msh = new Mesh[16];
public Image[] bim = new Image[16];
public LayerMask mk;
public GameObject[] gmm = new GameObject[3];
public Camera cm;
Vector3 mpt;
public Shader[] shd = new Shader[2];

//public SpriteRenderer ssss;
	// Use this for initialization
	void Start () {
		pr[16]=0;

	}
	
	// Update is called once per frame
	void Update () {
		if(pr[2]==7){
			dto.transform.Rotate(pr[4]*0.1f,pr[5]*0.1f,pr[6]*0.1f);
		}
	}

	public void pr1(bool b){
		if(b){
			pr[0] = 1;
		}else{
			pr[0]= 0;
		}
	}
	public void pr2(bool b){
		if(b){
			pr[1] = 1;
		}else{
			pr[1] = 0;
		}
	}

	public void pr4(float f){
		pr[4] = (int)f;
		switch(pr[2]){
			case 1:
			tx[0].text = (""+(int)sl[0].value);
			break;
			case 2:
			tx[1].text = (""+(int)sl[1].value);
			break;
			case 3:
		//	tx[2].text = (""+(int)sl[2].value);
			break;
			case 4:
			tx[3].text = (""+(int)sl[3].value);
			break;
			case 5:
			tx[2].text = (""+(int)sl[2].value);
			break;
			case 6:
			tx[8].text = (""+(int)sl[8].value);
			break;
			case 7:
			tx[7].text = (""+(int)sl[7].value);
			dto.transform.eulerAngles = Vector3.zero;
			break;

		}
	}
	public void pr5(float f){
		pr[5] = (int)f;
		switch(pr[2]){
			case 4:
			tx[4].text = (""+(int)sl[4].value);
			break;
			case 5:
			tx[6].text = (""+(int)sl[6].value);
			break;
			case 6:
			tx[9].text = (""+(int)sl[9].value);
			break;
			case 7:
			tx[8].text = (""+(int)sl[8].value);
			dto.transform.eulerAngles = Vector3.zero;
			break;
		}
	}
	public void pr6(float f){
		pr[6] = (int)f;
		switch(pr[2]){
			case 5:
			tx[7].text = (""+(int)sl[7].value);
			break;
			case 7:
			tx[9].text = (""+(int)sl[9].value);
			dto.transform.eulerAngles = Vector3.zero;
			break;
		}
	}
	public void pr6b(int n){
		pr[6] = n;
	}


	public void rbg(int n){
		if(date.rb[n]!=null){
			gp = date.rb[n];
			im.sprite = date.rbsp[n];
		}
	}


	public void psl(int n){
		tx[n].text = (""+sl[n].value);
	}	
	public void chos(int n){
	
		if(pr[2]!=n){
	//	gm[pr[2]].SetActive(false);
		pr[2] = n;
	//	gm[n].SetActive(true);
		ktd.transform.localPosition = Vector3.zero;
		dto.transform.eulerAngles = Vector3.zero;
	/*
		switch(n){
			case 0:
			break;
			case 1:
			pr[4] = (int)sl[0].value;

			break;
			case 2:
			pr[4] = (int)sl[1].value;
			break;
			case 3:
			//pr[4] = (int)sl[2].value;
			break;
			case 4:
			pr[4] = (int)sl[3].value;
			pr[5] = (int)sl[4].value;
			break;
			case 5:
			pr[4] = (int)sl[2].value;
	//		pr[5] = (int)sl[6].value;
	//		pr[6] = (int)sl[7].value;
			break;
			case 6:

			break;
			case 7:
			pr[4] = (int)sl[7].value;
			pr[5] = (int)sl[8].value;
			pr[6] = (int)sl[9].value;
			break;
		
		}
*/
		}
		
	}
	public void ptst(){
	bas.transform.position = Vector3.zero;
	for(int i=0;i<50;i++){
		if(date.se[i]!=null){
			pts[i].sprite = date.se[i];
		}else{
			pts[i].sprite = null;
		}
	}
	for(int i=0;i<20;i++){
		if(date.rb[i]!=null){
			risp[i].sprite = date.rbsp[i];
		}else{
			risp[i].sprite = null;
		}
	}
	for(int i=0;i<20;i++){
		if(date.it[i]!=null){
			itsp[i].sprite = date.itsp[i];
		}else{
			itsp[i].sprite = null;
		}
	}
	for(int i=0;i<20;i++){
		if(date.bl[i]!=null){
			bs[i].sprite = date.blsp[i];
		}else{
			bs[i].sprite = null;
		}
	}
	}	
/*
	public void msin(int n){
		if(date.ms[n] != null){
		ms.mesh = Instantiate(date.ms[n]);
		et=true;
			if(date.mt[n]!=null){
			mr.material = Instantiate(date.mt[n]);
			mr.material.mainTexture = Instantiate(date.tx[n]);
			}else{
			mr.material = dfmt;
			mr.material.mainTexture = null;
			}
		im.sprite = date.se[n];
		pnl.SetActive(false);
		}
	}
*/
	public void msin(int n){
		if(date.ms[n]!=null && pr[16]<16){

			gms[pr[16]] = Instantiate(gmm[0],gmm[1].transform);
			gms[pr[16]].transform.localScale = (gms[pr[16]].transform.localScale.x/gms[pr[16]].transform.lossyScale.x) * Vector3.one;

			gms[pr[16]].GetComponent<MeshFilter>().mesh = Instantiate(date.ms[n]);
			gms[pr[16]].GetComponent<MeshCollider>().sharedMesh = Instantiate(date.ms[n]);
			if(date.mt[n]!=null){
			gms[pr[16]].GetComponent<MeshRenderer>().material = Instantiate(date.mt[n]);
			gms[pr[16]].GetComponent<MeshRenderer>().material.mainTexture = Instantiate(date.tx[n]);
			}
			bim[pr[16]].sprite = date.se[n];
			if(gmm[2]!=null){
				gmm[2].GetComponent<MeshRenderer>().material.shader = shd[0];
			}
			gms[pr[16]].GetComponent<MeshRenderer>().material.shader = shd[1];
			gmm[2] = gms[pr[16]];
			pr[16]++;
		}
	}
	public void mesc(int n){
		if(gms[n]!=null){
				
			if(gmm[2]!=null){
				gmm[2].GetComponent<MeshRenderer>().material.shader = shd[0];		
			}
			gms[n].GetComponent<MeshRenderer>().material.shader = shd[1];
			Transform tr = gmm[2].transform;
			gmm[2] = null;
			sl[10].value = tr.eulerAngles.x;
			sl[11].value = tr.eulerAngles.y;
			sl[12].value = tr.eulerAngles.z;
			sl[13].value = tr.position.y;
			sl[14].value = tr.lossyScale.x;	
			gmm[2] = gms[n];
/*
			Destroy(gms[n]);
			for(int i=n;i<15;i++){
				gms[i] = gms[i+1];
				bim[i].sprite = bim[i+1].sprite;
			}
			pr[16]--;
			gms[pr[16]]=null;
			bim[pr[16]].sprite =null;
*/
		}

	}
	/*
	public void pr[16]h(int n){
		if(gms[n]!=null && msn<100){
			gmc[msn] = Instantiate(gms[n],gmm[1].transform);
			gmi[msn]=n;
			msn++;
		}
	}
	*/
	/*
	public void msav(){
		int i;
		int k;
		int g;
		int sz=0;
		int ig=0;
		int ir=0;
		int ii=0;
		Material[] mm = new Material[pr[16]];
		for(i=0;i<pr[16];i++){
			if(mtx[i]!=null){
				switch(mtx[i].height){
				case 128:sz+=1;ii++;break;
				case 256:sz+=4;ir++;break;
				case 512:sz+=16;ig++;break;
				}
			} 
		}
		int xx=0;
		int yy=0;
		int ck=0;

		if(sz==1){xx=1;yy=1;}
		if(sz==2){xx=2;yy=1;}
		if(sz>=3&&sz<=4){xx=2;yy=2;}
		if(sz>=5&&sz<=8){xx=4;yy=2;}
		if(sz>=9&&sz<=16){xx=4;yy=4;}
		if(sz>=16&&sz<=32){xx=8;yy=4;}
		if(sz>=33&&sz<=64){xx=8;yy=8;}
		if(sz>=65&&sz<=128){xx=16;yy=8;}
		if(sz>=129&&sz<=256){xx=16;yy=16;}
		Color[] cr = new Color[(xx*128)+(yy*128)];
		int[,] pc = new int[xx,yy];
		int[] xp = new int[pr[16]];
		int[] yp = new int[pr[16]];
		int ys = xx*128;
	for(g=0;g<ig;g++){
		for(i=0;i<yy;i++){
			for(k=0;k<xx;k++){
				if(pc[k,i]==0){
					ck++;
					xp[g] = k*128;
					yp[g] = (yy*128)-(i*512);
					for(int n=0;n<4;n++){
					for(int m=0;m<4;m++){
						pc[i+n,k+m] = 4;
					}
					}
					goto gg;
				}
			}
		}
		gg:;
	}
	for(g=0;g<ir;g++){
		for(i=0;i<yy;i++){
			for(k=0;k<xx;k++){
				if(pc[k,i]==0){
					ck++;
					xp[g+ck] = k*128;
					yp[g+ck] = (yy*128)-(i*256);
					for(int n=0;n<2;n++){
					for(int m=0;m<2;m++){
						pc[i+n,k+m] = 2;
					}
					}
					goto gr;
				}
			}
		}
		gr:;
	}
	for(g=0;g<ii;g++){
		for(i=0;i<yy;i++){
			for(k=0;k<xx;k++){
				if(pc[k,i]==0){
					ck++;
					xp[g+ck] = k*128;
					yp[g+ck] = (i*128)-128;
				goto gi;	
				}				
			}
		}
		gi:;
	}

	ck=0;
	for(i=0;i<pr[16];i++){
		if(mtx[i].height==512){
		Color[] c = mtx[i].GetPixels();
		int yh = mtx[i].height;
		for(int n=0;n<yh;n++){
			for(int m=0;m<yh;m++){
				cr[(yp[ck]*ys)+(xp[ck]) + (n*yh)+m] = c[(n*yh)+m];
			}
		}
		ck++;
		}
	}
	for(i=0;i<pr[16];i++){
		if(mtx[i].height==256){
		Color[] c = mtx[i].GetPixels();
		int yh = mtx[i].height;
		for(int n=0;n<yh;n++){
			for(int m=0;m<yh;m++){
				cr[(yp[ck]*ys)+(xp[ck]) + (n*yh)+m] = c[(n*yh)+m];
			}
		}
		ck++;
		}
	}
	for(i=0;i<pr[16];i++){
		if(mtx[i].height==128){
		Color[] c = mtx[i].GetPixels();
		int yh = mtx[i].height;
		for(int n=0;n<yh;n++){
			for(int m=0;m<yh;m++){
				cr[(yp[ck]*ys)+(xp[ck]) + (n*yh)+m] = c[(n*yh)+m];
			}
		}
		ck++;
		}
	}

	Texture2D tt = new Texture2D(xx*128,yy*128);
	tt.SetPixels(cr);
	Sprite ss = Sprite.Create(tt,new Rect(0,0,xx*128,yy*128),new Vector2(0.5f,0.5f));
	ssss.sprite = ss;
	}


*/




	public void rcc(int n){
		if(date.rb[n]!=null){
			gp = date.rb[n];
			sp.sprite = date.rbsp[n];
			rbi = n;
		}
	}

	public void icc(int n){
		if(date.it[n]!=null){
			gp = date.it[n];
			sp.sprite = date.itsp[n];
		}
	}
	public void hzc(int n){
		hz = n;
		ccc.localPosition = Vector2.zero;
	}


	public void hzn(){
		//if(et==true && ((pr[2] == 4 && gp != null) || pr[2]!=4)){
		//Invoke("save",0.1f);
		//et=false;
		//}
		if(pr[16]>0){
		Invoke("save",0.1f);
		}
	}

	void save(){
		//bild[hz].GetComponent<MeshFilter>().mesh = Instantiate(ms.mesh);
		//if(pr[2]!=6){bild[hz].GetComponent<MeshCollider>().sharedMesh = Instantiate(ms.mesh);}
		//bild[hz].GetComponent<MeshRenderer>().material = Instantiate(mr.material);
		//if(date.mt[hz]!=null){bild[hz].GetComponent<MeshRenderer>().material.mainTexture = Instantiate(date.tx[hz]);}
		if(bild[hz].transform.childCount>0){
		foreach ( Transform n in bild[hz].transform )
		{
		Destroy(n.gameObject);
		}
		}
				
		date.bl[hz] = bild[hz];
		date.bl[hz].tag = ("bl");

		switch(pr[2]){
			case 0:
			date.bl[hz].tag = ("tree");
			break;
			case 1:
			date.bl[hz].tag = ("wk");
			break;
			case 2:
			date.bl[hz].tag = ("camp");;
			break;
			case 4:

			break;
			case 5:
			if(pr[6]==0){date.bl[hz].tag = ("itms");}
			if(pr[6]==1){date.bl[hz].tag = ("enag");}
			break;
			case 7:

			break;
			case 8:
			date.bl[hz].tag = ("tree");
			pr[0] = 0;
			break;

		}
		bild[hz].GetComponent<blds>().set(pr);
		for(int i=0;i<pr[16];i++){
			if(pr[2]==6){gms[i].GetComponent<Collider>().enabled = false;}
			gms[i].GetComponent<MeshRenderer>().material.shader = shd[0];
			gms[i].layer = 12;
			gms[i].tag = date.bl[hz].tag;
			gms[i].transform.parent = bild[hz].transform;
			gms[i] = null;
			bim[i].sprite  = null;
		}

		date.blsp[hz] =  Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		bs[hz].sprite = date.blsp[hz];
		date.bltx[hz] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.bltx[hz]);
		sp.sprite = null;
		//ms.mesh = null;
		//mr.material = null;
		dto.transform.localPosition = Vector3.zero;
		im.sprite = null;
		itsp[20].sprite = null;
	//	gp=null;
	//	tgl[0].isOn = true;
	//	tgl[1].isOn = true;
		pr[0] = 1;
		pr[1] = 1;

		dto.transform.eulerAngles = Vector3.zero;
		pr[16]=0;
	}

	public void read(){
		if(date.bl[hz]!=null){
		ms.mesh = Instantiate(bild[hz].GetComponent<MeshFilter>().mesh);
		mr.material = Instantiate(bild[hz].GetComponent<MeshRenderer>().material);
		im.sprite = date.blsp[hz];
		//et=true;
		}		
	}


	public void trs(){
		date.bl[hz] = null;
		date.blsp[hz] = null;
		bs[hz].sprite = null;
	}

	public void mpn(){
		
		if(Input.GetMouseButton(2)){
		mp = Input.mousePosition;
		vc = cp.transform.eulerAngles;
		//vr = cmr.transform.localEulerAngles;
		vr = cp.transform.position;
		}

		if(Input.GetMouseButton(1)){
			Vector2 mp = Input.mousePosition;
			Vector3[] v = new Vector3[4];
			rct[6].GetWorldCorners(v);
			mp.x = (mp.x-v[0].x)/rct[6].transform.lossyScale.x;
			mp.y = (mp.y-v[0].y)/rct[6].transform.lossyScale.x;
			Ray ray = cm.ScreenPointToRay(mp);
			RaycastHit rh;
			if(Physics.Raycast(ray,out rh,Mathf.Infinity,mk)){
				if(gmm[1]!=rh.collider.gameObject){
					if(gmm[2]!=null){
					gmm[2].GetComponent<MeshRenderer>().material.shader = shd[0];
					}
				
				Transform tr = rh.collider.gameObject.transform;
				gmm[2] = null;
				sl[10].value = tr.eulerAngles.x;
				sl[11].value = tr.eulerAngles.y;
				sl[12].value = tr.eulerAngles.z;
				sl[13].value = tr.position.y;
				sl[14].value = tr.lossyScale.x;	

				gmm[2] = rh.collider.gameObject;
				mpt = Input.mousePosition;
				vp = gmm[2].transform.position;	
				gmm[2].GetComponent<MeshRenderer>().material.shader = shd[1];
				}
			}
		}

		if(gmm[2]!=null && Input.GetMouseButton(0)){
			mpt = Input.mousePosition;
			vp = gmm[2].transform.position;
			Vector3[] v = new Vector3[4];
			rct[6].GetWorldCorners(v);
			mpt.x = (mpt.x-v[0].x)/rct[6].transform.lossyScale.x;
			mpt.y = (mpt.y-v[0].y)/rct[6].transform.lossyScale.x;
			Ray ray = cm.ScreenPointToRay(mpt);
			RaycastHit[] rh = Physics.RaycastAll(ray,Mathf.Infinity,mk);
			for(int i=0;i<rh.Length;i++){
			if(rh[i].collider.gameObject == gmm[1]){
				gmm[2].transform.position = new Vector3(rh[i].point.x,sl[13].value,rh[i].point.z);
			}
			}
		}
	}
	public void trsp(){
		if(gmm[2]!=null){
			gmm[2].transform.eulerAngles = new Vector3(sl[10].value,sl[11].value,sl[12].value);
			gmm[2].transform.position = new Vector3(gmm[2].transform.position.x,sl[13].value,gmm[2].transform.position.z);
			gmm[2].transform.localScale = Vector3.one * ((gmm[2].transform.localScale.x/gmm[2].transform.lossyScale.x) * sl[14].value);
		}
	}
	public void obpn(){
		Vector2 v;
		Vector3 vs;
		
		if(Input.GetMouseButton(2)){
		v = (Vector2)Input.mousePosition - mp;

		//vs = vc;
		//vs.y = vc.z+(v.x*0.25f);
		//cp.transform.eulerAngles = vs;

		vs = Vector3.zero;
		//vs.y = vr.y+(v.y*0.02f);
		//cp.transform.position = vs;
		cp.transform.eulerAngles =  vc + new Vector3(v.y*0.25f,-v.x*0.25f,0);
		//if(cp.transform.position.y<-1){cp.transform.position = new Vector3(0,-1,0);}
		///if(cp.transform.position.y>5){cp.transform.position = new Vector3(0,5,0);}
		

		//cmr.transform.localEulerAngles = vs;

		}
		if(gmm[2]!=null){
			Vector3 mp = (Input.mousePosition - mpt)*0.05f;
			if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
			//gmm[2].transform.position = new Vector3(vp.x + mp.x,vp.y,vp.z+mp.y);
				Vector3 mpt = Input.mousePosition;
				Vector3[] vp = new Vector3[4];
				rct[6].GetWorldCorners(vp);
				mpt.x = (mpt.x-vp[0].x)/rct[6].transform.lossyScale.x;;
				mpt.y = (mpt.y-vp[0].y)/rct[6].transform.lossyScale.x;;
				Ray ray = cm.ScreenPointToRay(mpt);
				RaycastHit[] rh = Physics.RaycastAll(ray,Mathf.Infinity,mk);
				for(int i=0;i<rh.Length;i++){
				if(rh[i].collider.gameObject == gmm[1]){
				gmm[2].transform.position =  new Vector3(rh[i].point.x,sl[13].value,rh[i].point.z);
				}
				}
			}
			if(Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
			gmm[2].transform.position = new Vector3(vp.x,vp.y+mp.y,vp.z);
			}



		}
		/*
		if(!Input.GetMouseButton(1) && Input.GetMouseButton(0)){
		v = (Vector2)Input.mousePosition-  mp;
		vs = vc;
		vs.x = vc.x+(v.x*0.1f);
		if(vs.x>5){vs.x =5;}
		if(vs.x<-5){vs.x =-5;}
		vs.z = vc.y+(v.y*0.1f);
		if(vs.z>5){vs.z =5;}
		if(vs.z<-5){vs.z =-5;}
		dto.transform.position = vs;
		}
		*/
		/*
		if(!Input.GetMouseButton(1) && Input.GetMouseButton(0)){
		v = (Vector2)Input.mousePosition - mp;
		vs = vc;
		vs.y = vc.y+(v.y*0.01f);
		if(vs.y>2){vs.y =2;}
		if(vs.y<-1){vs.y =-1;}
		dto.transform.position = vs;
		}
		*/
	}
	public void scll(){
//	cmr.transform.localPosition = new Vector3(0,cmr.transform.localPosition.y+(Input.mouseScrollDelta.y*-0.005f),cmr.transform.localPosition.z+(Input.mouseScrollDelta.y*0.005f));
	if(!Input.GetMouseButton(1)){
	cmr.transform.localPosition = new Vector3(0,cmr.transform.localPosition.y,cmr.transform.localPosition.z+(Input.mouseScrollDelta.y*0.004f));

		if(cmr.transform.localPosition.z > -0.05f){cmr.transform.localPosition = new Vector3(0,cmr.transform.localPosition.y,-0.05f);}
		if(cmr.transform.localPosition.z < -0.2f){cmr.transform.localPosition = new Vector3(0,cmr.transform.localPosition.y,-0.2f);}
		}else if(gmm[2]!=null){
			gmm[2].transform.Rotate(Vector3.up * (Input.mouseScrollDelta.y*2),Space.World);
		}
	}

	public void ons(int n){
		vct = Input.mousePosition;
		vt = rct[n].anchoredPosition;
		vp = point.transform.position;
	}
	public void drg(int n){
		Vector2 v = (Vector2)Input.mousePosition - vct;
		switch(n){
		case 0:
		case 2:
		case 4:
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		rct[n].anchoredPosition = vt + v;
		if(rct[n].anchoredPosition.x <-100){rct[n].anchoredPosition = new Vector2(-100,rct[n].anchoredPosition.y);}
		if(rct[n].anchoredPosition.x >100){rct[n].anchoredPosition = new Vector2(100,rct[n].anchoredPosition.y);}
		if(rct[n].anchoredPosition.y <-50){rct[n].anchoredPosition = new Vector2(rct[n].anchoredPosition.x,-50);}
		if(rct[n].anchoredPosition.y >50){rct[n].anchoredPosition = new Vector2(rct[n].anchoredPosition.x,50);}
		point.transform.position = Vector3.zero + new Vector3((rct[n].anchoredPosition.x*0.05f),vp.y,(rct[n].anchoredPosition.y*0.1f));
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		//if(v.y<-50){v.y = -50;}if(v.y>50){v.y = 50;}
		rct[n].localScale = Vector3.one*(1+(vp.y/2) + (v.y*0.01f));
		if(rct[n].localScale.x <1){rct[n].localScale = Vector3.one;}
		if(rct[n].localScale.x >3){rct[n].localScale = Vector3.one * 3;}
		point.transform.position = new Vector3(vp.x,-2 +rct[n].localScale.x * 2,vp.z);
		}
		pr[10] = (int)(point.transform.position.x*100);
		pr[11] = (int)(point.transform.position.y*100);
		pr[12] = (int)(point.transform.position.z*100);
		break;

		case 1:
		case 3:
		case 5:
		//if(v.x<-100){v.x = -50;}if(v.x>100){v.x = 10;}
		//if(v.x<-100){v.x = -100;}if(v.x>100){v.x = 100;}
		//if(v.y<-50){v.y = -50;}if(v.y>50){v.y = 50;}
		rct[n].anchoredPosition = vt + v;
		if(rct[n].anchoredPosition.x <-100){rct[n].anchoredPosition = new Vector2(-100,rct[n].anchoredPosition.y);}
		if(rct[n].anchoredPosition.x >100){rct[n].anchoredPosition = new Vector2(100,rct[n].anchoredPosition.y);}
		if(rct[n].anchoredPosition.y <-50){rct[n].anchoredPosition = new Vector2(rct[n].anchoredPosition.x,-50);}
		if(rct[n].anchoredPosition.y >50){rct[n].anchoredPosition = new Vector2(rct[n].anchoredPosition.x,50);}


		point.transform.eulerAngles = new Vector3(rct[n].anchoredPosition.y *-1.8f,rct[n].anchoredPosition.x *-1.8f,0);
		pr[13] = (int)(point.transform.eulerAngles.x*100);
		pr[14] = (int)(point.transform.eulerAngles.y*100);
		pr[15] = (int)(point.transform.eulerAngles.z*100);

		break;
		}
	}

}
