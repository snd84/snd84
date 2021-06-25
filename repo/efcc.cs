using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class efcc : MonoBehaviour
{
	public ParticleSystem prt;
	public GameObject ip;	
	public Slider[] sl = new Slider[26];
	public Text[] tx = new Text[27];

	public Text tmtx;
	public Text tmpc;
	Vector2 mp;
	Vector3 cmp;
	public GameObject cm;
	public GameObject cmr;
	public RectTransform rct;
	Vector2 rc;
	Vector2 ct;
	public Material[] mtf = new Material[5];
	public RectTransform svr;
	int svs=0;
	int spc=0;
    int mtn=0;
    bool brst = true;
    int txn = 0;
	public Camera cam;
	public Image[] ri = new Image[30];
	public GameObject[] svp = new GameObject[31];
	public efctimr efc;
    public Toggle[] tg = new Toggle[3];
    public Material mtl;
    public Texture2D[] msp = new Texture2D[20];

	ParticleSystem.MainModule pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = prt.main;
    }

    void Update(){
    	if(!prt.isPlaying){prt.Play();}
    		tmtx.text = (""+((int)((prt.time)*100)/100f));
       		tmpc.text = (""+prt.particleCount);
    }

    public void rctd(){
    	rc = Input.mousePosition;
    	ct = rct.anchoredPosition;
    }

    public void recg(){
    	Vector2 v = ct + ((Vector2)Input.mousePosition - rc);
    	rct.anchoredPosition = v;
    	if(rct.anchoredPosition.x<-466){rct.anchoredPosition = new Vector2(-466,rct.anchoredPosition.y);}
    	if(rct.anchoredPosition.x>10){rct.anchoredPosition = new Vector2(10,rct.anchoredPosition.y);}
    	if(rct.anchoredPosition.y<-448){rct.anchoredPosition = new Vector2(rct.anchoredPosition.x,-448);}
    	if(rct.anchoredPosition.y>-272){rct.anchoredPosition = new Vector2(rct.anchoredPosition.x,-272);}

    }

    public void cmsc(){
    	if(Input.mouseScrollDelta.y!=0){
			cm.transform.localPosition += new Vector3(0,0,Input.mouseScrollDelta.y*2);
			if(cm.transform.localPosition.z > -2){ cm.transform.localPosition = new Vector3(0,0,-2f);}
			if(cm.transform.localPosition.z < -65){ cm.transform.localPosition = new Vector3(0,0,-65f);}
    	}
    }
    public void mtch(int n){
        txn = n;
        mdmt(mtn);
    }
    public void mvs(bool b){
    	if(!b){
    	pm.simulationSpace = ParticleSystemSimulationSpace.Local;
    	}else{
    	pm.simulationSpace = ParticleSystemSimulationSpace.World;	
    	}
    }


    public void mpr(bool b){
    	if(!b){
    	pm.prewarm = false;
    	}else{
    	pm.prewarm = true;
    	}
    }
    public void mlop(bool b){
        if(!b){
        pm.loop = false;
        }else{
        pm.loop = true;
        }
    }

    public void mxpc(float f){
    	pm.maxParticles = (int)(f*f*f);
    	var em = prt.emission;
        if(brst){
    	em.rateOverTime = pm.maxParticles / sl[0].value;
        }else{
        em.rateOverTime = pm.maxParticles*100;    
        }
	   	tx[1].text = (""+pm.maxParticles);
    }
    public void brbl(bool b){
        brst = b;
        prt.Stop();
        prt.Clear();
        mxpc(sl[1].value);
        prt.Play();
    }
    public void rotp(int n){
    	var vel = prt.velocityOverLifetime;
    	if(n==0){
    		if(Input.GetMouseButton(1)){sl[21].value = Mathf.Round(sl[21].value * 10)/10;}
    	}
    	if(n==1){
    		if(Input.GetMouseButton(1)){sl[22].value = Mathf.Round(sl[22].value * 10)/10;}
    	}
    	if(n==2){
    		if(Input.GetMouseButton(1)){sl[23].value = Mathf.Round(sl[23].value * 10)/10;}
    	}

    	vel.orbitalXMultiplier = sl[21].value;
    	vel.orbitalYMultiplier = sl[22].value;
    	vel.orbitalZMultiplier = sl[23].value;
    	tx[21].text = (""+sl[21].value);
    	tx[22].text = (""+sl[22].value);
    	tx[23].text = (""+sl[23].value);

    }
    public void rdil(){
    	if(Input.GetMouseButton(1)){sl[3].value = Mathf.Round(sl[3].value * 10)/10;}
        var vel = prt.velocityOverLifetime;
        vel.radialMultiplier = sl[3].value;
        tx[24].text = (""+sl[3].value);
    }

    public void sspd(){
    	if(Input.GetMouseButton(1)){sl[2].value = Mathf.Round(sl[2].value * 10)/10;}
    	pm.startSpeed = sl[2].value;
		
    //	var vol = prt.velocityOverLifetime;
    //	vol.speedModifier = sl[3].value;
    //	AnimationCurve c = new AnimationCurve();
    //	c.AddKey(0,sl[2].value);
    //	c.AddKey(1,sl[3].value);
    //	ParticleSystem.MinMaxCurve m = new ParticleSystem.MinMaxCurve(10,c);
    //	vol.y = m;
    	tx[2].text = (""+sl[2].value);
    //	tx[3].text = (""+sl[3].value);
    }
    public void sltm(float f){
    	prt.Stop();
    	prt.Clear();
        float fs = ((int)(f*10))/10f;
    	pm.startLifetime = fs;
    	pm.duration = fs;
    	tx[0].text = (""+fs);
        mxpc(sl[1].value);
    	prt.Play();
    }
    public void sssc(int n){
// 		pm.startSize = new ParticleSystem.MinMaxCurve(sl[4].value/10, sl[5].value/10);
    	var sol = prt.sizeOverLifetime;
    	AnimationCurve c = new AnimationCurve();
    	c.AddKey(0,(1f/255f)*sl[4].value);
    	c.AddKey(1,(1f/255f)*sl[5].value);
    	sol.size = new ParticleSystem.MinMaxCurve(7,c);
	   	//tx[4].text = (""+sl[4].value*5);
    	//tx[5].text = (""+sl[5].value*5);
    	tx[5].text = (sl[4].value+"-"+sl[5].value);
    }
    public void sgvt(){
		pm.gravityModifier = sl[6].value;
		if(Input.GetMouseButton(1)){
			sl[6].value = Mathf.Round(sl[6].value *  10)/ 10;	
		}
    //	pm.gravityModifier= new ParticleSystem.MinMaxCurve(sl[6].value/10, sl[7].value/10);
    	tx[6].text = (""+sl[6].value);
    //	tx[7].text = (""+sl[7].value);
    }

    public void ptrl(float f){
    	var sm = prt.shape;
    	if(Input.GetMouseButton(1)){f = Mathf.Round(f / 10)*10;sl[7].value = f;}
    	if(f==0){sm.arcMode = ParticleSystemShapeMultiModeValue.Random;
    	}else{
    	sm.arcMode = ParticleSystemShapeMultiModeValue.Loop;
    	sm.arcSpeed = f/100f;
    	}
    	
    	tx[25].text = (""+(f/100));
    }
    public void sgcc(int n){
    	Gradient grad;
 	    GradientColorKey[] ck;
  		GradientAlphaKey[] al;
  		grad =  new Gradient();
        ck = new GradientColorKey[2];
        ck[0].color = new Color(sl[8].value,sl[9].value,sl[10].value,sl[11].value);
        ck[0].time = 0.0f;
        if(n==0 && Input.GetMouseButton(1)){
        	sl[12].value = sl[8].value;sl[13].value = sl[9].value;sl[14].value = sl[10].value;sl[15].value = sl[11].value;
        }
        if(n==1 && Input.GetMouseButton(1)){
        	sl[8].value = sl[12].value;sl[9].value = sl[13].value;sl[10].value = sl[14].value;sl[11].value = sl[15].value;
        }

        ck[1].color = new Color(sl[12].value,sl[13].value,sl[14].value,sl[15].value);
        ck[1].time = 1.0f;
        al = new GradientAlphaKey[2];
        al[0].alpha = sl[11].value;
        al[0].time = 0.0f;
        al[1].alpha = sl[15].value;
        al[1].time = 1.0f;
       	tx[8].text = (""+sl[8].value);
    	tx[9].text = (""+sl[9].value);
    	tx[10].text = (""+sl[10].value);
    	tx[11].text = (""+sl[11].value);
       	tx[12].text = (""+sl[12].value);
    	tx[13].text = (""+sl[13].value);
    	tx[14].text = (""+sl[14].value);
    	tx[15].text = (""+sl[15].value);
		grad.SetKeys(ck, al);
		var cr = prt.colorOverLifetime;
		cr.color = grad;
		// new ParticleSystem.MinMaxGradient(new Color(sl[8].value,sl[9].value,sl[10].value,sl[11].value),
		//												new Color(sl[12].value,sl[13].value,sl[14].value,sl[15].value));
	}

    public void mdcn(int n){
    	var ps = prt.shape;
    	spc = n;
    	switch(n){
    		case 0:
    		ps.shapeType = ParticleSystemShapeType.Sphere;
    		break;
    		case 1:
    		ps.shapeType = ParticleSystemShapeType.Hemisphere;
    		break;    		
    		case 2:
    		ps.shapeType = ParticleSystemShapeType.Cone;
    		break;
    		case 3:
    		ps.shapeType = ParticleSystemShapeType.Circle;
    		break;
    		case 4:
    		ps.shapeType = ParticleSystemShapeType.Donut;
    		break;
    		case 5:
    		ps.shapeType = ParticleSystemShapeType.Box;
    		break;
    	}
    }
    public void mdmt(int n){
        mtn = n;
        var pr = prt.GetComponent<ParticleSystemRenderer>();
        pr.renderMode = ParticleSystemRenderMode.Billboard;
        switch(n){
            case 0:
            pr.material = mtf[0];
            break;
            case 1:
            pr.material = mtf[1];
            break;          
            case 2:
            pr.material = mtf[2];
            break;
            case 3:
            pr.material = mtf[3];
            break;
            case 4:
            pr.material = mtf[4];
            break;
            case 5:
            pr.material = mtf[5];
            break;

        }
        pr.material.mainTexture = msp[txn];
    }
    public void rads(float f){
    	var ps = prt.shape;
		if(Input.GetMouseButton(1)){sl[16].value = Mathf.Round(f * 10)/10;}
    	ps.radius = f;
    	tx[16].text = (""+sl[16].value);
    }
    public void radk(float f){
    	var ps = prt.shape;
    	if(Input.GetMouseButton(1)){sl[17].value = Mathf.Round(f * 10)/10;}
    	ps.radiusThickness = f;
    	tx[17].text = (""+sl[17].value);
    }
    public void rmps(float f){
    	var ps = prt.shape;
    	if(Input.GetMouseButton(1)){sl[18].value = Mathf.Round(f * 10)/10;}
    	ps.randomPositionAmount = f;
    	tx[18].text = (""+sl[18].value);
    }
    public void rmbr(float f){
        var ps = prt.shape;
        if(Input.GetMouseButton(1)){sl[19].value = Mathf.Round(f * 10)/10;}
        ps.randomDirectionAmount = f;
        tx[19].text = (""+sl[19].value);
    }
    public void rmclcl(float f){
        var ps = prt.main;
        if(Input.GetMouseButton(1)){sl[24].value = sl[25].value;}
        ps.startRotation = new ParticleSystem.MinMaxCurve(sl[24].value, sl[25].value);
        tx[26].text = (Mathf.Round(sl[24].value *100)/100+"-"+Mathf.Round(sl[25].value*100)/100);
    }

    public void noiz(float f){
    	var ps = prt.noise;
    	if(Input.GetMouseButton(1)){sl[20].value = Mathf.Round(f * 10)/10;}
    	if(f!=0){
    	ps.enabled = true;
    	ps.strength = f/10;
    	}else{
    	ps.enabled = false;
    	}
    	tx[20].text = (""+sl[20].value/10);
    }

    public void play(){
    	prt.Clear();
    	prt.Play();
    }
    public void stop(){
    	prt.Clear();
    	prt.Stop();
    }


    public void msin(){
    	if(Input.GetMouseButton(2)){
    	mp = Input.mousePosition;
    	cmp = cmr.transform.eulerAngles;
    	}
    }
    public void msdg(){
    	if(Input.GetMouseButton(2)){
    	Vector2  f = mp - (Vector2)Input.mousePosition;
    	Vector3 v = cmp + new Vector3(-f.y*0.25f,f.x*0.25f,0);
		if(v.x>90 && v.x <180){v.x=90;}
		if(v.x <270 && v.x>180){v.x=270;}
		cmr.transform.eulerAngles = v;
    	}
    	
    }

    public void mscn(int n){
    	if(date.ms[n]!=null){
   		var pr = prt.GetComponent<ParticleSystemRenderer>();
    	pr.renderMode = ParticleSystemRenderMode.Mesh;
    	pr.mesh = date.ms[n];
    	pr.material = date.mt[n];
    	}
    }
   public void msdf(){
   		var pr = prt.GetComponent<ParticleSystemRenderer>();
    	pr.renderMode = ParticleSystemRenderMode.Billboard;
    	pr.material = mtf[mtn];
    }
    public void svcn(int n){
    	svr.localPosition = Vector2.zero;
    	svs = n;
    }
    public void cmbg(int n){
    	switch(n){
    		case 0:
    		cam.backgroundColor = new Color32(103,119,121,255);
    		break;
    		case 1:
    		cam.backgroundColor = new Color32(255,255,255,255);
    		break;
    		case 2:
    		cam.backgroundColor = new Color32(0,0,0,255);
    		break;
    		case 3:
    		cam.backgroundColor = new Color32(185,140,123,255);
    		break;

    	}
    }

    public IEnumerator save(){
		yield return new WaitForSeconds(0);
//		if(svp[svs]!=null){Destroy(svp[svs]);}
//		efc.enabled = true;
//    	svp[svs] = Instantiate(ip,Vector3.zero,Quaternion.identity,svp[30].transform);
//    	date.ps[svs] = svp[svs];
//    	svp[svs].SetActive(false);
//    	efc.enabled = false;
		for(int i=0;i<24;i++){
		date.ps[svs,i] = sl[i].value;
		}
        date.ps[svs,1] = (int)(sl[1].value*sl[1].value*sl[1].value);
		date.ps[svs,25] = 1;
		if(pm.simulationSpace != ParticleSystemSimulationSpace.Local){
			date.ps[svs,26] = 1;
		}else{
			date.ps[svs,26] = -1;
		}
		if(pm.prewarm == true){
		date.ps[svs,27] = 1;
		}else{
		date.ps[svs,27] = -1;
		}
		if(pm.loop == true){
		date.ps[svs,28] = 1;
		}else{
		date.ps[svs,28] = -1;
		}
		date.ps[svs,29] = spc;
        date.ps[svs,30] = mtn;
        date.ps[svs,31] = sl[24].value;
        date.ps[svs,32] = sl[25].value;
        date.ps[svs,33] = txn;
        if(brst){date.ps[svs,34] = 1;}else{
            date.ps[svs,34] = -1;
        }


    	Sprite sp = Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
    	date.pssp[svs] = sp;
		date.pstx[svs] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.pstx[svs]);
		ri[svs].sprite = date.pssp[svs];
    }

    public void locp(){
        if(date.ps[svs,25]>0){
        if(date.ps[svs,34]>0){
            brst=true;
        }else{
            brst=false;
        }
        for(int i=0;i<24;i++){
        sl[i].value = date.ps[svs,i];
        }
        sl[1].value = Mathf.Pow(date.ps[svs,1],0.3334f);
        sl[24].value = date.ps[svs,31];
        sl[25].value = date.ps[svs,32];

        if(date.ps[svs,26] == 1 ){
            mvs(true);
            tg[0].isOn=true;
        }else{
            mvs(false);
            tg[0].isOn=false;
        }
        if(date.ps[svs,27] == 1 ){
            mpr(true);
            tg[1].isOn=true;
        }else{
            mpr(false);
            tg[1].isOn=false;
        }
        if(date.ps[svs,28] == 1 ){
            mlop(true);
            tg[2].isOn=true;
        }else{
            mlop(false);
            tg[2].isOn=false;
        }
        mdcn((int)date.ps[svs,29]);
        mdmt((int)date.ps[svs,30]);
        mtch((int)date.ps[svs,33]);
        }
    }
    public void lest(){

    }
    public void del(){
    	ri[svs].sprite = null;
    	date.pssp[svs] = null;
    	date.pstx[svs] = null;
    	date.ps[svs,25] = -1;
    }
    public void spin(){
        for(int i=0;i<30;i++){
            if(date.pssp!=null){
                ri[i].sprite = date.pssp[i];
            }
        }
        ip.transform.position = Vector3.zero;
        cmr.transform.position = Vector3.zero;
    }
}
