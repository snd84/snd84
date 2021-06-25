using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itcr : MonoBehaviour {
public Image im;
public Image imp;
public Image imp2;
public Image anm1;

public MeshFilter mf;
public MeshRenderer mr;
public Material dfm;
public GameObject rsv;
public GameObject rbt;

public GameObject gi;
public GameObject gi2;
public GameObject gi3;
public GameObject gi4;

public GameObject co;
public MeshFilter cf;
public Rigidbody rb;
public Mesh bx;
public Mesh sh;
public GameObject cm;
public GameObject cp;

public Image[] imr = new Image[30];
public Image[] imi = new Image[20];
public Image[] spf = new Image[30];

public Text[] tx = new Text[13];
public Slider[] sl = new Slider[13];
public Sprite[] sp1 = new Sprite[21];
public Sprite[] sp2 = new Sprite[30];
public Toggle[] tgl = new Toggle[2];
public RectTransform cc;
public RectTransform bb;
public AudioClip[] ac = new AudioClip[200];
public GameObject[] obs = new GameObject[10];
//int ons = 0;

public GameObject[] item = new GameObject[20];

public Material[] dmp = new Material[5];
public AudioSource asc;
public AudioSource[] itac = new AudioSource[20];
public Texture2D[] txr = new Texture2D[21];

bool pson1 = false;
bool pson2 = false;

float[] psft = new float[35];
float[] psft2 = new float[35];


int scy=0;
int[] nbr = new int[29];
float[] itn = new float[59];
public Slider[] slr = new Slider[38];
public GameObject[] swp = new GameObject[10];
public Image cor;
public Sprite dfs;
int k;
int l;
//int j=0;
float sz=1;
//BoxCollider bc;
//SphereCollider sc;
Vector2 vp;
Vector3 vc;
Vector3 vr; 
Vector3 bxh;
bool brk = false;

[ContextMenu ("sm")]
void sm(){
	AudioClip[] a = Resources.LoadAll<AudioClip>("minisd"); 
	ac = new AudioClip[a.Length];
	for(int i=0;i<a.Length;i++){
	ac[i] = a[i];
	}
}
	// Use this for initialization
	void Start () {
	/*
	for(k=0;k<slr.Length;k++){
		slr[k].value = slr[k].maxVa;
	}
	for(k=0;k<tgl.Length;k++){
		tgl[k].isOn = true;
	}
	*/
		mf.mesh = null;
		if(pson1){
			pson1=false;
			//imp.sprite = null;
			Destroy(gi4.GetComponent<ParticleSystem>());
		}
		if(pson2){
			pson2=false;
			//imp.sprite = null;
		}
		mf.mesh = null;
		im.sprite = dfs;
		imp.sprite = dfs;
		imp2.sprite = dfs;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void init(){

		nbr[0] = -10;
		nbr[1] = 100;
		nbr[2] = 5;
		nbr[3] = 0;
		nbr[4] = 0;
		nbr[5] = 0;
		nbr[6] = 1;
		nbr[7] = 1;
		nbr[8] = 1;
		nbr[9] = 0;
		nbr[10] = 0;
		nbr[11] = 1000;
		nbr[12] = 0;
		nbr[13] = 0;
		nbr[14] = 0;
		nbr[15] = 0;
		nbr[16] = 0;
		nbr[17] = 0;
		nbr[18] = 0;
		nbr[19] = 0;
		nbr[20] = 1;
		nbr[21] = 0;
		nbr[22] = 100;
		nbr[23] = 100;
		nbr[24] = 100;
		nbr[25] = 0;
		nbr[26] = 0;
		nbr[27] = 0;
		nbr[28] = -1;

	//	nbr[12] = 0;
	//	nbr[13] = 0;

		sl[0].value = -10;
		sl[1].value = 100;
		sl[2].value = -10;
		sl[3].value = 100;
		sl[4].value = 5;
		sl[5].value = 0;
		sl[6].value = 0;
		sl[7].value = 0;
		sl[8].value = 0;
		sl[9].value = 0;
		sl[10].value = 0;
		sl[11].value = 10;
		sl[12].value = 1;
		sl[13].value = 10;
		sl[14].value = 10;
		sl[15].value = 10;
		sl[16].value = 1;
		sl[17].value = -1;
		sl[18].value = 0;
		sl[19].value = 0;
		sl[20].value = 0;

		tx[0].text = ("-10");
		tx[1].text = ("100");
		tx[2].text = ("-10");
		tx[3].text = ("100");
		tx[4].text = ("5");
		tx[5].text = ("0");
		tx[6].text = ("0");
		tx[7].text = ("0");
		tx[8].text = ("0");
		tx[9].text = ("0");
		tx[10].text = ("0");
		tx[11].text = ("1000");
		tx[12].text = ("1");
		tx[13].text = ("1");
		tx[14].text = ("1");
		tx[15].text = ("1");

		tgl[0].isOn = true;
		tgl[2].isOn = false;
		tgl[3].isOn = false;
		tgl[4].isOn = false;
		tgl[5].isOn = true;
		tgl[6].isOn = true;
		tgl[7].isOn = true;

		bb.SetParent(obs[0].transform.parent.transform);
		//dgsr(0);
		mf.mesh = null;
		im.sprite = null;
		mr.material = dfm;
		co.transform.localScale = Vector3.one;
		co.transform.localPosition = Vector3.zero;
		sz = 1;
		pson1=false;
		pson2=false;
			//imp.sprite = null;

	}
	public void sykk(){
		sepd();
		dlps();
		dlps2();
		mf.mesh = null;
		im.sprite = dfs;
		imp.sprite = dfs;
		imp2.sprite = dfs;
		
		slr[0].value = 0;
		slr[1].value = 50;
		slr[2].value = 0;
		slr[3].value = 0;
		slr[4].value = 0;
		slr[5].value = 0;
		slr[6].value = 0;
		slr[7].value = 0;
		slr[8].value = 0;
		slr[9].value = 0;
		slr[10].value = 0;
		slr[11].value = 0;
		slr[12].value = 0;
		slr[13].value = 0;
		slr[14].value = 1;
		slr[15].value = 1;
		slr[16].value = 1;
		slr[17].value = 1;
		slr[18].value = 8000;
		slr[19].value = 0.05f;
		slr[20].value = 0;
		slr[21].value = 0;
		slr[22].value = 0;
		slr[23].value = 0;
		slr[24].value = 0;
		slr[25].value = 1;
		slr[26].value = 1;
		slr[27].value = 1;
		slr[28].value = 0;
		slr[29].value = 0;
		slr[30].value = 0;
		slr[31].value = 0;
		slr[32].value = 0;
		slr[33].value = 0;
		slr[34].value = 0;
		slr[35].value = -1;
		slr[36].value = -1;
		slr[37].value = 1;
		slr[38].value = 1;
		slr[39].value = 1;
		slr[40].value = 1;

		tgl[0].isOn = true;
		tgl[1].isOn = true;
		tgl[2].isOn = true;
		tgl[3].isOn = true;
		tgl[4].isOn = true;
		tgl[5].isOn = true;
		tgl[6].isOn = false;
		tgl[7].isOn = false;
		tgl[8].isOn = false;
		tgl[9].isOn = false;
		tgl[10].isOn = false;
		tgl[10].isOn = false;
		tgl[11].isOn = false;
		tgl[12].isOn = false;
		tgl[13].isOn = false;
		tgl[14].isOn = false;
		tgl[15].isOn = false;
		tgl[16].isOn = false;


		
	}

	public void sesp(){
		for(k=0;k<30;k++){
			if(date.ms[k]!=null){
			imr[k].sprite = date.se[k];
			}else{
			imr[k].sprite = null;
			}
			if(date.ps[k,25]>0){
			spf[k].sprite = date.pssp[k];
			}else{
			spf[k].sprite = null;
			}

		}
		for(k=0;k<20;k++){
			if(date.it!=null){
				imi[k].sprite = date.itsp[k];
			}else{
				imi[k] = null;
			}
		}
	}
	public void setc(int n){
		if(date.ms[n]!=null){
			mf.mesh = date.ms[n];
			im.sprite = date.se[n];
			if(date.mt[n]!=null){
				mr.material = date.mt[n];
				mr.material.mainTexture = Instantiate(date.tx[n]);
			}else{
				mr.material = dfm;
			}
			rsv.SetActive(false);
		}
	}
	public void medl(){
		mf.mesh = null;
		im.sprite = dfs;
	}
	public void brko(bool b){
		brk = b;
	}

	public void seps(int n){
		if(date.ps[n,25]>0){			
			if(brk){
			for(int i=0;i<35;i++){
			psft[i] = date.ps[n,i];			
			}
			imp.sprite = date.pssp[n];
			pson1 = true;
			psst(gi4,psft);
			}else{
			for(int i=0;i<35;i++){
			psft2[i] = date.ps[n,i];			
			}
			imp2.sprite = date.pssp[n];
			pson2 = true;
			psst(gi3,psft2);
			}
		}
	}
	public void pto1(float f){
		gi4.transform.localScale = Vector3.one*f;
	}
	public void pto2(float f){
		gi2.transform.localScale = Vector3.one*f;
	}

	public void sepd(){
		if(brk){
			dlps();
		}else{
			dlps2();
		}
	}
	public void psftset(float[] f){
		psft = f;
	}

	public void psst(GameObject g,float[] f){
			ParticleSystem p;
			if(g.GetComponent<ParticleSystem>()==null){
			p = g.AddComponent<ParticleSystem>();
			}else{
			p = g.GetComponent<ParticleSystem>();				
			}
			var pr = g.GetComponent<ParticleSystemRenderer>();
 		   	pr.renderMode = ParticleSystemRenderMode.Billboard;
 		   	
    		switch((int)f[30]){
    			case 0:pr.material = dmp[0];break;
    			case 1:pr.material = dmp[1];break;
    			case 2:pr.material = dmp[2];break;
    			case 3:pr.material = dmp[3];break;
    			case 4:pr.material = dmp[4];break;
    		}
    		pr.material.mainTexture = txr[(int)f[33]];
    		p.Stop();
	    	p.Clear();
   		 	ParticleSystem.MainModule pm = p.main;
			pm.startLifetime = f[0];
	    	pm.duration = f[0];
	    	pm.maxParticles = (int)f[1];
	    	pm.startRotation = new ParticleSystem.MinMaxCurve(f[31],f[32]);
	    	var em = p.emission;
	    	if(f[34]>0){
	    	em.rateOverTime = pm.maxParticles/f[0];}else{
	    	em.rateOverTime = f[1]*100;
	    	}
	    	pm.startSpeed = f[2];
   	    	AnimationCurve ac = new AnimationCurve();
	    	ac.AddKey(0,(1f/255f)*f[4]);
    		ac.AddKey(1,(1f/255f)*f[5]);
	    	var sol = p.sizeOverLifetime;
    		sol.size = new ParticleSystem.MinMaxCurve(7,ac);
    		sol.enabled = true;
   		 	pm.gravityModifier = f[6];
 	    	var sm = p.shape;
 	    	sm.rotation = new Vector3(-90,0,0);
	    	if(f[7]==0){sm.arcMode = ParticleSystemShapeMultiModeValue.Random;
	    	}else{
	    	sm.arcMode = ParticleSystemShapeMultiModeValue.Loop;
	    	sm.arcSpeed = f[7]/100f;
	    	}
	    	Gradient grad;
	 	    GradientColorKey[] ck = new GradientColorKey[2];
  			GradientAlphaKey[] al = new GradientAlphaKey[2];
  			grad =  new Gradient();
      		ck[0].color = new Color(f[8],f[9],f[10],f[11]);
     	    ck[0].time = 0.0f;
	        ck[1].color = new Color(f[12],f[13],f[14],f[15]);
    	    ck[1].time = 1.0f;
	        al[0].alpha = f[11];
   		    al[0].time = 0.0f;
       		al[1].alpha = f[15];
        	al[1].time = 1.0f;
   			grad.SetKeys(ck, al);
			var cr = p.colorOverLifetime;
			cr.enabled = true;
			cr.color = grad;
			sm.radius =f[16];
			sm.radiusThickness = f[17];
			sm.randomPositionAmount = f[18];
			sm.randomDirectionAmount = f[19];
			var pn = p.noise;
			if(f[20]!=0){
	    	pn.enabled = true;
	    	pn.strength = f[20]/10f;
	    	}else{
	    	pn.enabled = false;
	    	}
			var vel = p.velocityOverLifetime;
			vel.radialMultiplier = f[3];
	    	vel.orbitalXMultiplier = f[21];
	    	vel.orbitalYMultiplier = f[22];
   		 	vel.orbitalZMultiplier = f[23];
   		 	vel.enabled = true;
			if(f[26]>0){
			pm.simulationSpace = ParticleSystemSimulationSpace.World;
			}else{
			pm.simulationSpace = ParticleSystemSimulationSpace.Local;
			}
			if(f[27]>0){
			pm.prewarm =true;
			}else{
			pm.prewarm =false;
			}
			if(f[28]>0){
			pm.loop =true;
			}else{
			pm.loop =false;
			}

    	switch((int)f[29]){
    		case 0:
    		sm.shapeType = ParticleSystemShapeType.Sphere;
    		break;
    		case 1:
    		sm.shapeType = ParticleSystemShapeType.Hemisphere;
    		break;    		
    		case 2:
    		sm.shapeType = ParticleSystemShapeType.Cone;
    		break;
    		case 3:
    		sm.shapeType = ParticleSystemShapeType.Circle;
    		break;
    		case 4:
    		sm.shapeType = ParticleSystemShapeType.Donut;
    		break;
    		case 5:
    		sm.shapeType = ParticleSystemShapeType.Box;
    		break;
    	}
    	p.Play();
	}

	public void dlps(){
	if(gi4.GetComponent<ParticleSystem>()!=null){
		Destroy(gi4.GetComponent<ParticleSystem>());
		pson1 = false;
	}
	}	
	public void dlps2(){
	if(gi3.GetComponent<ParticleSystem>()!=null){
		pson2 = false;
		
	}
	}
	public void ax(){
		vp = Input.mousePosition;
		vc = co.transform.localPosition;
		vr = cp.transform.eulerAngles;
	}

	public void csc(){
		Vector2 v = (Vector2)Input.mousePosition - vp;
		/*
		if(Input.GetMouseButton(1)&&!Input.GetMouseButton(0)){
		co.transform.localPosition = vc + new Vector3(0,0,v.x*0.05f);
		if(co.transform.localPosition.z<-5){co.transform.localPosition = new Vector3(co.transform.localPosition.x,co.transform.localPosition.y,-5f);}
		if(co.transform.localPosition.z>5){co.transform.localPosition = new Vector3(co.transform.localPosition.x,co.transform.localPosition.y,5f);}
		sl[19].value = co.transform.localPosition.z;
		}
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		co.transform.localPosition = vc + new Vector3(v.x*0.02f,v.y*0.02f,0);
		if(co.transform.localPosition.x<-5){co.transform.localPosition = new Vector3(-5f,co.transform.localPosition.y,co.transform.localPosition.z);}
		if(co.transform.localPosition.x>5){co.transform.localPosition = new Vector3(5f,co.transform.localPosition.y,co.transform.localPosition.z);}
		if(co.transform.localPosition.y<-5){co.transform.localPosition = new Vector3(co.transform.localPosition.x,-5f,co.transform.localPosition.z);}
		if(co.transform.localPosition.y>5){co.transform.localPosition = new Vector3(co.transform.localPosition.x,5f,co.transform.localPosition.z);}
		sl[20].value = co.transform.localPosition.x;
		sl[18].value = co.transform.localPosition.y;
		
		}
		*/
		if(Input.GetMouseButton(2)){
			cp.transform.eulerAngles =  vr + new Vector3(v.y*0.25f,-v.x*0.25f,0);
		}
	}

	public void css(){
		cm.transform.localPosition += new Vector3(0,0,Input.mouseScrollDelta.y);
		if(cm.transform.localPosition.z>-5){cm.transform.localPosition = new Vector3(0,cm.transform.localPosition.y,-5);}
		if(cm.transform.localPosition.z<-17){cm.transform.localPosition = new Vector3(0,cm.transform.localPosition.y,-17);}
	}

	/*
	public void ax(){
		vp = Input.mousePosition;
		vc = co.transform.localScale;
	}

	public void axsz(int n){
		Vector2 v = (Vector2)Input.mousePosition - vp;
		switch(n){
			case 0:
			if(bc!=null){
				co.transform.localScale = vc + new Vector3(v.x*0.01f,0,0);
				if(co.transform.localScale.x<0.1f){
					co.transform.localScale = new Vector3(0.1f,vc.y,vc.z);
				}
			}
			break;
			case 1:
			if(bc!=null){
				co.transform.localScale = vc + new Vector3(0,v.x*0.01f,0);
				if(co.transform.localScale.y<0.1f){
					co.transform.localScale = new Vector3(vc.x,0.1f,vc.z);
				}
			}
			break;
			case 2:
			if(bc!=null){
				co.transform.localScale = vc + new Vector3(0,0,v.x*0.01f);
				if(co.transform.localScale.z<0.1f){
					co.transform.localScale = new Vector3(vc.x,vc.y,0.1f);
				}
			}
			break;
			case 3:
				co.transform.localScale = vc + new Vector3(v.x*0.01f,v.x*0.01f,v.x*0.01f);
				if(co.transform.localScale.z<0.1f){
					co.transform.localScale = new Vector3(co.transform.localScale.x,co.transform.localScale.y,0.1f);
				}
				if(co.transform.localScale.y<0.1f){
					co.transform.localScale = new Vector3(co.transform.localScale.x,0.1f,co.transform.localScale.z);
				}
				if(co.transform.localScale.x<0.1f){
					co.transform.localScale = new Vector3(0.1f,co.transform.localScale.y,co.transform.localScale.z);
				}
			break;
		}
	}
	*/

	public void cosp(){
		cf.mesh = sh;
		nbr[21] = 1;
		co.transform.localScale = Vector3.one * (sz/2f);
	}
	public void cobx(){
		cf.mesh = bx;
		nbr[21] = 0;
		co.transform.localScale = new Vector3((sl[13].value*0.1f),(sl[14].value*0.1f),(sl[15].value*0.1f));
	}
	public void cosp2(){
		co.transform.localScale = Vector3.one * slr[14].value;
	}
	public void cobx2(){
		co.transform.localScale = new Vector3((slr[15].value),(slr[16].value),(slr[17].value));
	}

/*
	public void sld1(float f){
		nbr[0] = (int)f;
		tx[0].text = (""+nbr[0]);
	}
	public void sld2(float f){
		nbr[1] = (int)f;
		tx[1].text = (""+nbr[1]);
	}
	public void sld3(float f){
		nbr[0] = (int)f;
		tx[2].text = (""+nbr[0]);
	}
	public void sld4(float f){
		nbr[1] = (int)f;
		tx[3].text = (""+nbr[1]);
	}
	public void sld5(float f){
		nbr[2] = (int)f;
		tx[4].text = (""+nbr[2]);
	}
	public void sld6(float f){
		nbr[0] = (int)f;
		tx[5].text = (""+nbr[0]);
	}
	public void sld7(float f){
		nbr[0] = (int)f;
		tx[6].text = (""+nbr[0]);
	}
	public void sld8(float f){
		nbr[0] = (int)f;
		tx[7].text = (""+nbr[0]);
	}
	public void sld9(float f){
		nbr[0] = (int)f;
		tx[8].text = (""+nbr[0]);
	}
	public void sld10(float f){
		nbr[0] = (int)f;
		tx[9].text = (nbr[0]+"%");
	}
	public void sld11(float f){
		nbr[0] = (int)f;
		tx[10].text = (nbr[0]+"%");
	}	
	public void sld12(float f){
		nbr[11] = (int)(f*f*f);
		tx[11].text = (""+nbr[11]);
	}
	public void sld13(float f){
		sz = Mathf.Round(f*10f);
		sz = sz*0.1f;
		co.transform.localScale = Vector3.one * (sz/2f);
		tx[12].text = (""+sz);
	}
	public void sld14(){
		co.transform.localScale = new Vector3(sl[13].value*0.1f,sl[14].value*0.1f,sl[15].value*0.1f);
		tx[13].text = (""+sl[13].value*0.1f);
		tx[14].text = (""+sl[14].value*0.1f);
		tx[15].text = (""+sl[15].value*0.1f);
	}

	public void sld18(float f){
		nbr[0] = (int)f;
		tx[18].text = (""+nbr[0]);
	}
	public void sld19(float f){
		nbr[1] = (int)f;
		tx[19].text = (""+nbr[1]);
	}
	public void sld21(float f){
		nbr[2] = (int)f;
		tx[20].text = (""+nbr[2]);
	}

	public void dgsr(int n){
		nbr[13] = n;

		bb.localPosition = Vector2.zero;
		obs[ons].SetActive(false);
		obs[n].SetActive(true);
		ons = n;
	}
	public void bid1(bool b){
		if(b){
			nbr[6] = 0;
		}else{
			nbr[6] = 1;
		}
	}
	public void bid2(bool b){
		if(b){
			nbr[7] = 0;
		}else{
			nbr[7] = 1;
		}
	}
	public void bid3(bool b){
		if(b){
			nbr[8] = 0;
		}else{
			nbr[8] = 1;
		}
	}
	public void bid4(bool b){
		if(b){
			nbr[9] = 0;
		}else{
			nbr[9] = 1;
		}
	}
	public void bid5(bool b){
		if(b){
			nbr[14] = 0;
		}else{
			nbr[14] = 1;
		}
	}
	public void bid6(bool b){
		if(b){
			nbr[15] = 0;
		}else{
			nbr[15] = 1;
		}
	}
	public void bidsdg(bool b){
		if(b){
			nbr[16] = 0;
		}else{
			nbr[16] = 1;
		}
	}

	public void sld20(float f){
		nbr[20] = (int)f;
	}
*/

	public void an(){
		l=0;
	}
	public void an1(){
		if(l==0){
		k++;
		if(k>23){k = 0;}
		anm1.sprite = sp1[k];
		Invoke("an1",0.025f);}

	}
	public void an1f(){
		anm1.sprite = sp1[0];
		l=1;
		k=0;
	}

	public void chos(int n){
		scy = n;
		cc.localPosition = Vector3.zero;
	}
	public void save(){
		if(mf.mesh != null){
		Invoke("savt",0.1f);
		}
	}
	public void sldon(int n){
		itn[n] = slr[n].value;
	}
	public void sldcr(){
		cor.color = new Color(slr[25].value,slr[26].value,slr[27].value);
	}
	public void slpt(){
		

	}

	public void sld(int n){
		//itn[n] = slr[n].value;
		tx[n].text = (""+slr[n].value);
	}
	public void tgon(bool b){

	}

	public void swip(int n){
		for(k=0;k<swp.Length;k++){
		swp[k].SetActive(false); 
		}
		swp[n].SetActive(true);
	}
	public void coch(float f){
		switch((int)f){
			case 0:
			cf.mesh = sh;
			cosp2();
			break;
			case 1:
			cf.mesh = bx;
			cobx2();
			break;

		}
	}
	void savt(){
		delt(scy);
		itm m = item[scy].GetComponent<itm>();

		for(k=0;k<slr.Length;k++){
			itn[k] = slr[k].value;
		}
		for(l=0;l<tgl.Length;l++){
			if(tgl[l].isOn){
			itn[k+l] = 1;
			}else{
			itn[k+l] = 0;	
			}
		}
		if(slr[35].value>=0){
			item[scy].GetComponent<AudioSource>().clip = date.adc[(int)slr[35].value];
			item[scy].GetComponent<AudioSource>().volume = slr[39].value;
		}
		if(slr[36].value>=0){
			GameObject g = Instantiate(gi2,Vector3.zero,Quaternion.identity,item[scy].transform);
			g.GetComponent<AudioSource>().clip = date.adc[(int)slr[36].value];
			g.GetComponent<AudioSource>().volume = slr[40].value;

			m.gm1(g);
		}
		if(pson2){
			GameObject g1 = Instantiate(gi3,Vector3.zero,Quaternion.identity,item[scy].transform);
			g1.transform.localScale = slr[38].value * Vector3.one;
			g1.layer = 13;
			m.gm2(g1);
			m.inpt2(psft2);
		}else{
			m.gm2d();
		}
		if(pson1){
			GameObject g2 = Instantiate(gi4,Vector3.zero,Quaternion.identity,item[scy].transform);
			g2.transform.localScale = slr[37].value * Vector3.one;
			g2.layer = 13;
			m.gm3(g2);
			m.inpt(psft);
		}else{
			m.gm3d();
		}


		m.lset(itn);
		item[scy].GetComponent<MeshFilter>().mesh = Instantiate(mf.mesh);
		item[scy].GetComponent<MeshRenderer>().material = Instantiate(mr.material);
		
		Sprite sp = Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		imi[scy].sprite = sp;
		date.itsp[scy] = sp;
		date.ittx[scy] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.ittx[scy]);
		rbt.SetActive(false);
		//init();
		date.it[scy] = item[scy];
		if(itn[0]>0){
			date.it[scy].tag = ("it");
			if(itn[34]>0){date.it[scy].tag = ("coin");}
			if(itn[22]>0){date.it[scy].tag = ("enag");}
			if(itn[21]>0){date.it[scy].tag = ("item");}

		}else{
		date.it[scy].tag = ("Fire");
		}
		
	}
	/*
	void sav(){
		delt(scy);
		itm m = item[scy].GetComponent<itm>();
		m.set(nbr);
		item[scy].GetComponent<MeshFilter>().mesh = Instantiate(mf.mesh);
		item[scy].GetComponent<MeshRenderer>().material = Instantiate(mr.material);
		if(nbr[21]==0){
		BoxCollider bo = item[scy].AddComponent<BoxCollider>();
		nbr[22] = (int)co.transform.localScale.x*100;
		nbr[23] = (int)co.transform.localScale.y*100;
		nbr[24] = (int)co.transform.localScale.z*100;
		nbr[25] = (int)co.transform.localPosition.x*100;
		nbr[26] = (int)co.transform.localPosition.y*100;
		nbr[27] = (int)co.transform.localPosition.z*100;

		bo.size = co.transform.localScale;
		bo.center = co.transform.localPosition;
		sl[18].value = 0;sl[19].value = 0;sl[20].value = 0;
		if(nbr[20]==0){bo.isTrigger = true;}
		}
		if(nbr[21]==1){
		SphereCollider s = item[scy].AddComponent<SphereCollider>();
		nbr[22] = (int)(sz*100);
		nbr[25] = (int)co.transform.localPosition.x*100;
		nbr[26] = (int)co.transform.localPosition.y*100;
		nbr[27] = (int)co.transform.localPosition.z*100;
		s.radius = sz/2;
		s.center = co.transform.localPosition;
		if(nbr[20]==0){s.isTrigger = true;}
		}

		date.it[scy] = item[scy];
		date.it[scy].layer = 13;
		date.it[scy].SetActive(false);
		//date.it[scy].name = (""+scy);
		if(nbr[13]==0||nbr[13]==1||nbr[13]==8){date.it[scy].tag = ("Fire");}
		if(nbr[13]==3){date.it[scy].tag = ("itms");}
		if(nbr[13]==2){date.it[scy].tag = ("enag");}
		if(nbr[13]==4){date.it[scy].tag = ("coin");}
		if(nbr[13]==6||nbr[13]==7){date.it[scy].tag = ("arm");}
		if(nbr[13]==5){date.it[scy].tag = ("wepn");}
		if(nbr[13]==9){date.it[scy].tag = ("it");}
		if(nbr[28]>=0){
			itac[scy].clip = Instantiate(ac[nbr[28]]);
			itac[scy].volume = asc.volume;
		}else{
			itac[scy].clip = null;
		}
		if(pson){psst(item[scy]);
			pson=false;
			imp.sprite = null;
			Destroy(gi.GetComponent<ParticleSystem>());
			m.inpt(psft);
		}else{
			if(item[scy].GetComponent<ParticleSystem>()!=null){Destroy(item[scy].GetComponent<ParticleSystem>());}
		}
		sl[17].value = -1; 
		tx[16].text = ("-");
		tx[17].text = ("");
		Sprite sp = Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		imi[scy].sprite = sp;
		date.itsp[scy] = sp;
		date.ittx[scy] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.ittx[scy]);
		rbt.SetActive(false);
		init();
	}
	*/
	public void delt(int n){
		if(date.it[n] != null){
			date.it[n] = null;
			if(item[n].GetComponent<BoxCollider>()){
				Destroy(item[n].GetComponent<BoxCollider>());
			}
			if(item[n].GetComponent<SphereCollider>()){
				Destroy(item[n].GetComponent<SphereCollider>());
			}

		}
	}
	public void del(){
		if(date.it[scy]!=null){
		delt(scy);
		date.it[scy] = null;
		date.itsp[scy] = null;
		imi[scy].sprite = null;
		}
	}
	public void csun(float n){
		if(n>=0){
		asc.clip = ac[(int)n];
		asc.Stop();
		asc.Play();
		tx[35].text = (""+n);
		}else{
		asc.clip = null;
		asc.Stop();
		tx[35].text = ("");
		}
	}
	public void csun2(float n){
		if(n>=0){
		asc.clip = ac[(int)n];
		asc.Stop();
		asc.Play();
		tx[36].text = (""+n);
		}else{
		asc.clip = null;
		asc.Stop();
		tx[36].text = ("");
		}
	}
	public void losd(int n){
		GameObject g = Instantiate(gi2,Vector3.zero,Quaternion.identity,item[n].transform);
	}

	public void tsft(){
		if(brk){
		slr[35].value++; 
		}else{
		slr[36].value++; 	
		}
	}
	public void msft(){
		if(brk){
		slr[35].value--; 
		}else{
		slr[36].value--; 	
		}
	}
	public void sply(){
		if(brk){
			asc.clip = ac[(int)slr[35].value];
			}else{
			asc.clip = ac[(int)slr[36].value];
			}
		asc.Stop();
		asc.Play();

	}
	public void load(){
		if(date.it[scy]!=null){
		float[] f = date.it[scy].GetComponent<itm>().get();
		for(k=0;k<slr.Length;k++){
			slr[k].value = f[k];
		}
		for(l=0;l<tgl.Length;l++){
			if(f[l+slr.Length]>0){
			tgl[l].isOn = true;
			}else{
			tgl[l].isOn = false;
			}
		}

		if(date.it[scy].GetComponent<itm>().oupt().Length>0){
			psst(gi4,date.it[scy].GetComponent<itm>().oupt());
			pson1 = true;
		}else{
			if(gi4.GetComponent<ParticleSystem>()!=null){
				dlps();
			}
		}
		if(date.it[scy].GetComponent<itm>().oupt2().Length>0){
			psst(gi3,date.it[scy].GetComponent<itm>().oupt2());
			pson2=true;
		}else{
			dlps2();
		}

		}
	}
}
