using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Compression;
using System.IO;
using System.Text;
using System;
using UnityEngine.Scripting;
using UnityEngine.UI;

public class date :MonoBehaviour{

public static GameObject[] obj = new GameObject[50]; 
public static Mesh[] ms = new Mesh[50]; 
public static Material[] mt = new Material[50];
public static Texture2D[] tx = new Texture2D[50];
public static Sprite[] se = new Sprite[50];
public static Texture2D[] ts = new Texture2D[50];
public static Texture2D rw;


public static Texture2D[] rbtx = new Texture2D[50];
public static Texture2D[] bltx = new Texture2D[50];
public static Texture2D[] ittx = new Texture2D[50];
public static Texture2D[] pstx = new Texture2D[50];
public static Texture2D[] vqtx = new Texture2D[50];


public static Sprite[] rbsp = new Sprite[50];
public static Sprite[] blsp = new Sprite[50];
public static Sprite[] itsp = new Sprite[50];
public static Sprite[] pssp = new Sprite[50];
public static Sprite[] vqsp = new Sprite[50];


public static GameObject[] rb = new GameObject[50];
public static GameObject[] bl = new GameObject[50];
public static GameObject[] it = new GameObject[50];
public static GameObject[] vq = new GameObject[50];
public static float[,] ps = new float[30,35];

public static AudioClip[] ac = new AudioClip[51];

public static int[,] itp = new int[20,9];
public static Vector3[,] izm = new Vector3[141,141];
public static int tiz = 0;
public static float vl = 0;

public static int hol=0;
public static float hsz=0.1f;
public static float hpw =8;
public static float umi=0;

public static Texture2D ftx;

int tns;
public static int pt=1;
public int ti = 10000;
public static int tm;

public jsonsave j;
public jsonbl jb;
public jsonit ji;
public jsonrb jr;
public jsontki jk;
public jsonmic jm;
public jsonpt jp;
public jsonvq jq;

public Material smt;
public GameObject[] rbs = new GameObject[20];
public GameObject[] bls = new GameObject[20];
public GameObject[] its = new GameObject[20];
public GameObject[] vqs = new GameObject[20];

public jsonsprb jtx;

public Material tkimt;
public Text[] twt = new Text[4];

public GameObject witp;

int nbs = 0;
int nbr = 0;
public RectTransform rrs;
public RectTransform rrd;
public Image[] rim = new Image[40];

public Text tmtx;
int wdy=1980;
int wdx=1080;
bool wdb;
public Text widt;

public static Vector3[,] map = new Vector3[140,140];
public static Texture2D[] stmp = new Texture2D[8];

public static AudioClip[] adc;
public itcr itcr0;
public GameObject ito;
public GameObject iprt;

bool dtck = true;
public Mesh[] vqms = new Mesh[10];
public Material vqmt;
	// Use this for initialization
	void Start () {
		AudioClip[] a = Resources.LoadAll<AudioClip>("minisd"); 
		adc = new AudioClip[a.Length];
		for(int i=0;i<a.Length;i++){
		adc[i] = a[i];
		}
		Application.targetFrameRate = 60;

	ftx = new Texture2D(1024,1024,TextureFormat.RGBA32,false);
	ftx.filterMode = FilterMode.Point;
	Color[] c = new Color[1024*1024];
	for(int i=0;i <c.Length;i++){
	c[i] = Color.white;
	}
	ftx.SetPixels(c);
	ftx.Apply();
	tkimt.mainTexture = ftx;
	}
	
	// Update is called once per frame
	void Update () {
		tns +=pt;
		if(tns>ti){
			tns=0;
			tm++;
			if(tm>=24){
				tm=0;
			}
		}
		tmtx.text = (tm+":"+(int)(tns/166.7f));
	}
	public void wisz(){
		Screen.SetResolution(wdy, wdx, wdb, 60);
	}
	public void wisz(float f){
		wdy = (int)(16*f);
		wdx = (int)(9*f);
		widt.text = (wdy+"\n"+wdx);	
	}
	public void wdbc(bool b){
		wdb = b;
	}
	public void qt(){
		UnityEngine.Application.Quit();
	}
	public void clup(float f){
		pt = (int)f;
	}
	public void cltm(int n){
		tm = n;
		tns = 0;
	}
	public void dlbl(){
	GameObject[] gr = GameObject.FindGameObjectsWithTag ("bl");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("wk");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("camp");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("itms");
	foreach (GameObject cl in gr){
	if(cl.layer == 12){
    Destroy(cl);
	}
	}
	gr = GameObject.FindGameObjectsWithTag ("enag");
	foreach (GameObject cl in gr){
	if(cl.layer == 12){
    Destroy(cl);
	}
	}
	gr = GameObject.FindGameObjectsWithTag ("tree");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}

	}
	public void itbl(){
	GameObject[] gr = GameObject.FindGameObjectsWithTag ("it");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("Fire");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("itms");
	foreach (GameObject cl in gr){
   	if(cl.layer == 13){
    Destroy(cl);
	}
	}
	gr = GameObject.FindGameObjectsWithTag ("enag");
	foreach (GameObject cl in gr){
	if(cl.layer == 13){
    Destroy(cl);
		}
	}
	gr = GameObject.FindGameObjectsWithTag ("coin");
	foreach (GameObject cl in gr){
	if(cl.layer == 13){
    Destroy(cl);
		}
	}
	}
	
	public void rbbl(){
	GameObject[] gr = GameObject.FindGameObjectsWithTag ("glp1");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("glp2");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("glp3");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
	gr = GameObject.FindGameObjectsWithTag ("rbd");
	foreach (GameObject cl in gr){
    Destroy(cl);
	}
		

	}

	public void tkcr(){
		Color[] c = new Color[1024*1024];
		for(int i=0;i <c.Length;i++){
		c[i] = Color.white;
		}
		date.ftx.SetPixels(c);
	}

	public void tksv(){
		jk.tki = new Vector2[141*141];
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
			jk.tki[(i*141)+j].x = izm[i,j].x;
			jk.tki[(i*141)+j].y = izm[i,j].y;
			}
		}		
		jk.tx = ftx.EncodeToPNG();
		jk.stp1 = stmp[0].EncodeToPNG();
		jk.stp2 = stmp[1].EncodeToPNG();
		jk.stp3 = stmp[2].EncodeToPNG();
		jk.stp4 = stmp[3].EncodeToPNG();
		jk.stp5 = stmp[4].EncodeToPNG();
		jk.stp6 = stmp[5].EncodeToPNG();
		jk.stp7 = stmp[6].EncodeToPNG();
		jk.stp8 = stmp[7].EncodeToPNG();
		
		string sv = JsonUtility.ToJson(jk);
		byte[] dt = System.Text.Encoding.ASCII.GetBytes(sv);
		File.WriteAllBytes(Application.persistentDataPath + "tkidate.Json",dt);
	}
	public void tkld(){
		 if(File.Exists(Application.persistentDataPath + "tkidate.Json")){
		string st = File.ReadAllText(Application.persistentDataPath + "tkidate.Json");
		JsonUtility.FromJsonOverwrite(st,jk);
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
				izm[i,j].x = jk.tki[(i*141)+j].x;
				izm[i,j].y = jk.tki[(i*141)+j].y;
			}
		}

		ftx = new Texture2D(1024,1024,TextureFormat.RGB24,false);
		ftx.LoadImage(jk.tx);
		ftx.Apply();
		tkimt.mainTexture = date.ftx;
		stmp[0] = new Texture2D(32,32);
		stmp[0].LoadImage(jk.stp1);
		stmp[1] = new Texture2D(32,32);
		stmp[1].LoadImage(jk.stp2);
		stmp[2] = new Texture2D(32,32);
		stmp[2].LoadImage(jk.stp3);
		stmp[3] = new Texture2D(32,32);
		stmp[3].LoadImage(jk.stp4);
		stmp[4] = new Texture2D(32,32);
		stmp[4].LoadImage(jk.stp5);
		stmp[5] = new Texture2D(32,32);
		stmp[5].LoadImage(jk.stp6);
		stmp[6] = new Texture2D(32,32);
		stmp[6].LoadImage(jk.stp7);
		stmp[7] = new Texture2D(32,32);
		stmp[7].LoadImage(jk.stp8);

		tiz=10;
		jk = new jsontki();
		}
	}

	public IEnumerator mssv(){
		if(dtck){
		dtck=false;
//		Color32[] c;
//		Color32[] g; 
//		int i;
//		int n;
//		byte[] b;
		//witp.SetActive(true);
		for(int k=0;k<50;k++){
		twt[0].text = (k+"/50");
		yield return new WaitForSeconds(0);
		if(ms[k]!=null){
			j.vms(k,ms[k]);
			j.mttsp(k,ts[k]);
			j.ms[k] = true;
		if(mt[k]!=null){
			j.mt[k] =true;
			j.mttxp(k,tx[k]);
			j.mttsp(k,ts[k]);
			switch(tx[k].width){
				case 128:j.vt[k]=1;break;
				case 256:j.vt[k]=2;break;
				case 512:j.vt[k]=3;break;
			}
			}else{j.vt[k] =4;}
		}
		}
		//witp.SetActive(false);
		string sv= JsonUtility.ToJson(j);
		byte[] dt = System.Text.Encoding.ASCII.GetBytes(sv);
		File.WriteAllBytes(Application.persistentDataPath + "savedate.Json",dt);	
		j = new jsonsave();	
		twt[0].text = ("");
		dtck=true;		
	} 
	}

	public IEnumerator msld(){
	if(dtck){
	dtck=false;
		string st = File.ReadAllText(Application.persistentDataPath + "savedate.Json");
		JsonUtility.FromJsonOverwrite(st,j);
		//witp.SetActive(true);
	for(int g=0;g<50;g++){
		twt[0].text = (g+"/50");
		yield return new WaitForSeconds(0);	

		if(j.ms[g]==true){
		ms[g] = new Mesh();
		ms[g].vertices = j.ouvc(g);
		ms[g].triangles = j.ouvi(g);
		ms[g].uv = j.ouvu(g);
		ms[g].normals = j.ouvn(g);

		ts[g] = new Texture2D(50,50,TextureFormat.RGB24,false);
		ts[g].LoadImage(j.ousp(g));
		ts[g].Apply();

		se[g] = Sprite.Create(ts[g],new Rect(0,0,50,50),new Vector2(0.5f,0.5f),100f);
		if(j.mt[g]==true){
			switch(j.vt[g]){
			case 1:tx[g] = new Texture2D(128,128);break;
			case 2:tx[g] = new Texture2D(256,256);break;
			case 3:tx[g] = new Texture2D(512,512);break;
			}
		tx[g].LoadImage(j.ouby(g));
		tx[g].filterMode = FilterMode.Point;
		tx[g].Apply();
		Destroy(mt[g]);
		mt[g] = Instantiate(smt);	
		mt[g].mainTexture = tx[g];
		}
		}
	}
	//witp.SetActive(false);
	j = new jsonsave();
	twt[0].text = ("");
	dtck=true;		
	} 
	}

	public IEnumerator bll(){
		if(dtck){
		dtck=false;
		string st = File.ReadAllText(Application.persistentDataPath + "bldate.Json");
		JsonUtility.FromJsonOverwrite(st,jb);
		Mesh m = new Mesh();
		Texture2D t = new Texture2D(1,1);
		Color32[] c = new Color32[1];
		Color32[] s = new Color32[2500];
		Material rl = smt;

		//witp.SetActive(true);
		for(int g=0;g<20;g++){
		twt[1].text = (g+"/20");
		yield return new WaitForSeconds(0);
		int[] p = jb.bopr(g);
		if(p.Length>0){
		for(int i=0;i<p[16];i++){
			GameObject go = new GameObject(""+i);
			go.transform.parent = bls[g].transform;

			go.AddComponent<MeshFilter>();
			go.AddComponent<MeshRenderer>();
			go.AddComponent<MeshCollider>();

			m.vertices = jb.bvto(g*100+i);
			m.triangles = jb.bino(g*100+i);
			m.uv = jb.bvuo(g*100+i); 
			m.RecalculateNormals();
			go.GetComponent<MeshFilter>().mesh = Instantiate(m);
			go.GetComponent<MeshCollider>().sharedMesh = go.GetComponent<MeshFilter>().mesh;
			go.tag = jb.bost(g);
			Vector3[] v = jb.btpo(g*100+i);
			go.transform.localPosition = v[0];
			go.transform.eulerAngles = v[1];
			go.transform.localScale = v[2];
			go.layer = 12;
			m = new Mesh();
			//if(jb.blb[g]!=4){
			//switch(jb.blb[g]){
			//case 1:t = new Texture2D(512,512,TextureFormat.RGB24,false);break;
			//case 2:t = new Texture2D(256,256,TextureFormat.RGB24,false);break;
			//case 3:t = new Texture2D(128,128,TextureFormat.RGB24,false);break;
			//}
			if(jb.btxo(g*100+i).Length>1){
			t.LoadImage(jb.btxo(g*100+i));
			t.filterMode = FilterMode.Point;
			t.Apply();
			rl.mainTexture = Instantiate(t);
			}else{rl.mainTexture = null;}
			go.GetComponent<MeshRenderer>().material = Instantiate(rl);
		}
			bls[g].GetComponent<blds>().set(jb.bopr(g));
			bls[g].tag = jb.bost(g);
			bl[g] = bls[g];

			bltx[g] = new Texture2D(50,50,TextureFormat.RGB24,false);
			bltx[g].LoadImage(jb.bosp(g));
			bltx[g].Apply();
			blsp[g] = Sprite.Create(bltx[g],new Rect(0,0,50,50),new Vector2(0.5f,0.5f));	
			}
		}
		rl.mainTexture = null;
		//witp.SetActive(false);
		jb = new jsonbl();
		twt[1].text = ("");
		dtck=true;		
	} 
 	}

	public IEnumerator blv(){
	if(dtck){
	dtck=false;
	Mesh m;
	//Texture2D t;
	Material rl;
	//witp.SetActive(true);
	for(int g=0;g<20;g++){
	twt[1].text = (g+"/20");
	yield return new WaitForSeconds(0);
	if(bl[g]!=null){
	for(int i=0;i<bl[g].transform.childCount;i++){
	
		GameObject go = bl[g].transform.GetChild(i).gameObject;
		m = go.GetComponent<MeshFilter>().mesh;
		//jb.bnnv(g,m.vertices,m.vertices.Length);
		//jb.bnni(g,m.triangles,m.triangles.Length);
		//jb.bnnu(g,m.uv,m.uv.Length);
		//jb.bnnn(g,m.normals,m.normals.Length);
		jb.bvti(g*100+i,m.vertices);
		jb.bvui(g*100+i,m.uv);
		jb.bini(g*100+i,m.triangles);
		jb.btpi(g*100+i,go.transform.localPosition,go.transform.eulerAngles,go.transform.localScale);
		rl = go.GetComponent<MeshRenderer>().material;
		if(rl.mainTexture!=null){
		//t = (Texture2D)rl.mainTexture;
//		switch(t.width){
//			case 512:jb.blb[g] = 1;break;
//			case 256:jb.blb[g] = 2;break;
//			case 128:jb.blb[g] = 3;break;
//		}
		//jb.bntx(g,t);
		jb.btxi(g*100+i,(Texture2D)rl.mainTexture);
		}//else{jb.blb[g] = 4;}

		jb.bnsp(g,bltx[g]);
		jb.bnpr(g,bls[g].GetComponent<blds>().get(),bls[g].GetComponent<blds>().get().Length);
		jb.bnst(g,bls[g].tag);	
	}
	}
	}
	//witp.SetActive(false);
	string sv = JsonUtility.ToJson(jb);
	File.WriteAllText(Application.persistentDataPath + "bldate.Json",sv);
	twt[1].text = ("");
	dtck=true;		
	} 
 	}

 	public IEnumerator ivt(){
	if(dtck){
	dtck=false;
	Mesh m;
	Texture2D t;
	Material rl;
	//witp.SetActive(true);
	for(int g=0;g<20;g++){
	twt[2].text = (g+"/20");
	yield return new WaitForSeconds(0);
	if(it[g]!=null){
		m = it[g].GetComponent<MeshFilter>().mesh;
		ji.innv(g,m.vertices,m.vertices.Length);
		ji.inni(g,m.triangles,m.triangles.Length);
		ji.innu(g,m.uv,m.uv.Length);
		ji.innn(g,m.normals,m.normals.Length);
		rl = it[g].GetComponent<MeshRenderer>().material;
		if(rl.mainTexture!=null){
		t = (Texture2D)rl.mainTexture;
		switch(t.width){
			case 512:ji.itb[g] = 1;break;
			case 256:ji.itb[g] = 2;break;
			case 128:ji.itb[g] = 3;break;
		}
		ji.intx(g,t);
		}else{ji.itb[g] = 4;}
		ji.insp(g,ittx[g]);
		ji.inpr(g,its[g].GetComponent<itm>().get(),its[g].GetComponent<itm>().get().Length);
		ji.inst(g,its[g].tag);
		ji.inpt(its[g].GetComponent<itm>().oupt(),g);
		ji.inpt2(its[g].GetComponent<itm>().oupt2(),g);

	}
	}
//	witp.SetActive(false);
	twt[2].text = ("");
	string sv = JsonUtility.ToJson(ji);
	File.WriteAllText(Application.persistentDataPath + "itdate.Json",sv);
	ji = new jsonit();
	dtck=true;		
	} 
	}

 	public IEnumerator itl(){
 		if(dtck){
		dtck=false;
		string st = File.ReadAllText(Application.persistentDataPath + "itdate.Json");
		JsonUtility.FromJsonOverwrite(st,ji);
		Mesh m = new Mesh();
		Texture2D t = new Texture2D(1,1);
		Color32[] c = new Color32[1];
		Color32[] s = new Color32[2500];
		Material rl = smt;
		//witp.SetActive(true);
		for(int g=0;g<20;g++){
		yield return new WaitForSeconds(0);
		twt[2].text = (g+"/20");
		//yield return new WaitForSeconds(0);
		if(ji.itb[g]>0){
			m.vertices = ji.ionv(g);
			m.triangles = ji.ioni(g);
			m.uv = ji.ionu(g); 
			m.normals = ji.ionn(g);
			its[g].GetComponent<MeshFilter>().mesh = Instantiate(m);
			m = new Mesh();
			if(ji.itb[g]!=4){
			switch(ji.itb[g]){
			case 1:t = new Texture2D(512,512,TextureFormat.RGB24,false);break;
			case 2:t = new Texture2D(256,256,TextureFormat.RGB24,false);break;
			case 3:t = new Texture2D(128,128,TextureFormat.RGB24,false);break;
			}
			t.LoadImage(ji.iotx(g));
			t.filterMode = FilterMode.Point;
			t.Apply();
			rl.mainTexture = Instantiate(t);
			}else{rl.mainTexture = null;}
			its[g].GetComponent<MeshRenderer>().material = Instantiate(rl);
			if(ji.iopr(g)[35]>=0){
				its[g].GetComponent<AudioSource>().clip = adc[(int)ji.iopr(g)[35]];
				its[g].GetComponent<AudioSource>().volume = ji.iopr(g)[39];
			}
			if(ji.iopr(g)[36]>=0){
				GameObject gm = Instantiate(ito,Vector3.zero,Quaternion.identity,its[g].transform);
				its[g].GetComponent<itm>().gm1(gm);
				gm.GetComponent<AudioSource>().clip = adc[(int)ji.iopr(g)[36]];
				gm.GetComponent<AudioSource>().volume = ji.iopr(g)[40];
			}
			its[g].GetComponent<itm>().lset(ji.iopr(g));
			its[g].tag = ji.iost(g);
			it[g] = its[g];

			ittx[g] = new Texture2D(50,50,TextureFormat.RGB24,false);
			ittx[g].LoadImage(ji.iosp(g));
			ittx[g].Apply();
			itsp[g] = Sprite.Create(ittx[g],new Rect(0,0,50,50),new Vector2(0.5f,0.5f));

			if(ji.oupt(g).Length>0){
				GameObject gm = new GameObject();
				itcr0.psst(gm,ji.oupt(g));
				gm.transform.parent = its[g].transform;
				gm.transform.localScale = Vector3.one * ji.iopr(g)[37];
				its[g].GetComponent<itm>().gm3(gm);
				its[g].GetComponent<itm>().inpt(ji.oupt(g));
			}
			if(ji.oupt2(g).Length>0){
				GameObject gm =  Instantiate(iprt,Vector3.zero,Quaternion.identity,its[g].transform);
				gm.layer = 13;
				itcr0.psst(gm,ji.oupt2(g));
				its[g].GetComponent<itm>().gm2(gm);
				its[g].GetComponent<itm>().inpt2(ji.oupt2(g));
			}

			}
		}
		rl.mainTexture = null;
		//witp.SetActive(false);	
		ji = new jsonit();
		twt[2].text = ("");
		dtck=true;		
		} 
 	}

 	public void sprb(){
 		int i;
 		for(i=0;i<20;i++){
 			if(rb[i]!=null){
 			rim[i].sprite = rbsp[i];
 			}
 		}
 		if(File.Exists(Application.persistentDataPath + "rbtx.Json")){
 		string st = File.ReadAllText(Application.persistentDataPath + "rbtx.Json");
 		JsonUtility.FromJsonOverwrite(st,jtx);
		Color32[] s = new Color32[2500];
 		int e;
 		for(int n=0;n<20;n++){
 		Texture2D tx = new Texture2D(50,50,TextureFormat.RGB24,false);
 			if(jtx.rsp[n]){
 			e=0;
			byte[] b = jtx.sptx(n);
			for(i=0;i<s.Length;i++){
			s[i].r = b[e];
			s[i].g = b[e+1];
			s[i].b = b[e+2];
			s[i].a = 255;
			e+=3;
			}
			tx.SetPixels32(s);
			tx.Apply();
 			rim[20+n].sprite = Sprite.Create(tx,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
 			}else{
			rim[20+n].sprite = null;
 			}
 		}
 		}
 	}
 	public void nbsn(int n){
 		nbs = n;
 		rrs.localPosition = Vector3.zero;
 	}
 
 	public void rbsv(){
	Mesh m;
	Texture2D t;
	int n;
	int i;
	int p;
	Material rl;
	GameObject[] gm;
	if(rbsp[nbs]!=null){
	//witp.SetActive(true);
	//twt.text = ("");
	
		gm = rb[nbs].GetComponent<rovoko>().ougc();
		p = rb[nbs].GetComponent<rovoko>().oub();
		//jr.rbvc0[0] = new Vector3[m.vertices.Length];
		//jr.rbvc0[0] = m.vertices[n];
		jr.maps(rb[nbs].GetComponent<rovoko>().ouwk());
		jr.rbc0 = new int[p];
		jr.rbc0[0] = p;
		jr.rbpn0 = new Vector3[p];
		jr.rbls0 = new Vector3[p];
		for(i=0;i<p;i++){
		m = gm[i].GetComponent<MeshFilter>().mesh;
		jr.msvc0(i,m.vertices,m.vertices.Length);
		jr.msvi0(i,m.triangles,m.triangles.Length);
		jr.msvu0(i,m.uv,m.uv.Length);
		jr.msvn0(i,m.normals,m.normals.Length);
		jr.rbpn0[i] = gm[i].transform.localPosition;
		jr.rbls0[i] = gm[i].transform.localScale;
		jr.rbcp = rb[nbs].GetComponent<CapsuleCollider>().center;
		jr.rbco = new Vector2(rb[nbs].GetComponent<CapsuleCollider>().radius,rb[nbs].GetComponent<CapsuleCollider>().height);
			for(n=1;n<i;n++){
				if(gm[i].transform.parent == gm[n].transform){
					jr.rbc0[i] = n;
					break;
				}
			}
		}
		jr.rbtb0 = new int[p];
		for(i=0;i<p;i++){
		rl = gm[i].GetComponent<MeshRenderer>().material;
		if(rl.mainTexture!=null){
		t = (Texture2D)rl.mainTexture;
		jr.rbtx0(i,t);
		}else{jr.rbtb0[i] = 4;}		
		}	
		jr.rbsp0 = rbtx[nbs].EncodeToPNG();
//		rim[20+nbr].sprite = rbsp[nbs];
//		jtx.txcc();
		string ttt = JsonUtility.ToJson(jtx);
		File.WriteAllText(Application.persistentDataPath + "rbtx.Json",ttt);
		jr.rbpr0 = new int[rbs[nbs].GetComponent<rovoko>().ous().Length];
		rbs[nbs].GetComponent<rovoko>().ous().CopyTo(jr.rbpr0,0);	
		jr.rblm0 = new int[rbs[nbs].GetComponent<rovoko>().oulm().Length];
		rbs[nbs].GetComponent<rovoko>().oulm().CopyTo(jr.rblm0,0);
		jr.onrt0(rbs[nbs].GetComponent<rovoko>().ouc(0));
		jr.onrt1(rbs[nbs].GetComponent<rovoko>().ouc(1));
		jr.onrt2(rbs[nbs].GetComponent<rovoko>().ouc(2));
		jr.onrt3(rbs[nbs].GetComponent<rovoko>().ouc(3));
		jr.onrt4(rbs[nbs].GetComponent<rovoko>().ouc(4));
		jr.onrt5(rbs[nbs].GetComponent<rovoko>().ouc(5));
		jr.onrt6(rbs[nbs].GetComponent<rovoko>().ouc(6));
		jr.onrt7(rbs[nbs].GetComponent<rovoko>().ouc(7));
		jr.onrt8(rbs[nbs].GetComponent<rovoko>().ouc(8));

		jr.rbst0 = rbs[nbs].tag;
		string sv = JsonUtility.ToJson(jr);
		switch(nbr){
		case 0:	File.WriteAllText(Application.persistentDataPath + "rbdate1.Json",sv);break;
		case 1:	File.WriteAllText(Application.persistentDataPath + "rbdate2.Json",sv);break;
		case 2:	File.WriteAllText(Application.persistentDataPath + "rbdate3.Json",sv);break;
		case 3:	File.WriteAllText(Application.persistentDataPath + "rbdate4.Json",sv);break;
		case 4:	File.WriteAllText(Application.persistentDataPath + "rbdate5.Json",sv);break;
		case 5:	File.WriteAllText(Application.persistentDataPath + "rbdate6.Json",sv);break;
		case 6:	File.WriteAllText(Application.persistentDataPath + "rbdate7.Json",sv);break;
		case 7:	File.WriteAllText(Application.persistentDataPath + "rbdate8.Json",sv);break;
		case 8:	File.WriteAllText(Application.persistentDataPath + "rbdate9.Json",sv);break;
		case 9:	File.WriteAllText(Application.persistentDataPath + "rbdate10.Json",sv);break;
		case 10:File.WriteAllText(Application.persistentDataPath + "rbdate11.Json",sv);break;
		case 11:File.WriteAllText(Application.persistentDataPath + "rbdate12.Json",sv);break;
		case 12:File.WriteAllText(Application.persistentDataPath + "rbdate13.Json",sv);break;
		case 13:File.WriteAllText(Application.persistentDataPath + "rbdate14.Json",sv);break;
		case 14:File.WriteAllText(Application.persistentDataPath + "rbdate15.Json",sv);break;
		case 15:File.WriteAllText(Application.persistentDataPath + "rbdate16.Json",sv);break;
		case 16:File.WriteAllText(Application.persistentDataPath + "rbdate17.Json",sv);break;
		case 17:File.WriteAllText(Application.persistentDataPath + "rbdate18.Json",sv);break;
		case 18:File.WriteAllText(Application.persistentDataPath + "rbdate19.Json",sv);break;
		case 19:File.WriteAllText(Application.persistentDataPath + "rbdate20.Json",sv);break;
		}
		jr = new jsonrb();
		}else{return;}
	
	//witp.SetActive(false);


 	
 	}
 	public void nbrn(int n){
 		nbr = n;
 		rrd.localPosition = Vector3.zero;
 	}
 	public IEnumerator nbrnall(){
 		if(dtck){
		dtck=false;
 	for(int i=0;i<20;i++){
 		nbs = i;
 		nbr = i;
 		rbsv();
 		twt[3].text = (i+"/20");
 		yield return new WaitForSeconds(0);
 	}
 	twt[3].text = null;
 		dtck=true;		
		} 
 	}
 	public IEnumerator nbllall(){
 		if(dtck){
		dtck=false;
 	 	yield return new WaitForSeconds(0);	
 	for(int i=0;i<20;i++){
 		nbr = i;
 		nbs = i;
 		twt[3].text = (i+"/20");
 		yield return new WaitForSeconds(0);
 		rbld();
 	}
 	twt[3].text = ("");
 		dtck=true;		
		} 
 	}

 	public void rbld(){
 		string st;
 		switch(nbr){
		case 0:if(!File.Exists(Application.persistentDataPath + "rbdate1.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate1.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 1:if(!File.Exists(Application.persistentDataPath + "rbdate2.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate2.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 2:if(!File.Exists(Application.persistentDataPath + "rbdate3.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate3.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 3:if(!File.Exists(Application.persistentDataPath + "rbdate4.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate4.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 4:if(!File.Exists(Application.persistentDataPath + "rbdate5.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate5.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 5:if(!File.Exists(Application.persistentDataPath + "rbdate6.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate6.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 6:if(!File.Exists(Application.persistentDataPath + "rbdate7.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate7.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 7:if(!File.Exists(Application.persistentDataPath + "rbdate8.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate8.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 8:if(!File.Exists(Application.persistentDataPath + "rbdate9.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate9.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 9:if(!File.Exists(Application.persistentDataPath + "rbdate10.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate10.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 10:if(!File.Exists(Application.persistentDataPath + "rbdate11.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate11.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 11:if(!File.Exists(Application.persistentDataPath + "rbdate12.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate12.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 12:if(!File.Exists(Application.persistentDataPath + "rbdate13.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate13.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 13:if(!File.Exists(Application.persistentDataPath + "rbdate14.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate14.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 14:if(!File.Exists(Application.persistentDataPath + "rbdate15.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate15.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 15:if(!File.Exists(Application.persistentDataPath + "rbdate16.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate16.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 16:if(!File.Exists(Application.persistentDataPath + "rbdate17.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate17.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 17:if(!File.Exists(Application.persistentDataPath + "rbdate18.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate18.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 18:if(!File.Exists(Application.persistentDataPath + "rbdate19.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate19.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		case 19:if(!File.Exists(Application.persistentDataPath + "rbdate20.Json")){return;}
		st = File.ReadAllText(Application.persistentDataPath + "rbdate20.Json");JsonUtility.FromJsonOverwrite(st,jr);break;
		}
		Mesh m = new Mesh();
		Texture2D t = new Texture2D(1,1);
		Color32[] c = new Color32[1];
		Color32[] s = new Color32[2500];
		int n;
		int p;
		int k;
		Material rl = smt;
		GameObject[] g;

		//witp.SetActive(true);
		//twt.text = ((nbr+1)+"/20");

		if(jr.rbc0[0]>0){
			if(rbs[nbs].transform.childCount>0){
			Destroy(rb[nbs].transform.GetChild(0).gameObject);
			}
			p = jr.rbc0[0];
			g = new GameObject[p];
			for(n=0;n<p;n++){
			g[n] = new GameObject();
			}
			g[0].transform.parent = rbs[nbs].transform;
			for(n=0;n<p;n++){
				g[n].AddComponent<MeshFilter>();
				if(jr.onvc0(n).Length>0){
				m.vertices = jr.onvc0(n);
				m.triangles = jr.onvi0(n);
				m.uv = jr.onvu0(n);
				m.normals = jr.onvn0(n);
				g[n].GetComponent<MeshFilter>().mesh = Instantiate(m);
				m = new Mesh();
				}
				g[n].AddComponent<MeshRenderer>();
				if(n>0){g[n].transform.parent = g[jr.rbc0[n]].transform;}
				g[n].transform.localPosition = jr.rbpn0[n];
				g[n].transform.localScale = jr.rbls0[n];
				rbs[nbs].GetComponent<CapsuleCollider>().center = jr.rbcp;
				rbs[nbs].GetComponent<CapsuleCollider>().radius = jr.rbco.x;
				rbs[nbs].GetComponent<CapsuleCollider>().height = jr.rbco.y;

			}

			for(k=0;k<p;k++){
			if(jr.rbtb0[k]!=4){
			switch(jr.rbtb0[k]){
			case 1:t = new Texture2D(512,512,TextureFormat.RGB24,false);break;
			case 2:t = new Texture2D(256,256,TextureFormat.RGB24,false);break;
			case 3:t = new Texture2D(128,128,TextureFormat.RGB24,false);break;
			}
			t.LoadImage(jr.ontx0(k));
			t.filterMode = FilterMode.Point;
			t.Apply();
			rl.mainTexture = Instantiate(t);
			}else{rl.mainTexture = null;}
			g[k].GetComponent<MeshRenderer>().material = Instantiate(rl);
			}

			rbs[nbs].GetComponent<rovoko>().rbon(g,jr.rblm0,p,jr.rbpr0);
			rbs[nbs].GetComponent<rovoko>().inmta(jr.rbrt0,jr.rbrt1,jr.rbrt2,jr.rbrt3,jr.rbrt4,jr.rbrt5,jr.rbrt6,jr.rbrt7,jr.rbrt8);

			rbs[nbs].GetComponent<rovoko>().onwk(jr.mapl());
			rbs[nbs].tag = jr.rbst0;
			rb[nbs] = rbs[nbs];
			n=0;

			rbtx[nbs] = new Texture2D(50,50,TextureFormat.RGB24,false);
			rbtx[nbs].LoadImage(jr.rbsp0);
			rbtx[nbs].Apply();
			rbsp[nbs] = Sprite.Create(rbtx[nbs],new Rect(0,0,50,50),new Vector2(0.5f,0.5f));	
			rim[nbs].sprite = rbsp[nbs];
			}

	

		//witp.SetActive(false);
		rl.mainTexture = null;
		jr = new jsonrb();
 	}


 	public IEnumerator micl(){
 		if(dtck){
		dtck=false;
		if(File.Exists(Application.persistentDataPath + "micdate.Json")){
		string st = File.ReadAllText(Application.persistentDataPath + "micdate.Json");
		JsonUtility.FromJsonOverwrite(st,jm);
 		for(int i=0;i<50;i++){
 			twt[4].text = (i+"/50");
 			yield return new WaitForSeconds(0);
 			if(jm.mio(i).Length>0){
 			ac[i] = AudioClip.Create(""+i,jm.mio(i).Length,1,44100,false);
 			ac[i].SetData(jm.mio(i),0);
 			}
 		}
 		jm = new jsonmic();
 		twt[4].text = ("");
		}
		dtck=true;		
		} 
 	}

 	public IEnumerator mics(){
 		if(dtck){
		dtck=false;
 		for(int i=0;i<50;i++){
 			if(ac[i]!=null){
			twt[4].text = (i+"/50");
			yield return new WaitForSeconds(0);
 			float[] f = new float[ac[i].samples];
 			ac[i].GetData(f,0);
 			jm.min(i,f);
 			}
 		}
		string sv = JsonUtility.ToJson(jm);
 		File.WriteAllText(Application.persistentDataPath + "micdate.Json",sv);
 		jm = new jsonmic();
 		twt[4].text = ("");
 		dtck=true;		
		} 
 	}


 	public IEnumerator ptcl(){
 		if(dtck){
		dtck=false;
		if(File.Exists(Application.persistentDataPath + "ptdate.Json")){
		string st = File.ReadAllText(Application.persistentDataPath + "ptdate.Json");
		JsonUtility.FromJsonOverwrite(st,jp);
 		for(int i=0;i<30;i++){
			twt[5].text = (i+"/30");
			yield return new WaitForSeconds(0);
 			if(jp.iosp(i).Length>0){
 				float[] f = new float[35];
 				jp.prto(i).CopyTo(f,0);
 				if(f[25]>0){
 				for(int n=0;n<35;n++){
 					ps[i,n] += f[n];
 				}
 				pstx[i] = new Texture2D(50,50,TextureFormat.RGB24,false);
				pstx[i].LoadImage(jp.iosp(i));
				pstx[i].Apply();
				pssp[i] = Sprite.Create(pstx[i],new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
				}
 			}
 		}
 		jp = new jsonpt();
 		twt[5].text = ("");
		}

		dtck=true;		
		} 
 	}

 	public IEnumerator ptcs(){
 		if(dtck){
 			dtck=false;
 		for(int i=0;i<30;i++){
			twt[5].text = (i+"/30");
			yield return new WaitForSeconds(0);
 			if(ps[i,25]>0){
 				float[] f = new float[35];
 				for(int n=0;n<35;n++){
 					f[n] += ps[i,n];
 				}
 			jp.prtn(i,f);
 			jp.insp(i,pstx[i]);
 			}
 		}
		string sv = JsonUtility.ToJson(jp);
 		File.WriteAllText(Application.persistentDataPath + "ptdate.Json",sv);
 		jp = new jsonpt();
 		twt[5].text = ("");
		dtck=true;		
		} 	
 	}
	public IEnumerator vqcs(){
 		if(dtck){
 		dtck=false;
		for(int i=0;i<20;i++){
			twt[6].text = (i+"/20");
			yield return new WaitForSeconds(0);
			if(vq[i]!=null){
			vlocs vs = vq[i].GetComponent<vlocs>(); 
			jq.inos(i,vs.ous());
			jq.invp(i,vs.ovp(0),vs.ovp(1),vs.ovp(2),vs.ovp(3),vs.ovp(4));
			jq.invr(i,vs.ovr(0),vs.ovr(1),vs.ovr(2),vs.ovr(3),vs.ovr(4));
			jq.invt(i,vs.ovt(0),vs.ovt(1),vs.ovt(2),vs.ovt(3),vs.ovt(4));
			jq.inmm(i,vs.oumm());
			jq.int1(i,vs.outp());
			jq.intx(i,vqtx[i]);
			jq.incl(i,vs.ocl());
			jq.insz(i,vs.osz());
			}
		}
 		string sv = JsonUtility.ToJson(jq);
		File.WriteAllText(Application.persistentDataPath + "vqdate.Json",sv);
 		jp = new jsonpt();
		twt[6].text = ("");
		dtck=true;
 		}
	}
	public IEnumerator vqcl(){
 		if(dtck){
		dtck=false;
		if(File.Exists(Application.persistentDataPath + "vqdate.Json")){
		string st = File.ReadAllText(Application.persistentDataPath + "vqdate.Json");
		JsonUtility.FromJsonOverwrite(st,jq);
 		for(int i=0;i<20;i++){
			twt[6].text = (i+"/20");
			yield return new WaitForSeconds(0);
			if(jq.ons[i]>0){
 			vlocs vs = vqs[i].GetComponent<vlocs>();
 			vs.ins(jq.ons[i]);
 			for(int k=0;k<jq.ons[i];k++){
 				vs.iset(k,jq.ouvp((i*10)+k),jq.ouvr((i*10)+k),jq.ouvt((i*10)+k),jq.ousz(i)[k],jq.oumm(i)[k],vqms[jq.oumm(i)[k]-1],jq.out1(i),jq.oucl(i));
 			}
 			 	vqtx[i] = new Texture2D(50,50,TextureFormat.RGB24,false);
				vqtx[i].LoadImage(jq.outx(i));
				vqtx[i].Apply();
				vqsp[i] = Sprite.Create(vqtx[i],new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
 			vq[i] = vqs[i];
 			}
 		}
 		jq = new jsonvq();
 		twt[6].text = ("");
		}

		dtck=true;		
		} 
	}

}
