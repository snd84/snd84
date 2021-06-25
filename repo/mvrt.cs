using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mvrt : MonoBehaviour
{

	public Slider[] sl = new Slider[5];
	int cs = 0;
	int obc = 0;
	int k=0;
	float ft =0;
	int fc=1;
	int fp=0;
	int sv=0;
	int type=0;
	int[,] setc = new int[5,100];
	Vector3[,] vp = new Vector3[5,100];
	int[] vs = new int[5];
	int[] mn = new int[5];

	Vector3[,] vr = new Vector3[5,100];
	Vector2 vk;
	Vector3 vtn;
	public Text[] tx = new Text[20];
	public GameObject[] gt = new GameObject[10];
	public RectTransform[] rt = new RectTransform[10];
	public Mesh[] ms = new Mesh[10];
	public MeshRenderer[] mr = new MeshRenderer[5];
    public MeshFilter[] mf = new MeshFilter[5];
    Vector3 mp;
    Vector3 gp;
    Vector3 gr;
    Vector3 cr;　
    public Image[] sp = new Image[5];
    Color con = new Color(0.7f,1f,0.2f,0.4f);
    Color cof = new Color(0.21f,0.21f,0.21f,0.4f);
    int anm = 0;
    int[] acf = new int[5];
    int[] act = new int[5];
    int ls=0;
    float cmft = 130;
    bool bm = true;
  //  public Rigidbody[] rbs = new Rigidbody[5];
    public GameObject cag;
    public GameObject cam;
    public GameObject mvp;
    List<GameObject> gmp1 = new List<GameObject>();
    List<GameObject> gmp2 = new List<GameObject>();
    List<GameObject> gmp3 = new List<GameObject>();
    List<GameObject> gmp4 = new List<GameObject>();
    List<GameObject> gmp5 = new List<GameObject>();
    public Image[] vqi = new Image[20];
	public GameObject[] vqs = new GameObject[20];
    public GameObject  smp;
    // Start is called before the first frame update
    void Start()
    {
    cs=0;
	obc=0;
	ls=0;
	ft=0;
	fc=1;
	fp=0;
	anm=0;
	setc = new int[5,100];
	vp = new Vector3[5,100];
	vs = new int[5];
	mn = new int[5];
	vr = new Vector3[5,100];
	acf = new int[5];
    act = new int[5];
    for(k=0;gmp1.Count>k;k++){
    	Destroy(gmp1[k]);
    }
    gmp1.Clear();
    for(k=0;gmp2.Count>k;k++){
    	Destroy(gmp2[k]);
    }
    gmp2.Clear();
    for(k=0;gmp3.Count>k;k++){
    	Destroy(gmp3[k]);
    }
    gmp3.Clear();
    for(k=0;gmp4.Count>k;k++){
    	Destroy(gmp4[k]);
    }
    gmp4.Clear();
    for(k=0;gmp5.Count>k;k++){
    	Destroy(gmp5[k]);
    }
    gmp5.Clear();
    gp.x = (gt[cs].transform.localScale.x/gt[cs].transform.lossyScale.x)*gt[cs].transform.lossyScale.x;
    gp.y = (gt[cs].transform.localScale.y/gt[cs].transform.lossyScale.y)*gt[cs].transform.lossyScale.y;
    gp.z = (gt[cs].transform.localScale.z/gt[cs].transform.lossyScale.z)*gt[cs].transform.lossyScale.z;

	for(k=0;k<5;k++){
	mn[k]=-1;
	tx[k+24].text = null;
	sl[k].maxValue = 100;
	sl[k].value = 100;
	sl[k+5].maxValue = 0;
	sl[k+5].value = 0;
	mf[k].mesh = null;
	gt[k].SetActive(false);
	gt[k+5].SetActive(false);
	gt[k].transform.position = gp;
	}
	gt[0].SetActive(true);
	gt[5].SetActive(true);
	css(0);
	anm=0;
    }

    public void chkl(){
    	gt[10].transform.position =　new Vector3(140,0,140);
    	gp.x = (gt[10].transform.localScale.x/gt[10].transform.lossyScale.x)*28;
    	gp.y = (gt[10].transform.localScale.y/gt[10].transform.lossyScale.y)*28;
    	gp.z = (gt[10].transform.localScale.z/gt[10].transform.lossyScale.z)*28;
    	gt[10].transform.localScale = gp;

    }
    // Update is called once per frame
    void Update()
    {
    	if(anm==1){
    		for(k=0;k<5;k++){
    		acf[k]=1;
        	act[k]=0;
        	gt[k].transform.position = vp[k,0];
        	gt[k].transform.eulerAngles = vr[k,0];
        	}
        	
        	anm=2;
    	}
        if(anm==2){


        	for(k=0;k<5;k++){
        	if(gt[k].activeSelf){

        		if(setc[k,acf[k]]>act[k]){
        		gt[k].transform.position += (vp[k,acf[k]]-vp[k,acf[k]-1])/(float)setc[k,acf[k]];
        		gp = vr[k,acf[k]-1] + (((vr[k,acf[k]]-vr[k,acf[k]-1])/(float)setc[k,acf[k]])*(act[k]+1));
        		gt[k].transform.eulerAngles = gp;
        		act[k]++;
        	//	print(acf1+","+act1);
        	//	print(vp[acf1,act1]);
        	//	print(setc[0,acf1]);
        		}else{
        			acf[k]++;
        			act[k]=0;
        			if(setc[k,acf[k]]==0){
        				acf[k]=1;
        				gt[k].transform.position = vp[k,0];
        				gt[k].transform.eulerAngles = vr[k,0];
        			}

        		}
        	}
        }
            sl[13].value = gt[cs].transform.eulerAngles.x;
            sl[14].value = gt[cs].transform.eulerAngles.y;
            sl[15].value = gt[cs].transform.eulerAngles.z;
        }

        if(anm==3){
    		for(k=0;k<5;k++){
    		acf[k]=1;
        	act[k]=0;
        	gt[k].transform.position = vp[k,(int)sl[k+5].value];
        	gt[k].transform.eulerAngles = vr[k,(int)sl[k+5].value];
        	cspt(sl[cs+5].value);
        	}
        	anm=0;
        }

	if(Input.GetButton("Vertical")){
		cag.transform.position += (cag.transform.forward*Input.GetAxis("Vertical")*5);
		cag.transform.position = new Vector3(cag.transform.position.x,cmft,cag.transform.position.z);
		if(cag.transform.position.z<-50){cag.transform.position = new Vector3(cag.transform.position.x,cmft,-50);}
		if(cag.transform.position.z>290){cag.transform.position = new Vector3(cag.transform.position.x,cmft,290);}
		if(cag.transform.position.x<-50){cag.transform.position = new Vector3(-50,cmft,cag.transform.position.z);}
		if(cag.transform.position.x>290){cag.transform.position = new Vector3(290,cmft,cag.transform.position.z);}
	}
	if(Input.GetButton("Horizontal")){
		cag.transform.position += (cag.transform.right*Input.GetAxis("Horizontal")*5);
		cag.transform.position = new Vector3(cag.transform.position.x,cmft,cag.transform.position.z);
		if(cag.transform.position.z<-50){cag.transform.position = new Vector3(cag.transform.position.x,cmft,-50);}
		if(cag.transform.position.z>290){cag.transform.position = new Vector3(cag.transform.position.x,cmft,290);}
		if(cag.transform.position.x<-50){cag.transform.position = new Vector3(-50,cmft,cag.transform.position.z);}
		if(cag.transform.position.x>290){cag.transform.position = new Vector3(290,cmft,cag.transform.position.z);}
	}
    }
    public void anmo(){
    	anm=1;
    }
    public void anmf(){
    	anm=3;
    }
    public void typc(int i){
    	type = i;
    }
    public void pls(int i){
    	if(Input.GetMouseButton(0)){
    	sl[cs].maxValue+=i;
    	if(sl[cs].maxValue>=1000){
    		sl[cs].maxValue = 1000;
    	}
    	if(sl[cs].maxValue<10){
    		sl[cs].maxValue = 11;
    	}
    	tx[10 + cs].text = (sl[cs].value + "/" + sl[cs].maxValue);
    	}
    }
    public void plsct(){
    	sl[cs].maxValue = sl[cs].value;
    	tx[10 + cs].text = (sl[cs].value + "/" + sl[cs].maxValue);
    }
    public void vqsp(){
    	for(int i=0;i<20;i++){
    		if(date.vq[i]!=null){
    		sp[i+5].sprite = date.vqsp[i];
    		}
    	}

    }

    public void msin(int i){
    	mf[cs].mesh = ms[i];
    	gt[cs].SetActive(true);
    	mn[cs]=i+1;
    	tx[cs+24].text = (""+(i+1));
    }

    public void objp(){
    	if(obc<4){
    	obc++;
    	gt[5+obc].SetActive(true);
    	mn[obc] = -1;
    	}
    }
    public void objm(){
    	if(obc>0){
    	gt[5+obc].SetActive(false);
    	gt[obc].SetActive(true);
    	mf[obc].mesh = null;
    	obc--;
    	if(obc<cs){css(obc);}
    	}
    }
    public void css(int i){
        if(i!=cs){
            if(ls<stb(cs).Count){stb(cs)[ls].transform.localScale = new Vector3(0.2f,0.2f,0.2f);}
        }
    	sp[cs].color = cof;
    	cs = i;
    	sp[cs].color = con;
    }
    public void cssa(int i){
    	if(anm==0){
    	sp[cs].color = cof;
    	cs = i;
    	sp[cs].color = con;
    	tx[10 + cs].text = (sl[cs].value + "/" + sl[cs].maxValue);
    	}
    //	if(setc[cs]>=(int)sl[cs].value){
    //		gt[cs].transform.position = vp[cs,(int)sl[cs].value];
    //	}
    }    
    public void colm(){
    	mr[cs].material.color = new Color(sl[10].value,sl[11].value,sl[12].value);
    }
    public void musp(){
    	mp = Input.mousePosition;
    	gp = gt[cs].transform.position;
    	gr = gt[cs].transform.eulerAngles;
    	cr = cag.transform.eulerAngles;
    }
    public void mvps(){
    	if(anm==0){
    	vk = Input.mousePosition;
		Vector3[] v = new Vector3[4];
		rt[0].GetWorldCorners(v);
		vk.x = ((vk.x-v[0].x)/rt[0].transform.lossyScale.x)*0.7877f;
		vk.y = ((vk.y-v[0].y)/rt[0].transform.lossyScale.x)*0.7877f;
		if(bm){
    	if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
		Ray ray = cam.GetComponent<Camera>().ScreenPointToRay(vk);
		RaycastHit rh;
			if(Physics.Raycast(ray,out rh,Mathf.Infinity,512)){
    		gt[cs].transform.position = rh.point + new Vector3(0,ft,0);
    		vtn = gt[cs].transform.position;
    		if(fp==2){vtn.x = Mathf.Round(vtn.x*0.2f)*5f;vtn.y = Mathf.Round(vtn.y*0.2f)*5f;vtn.z = Mathf.Round(vtn.z*0.2f)*5f;}
    		if(fp==1){vtn.x = Mathf.Round(vtn.x); Mathf.Round(vtn.y);vtn.z = Mathf.Round(vtn.z);}
    		gt[cs].transform.position = vtn;
    		}
    	}
	   	if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
	   	vk = Input.mousePosition - mp;
    	ft = gp.y + vk.y*0.05f;
    	gt[cs].transform.position = new Vector3(gt[cs].transform.position.x,ft,gt[cs].transform.position.z);
    	}
    	}else{
    		vk = Input.mousePosition - mp;
    		if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
    			/*
    			gt[cs].transform.rotation = Quaternion.Euler(gr.x+(vk.x *0.5f),gr.y,gr.z+(vk.y *-0.5f));	
    			vtn = gt[cs].transform.eulerAngles;
    			vtn.x = Mathf.Round(vtn.x/fc)*fc;
    			vtn.y = Mathf.Round(vtn.y/fc)*fc;
    			vtn.z = Mathf.Round(vtn.z/fc)*fc;
    			gt[cs].transform.eulerAngles = vtn;
    			*/
    			gt[cs].transform.eulerAngles = gr;
    			if(fc!=0){gt[cs].transform.Rotate(Vector3.up*(int)((vk.x/fc)*fc),Space.World);
    				}else{
    					gt[cs].transform.Rotate(Vector3.up*vk.x,Space.World);
    				}
    			//gt[cs].transform.Rotate(Vector3.right*vk.y,Space.World);
    		}
    		if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
    			//gt[cs].transform.rotation = Quaternion.Euler(gr.x+(vk.x *0.1f),gr.y,gr.z+(vk.y *-0.1f));	
    			gt[cs].transform.eulerAngles = gr;
    		if(fc!=0){gt[cs].transform.Rotate(Vector3.right*(int)((vk.y/fc)*fc),Space.World);
    			}else{
    				gt[cs].transform.Rotate(Vector3.right*vk.y,Space.World);
    			}
//    			gt[cs].transform.Rotate(Vector3.forward*vk.x,Space.World);
    		}
    		if(Input.GetMouseButton(0) && Input.GetMouseButton(1)){
//    			gt[cs].transform.eulerAngles = gr + new Vector3(0,vk.x,0);
  //  			gt[cs].transform.eulerAngles = gr;
//    			gt[cs].transform.Rotate(Vector3.forward*vk.x,Space.World);
    		}

    	}
    	}
    	if(Input.GetMouseButton(2)){
    	vk = Input.mousePosition - mp;
		Vector3 vq = cr + new Vector3(vk.y*0.25f,-vk.x*0.15f,0);
			if(vq.x>90 && vq.x <180){vq.x=90;}
			if(vq.x <270 && vq.x>180){vq.x=270;}
		cag.transform.eulerAngles = vq;
    	}
    }
    public void cmsc(){
    	if(Input.mouseScrollDelta.y!=0){
			cam.transform.localPosition += new Vector3(0,0,Input.mouseScrollDelta.y*0.1f);
			if(cam.transform.localPosition.z > 2f){ cam.transform.localPosition = new Vector3(0,0,2f);}
			if(cam.transform.localPosition.z < -5){ cam.transform.localPosition = new Vector3(0,0,-5f);}
    	}
    }
    public void mvrn(int n){
    	if(anm==0 && bm){
   			if(Input.GetMouseButton(1)){
   				switch(n){
	   			case 0:sl[13].value = Mathf.Round(sl[13].value/45)*45f;break;
	    		case 1:sl[14].value = Mathf.Round(sl[14].value/45)*45f;break;
    			case 2:sl[15].value = Mathf.Round(sl[15].value/45)*45f;break;
    			}
    		}
    	gt[cs].transform.eulerAngles = new Vector3(sl[13].value,sl[14].value,sl[15].value);
    	
    	}
    }
    /*
    public void stly(){
    	int tt = (int)(sl[cs].value - setc[cs]);
    	Vector3 vv = (vp[cs,(int)sl[cs].value] - gt[cs].transform.position)/(float)tt;
    	for(int i=0;i<tt;i++){
    		vp[cs,setc[cs] + i] = vv * i;
    	}
    	vp[cs,(int)sl[cs].value] = gt[cs].transform.position;

    	vv = ( vr[cs,(int)sl[cs].value] - gt[cs].transform.eulerAngles) / (float)tt;
    	for(int i=0;i<tt;i++){
    		vp[cs,setc[cs] + i] = vv * i;
    	}
    	vr[cs,(int)sl[cs].value] = gt[cs].transform.eulerAngles;

    	setc[cs] = (int)sl[cs].value;
    }
	*/
	public void cspt(float f){
		if(anm==0&&gt[cs].activeSelf){
   			if(f<stb(cs).Count){
   			if(ls<stb(cs).Count){stb(cs)[ls].transform.localScale = new Vector3(0.2f,0.2f,0.2f);}
   			stb(cs)[(int)f].transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    		ls = (int)f;
   			if(f!=0){sl[0].value = setc[cs,(int)f];}
   			gt[cs].transform.position = vp[cs,(int)f];
   			gt[cs].transform.eulerAngles = vr[cs,(int)f];
   			}
   			tx[cs + 15].text = (""+f);
   			sl[13].value = vr[cs,(int)f].x;
			sl[14].value = vr[cs,(int)f].y;
			sl[15].value = vr[cs,(int)f].z;
    	}

	}
	public void cnms(bool b){
		if(!bm && !b){
			switch(fc){
				case 1:fc=15;break;
				case 15:fc=45;break;
				case 45:fc=1;break;
			}
			tx[9].text = (""+fc);
		}
		if(bm && b){
			switch(fp){
				case 0:fp=1;tx[20].text = ("1");break;
				case 1:fp=2;tx[20].text = ("5");break;
				case 2:fp=0;tx[20].text = ("0");break;
			}
			
		}

		bm = b;
		
	}
    public void stlyp(){
    	if(anm==0&&gt[cs].activeInHierarchy){
    		if(stb(cs).Count<100 && stb(cs).Count == (int)sl[cs+5].value){
	    	stb(cs).Add(Instantiate(mvp,gt[cs].transform.position,gt[cs].transform.rotation,transform));
//	    	stb(cs)[stb(cs).Count-1].transform.position += Vector3.up;
            ls = stb(cs).Count;
	    	if((int)sl[cs+5].value!=0){
	    	stb(cs)[stb(cs).Count-1].GetComponent<TextMesh>().text = ((cs+1)+",P"+(stb(cs).Count-1)+","+sl[cs].value);
	    	}else{
    		stb(cs)[stb(cs).Count-1].GetComponent<TextMesh>().text = ((cs+1)+",P"+(stb(cs).Count-1)+","+0);
	    	}
	    	stb(cs)[stb(cs).Count-1].SetActive(true);
	    	if(stb(cs).Count>=2){
	    //	vp[cs,gmp1.Count-1] = (gmp1[gmp1.Count-1].transform.position - gmp1[gmp1.Count-2].transform.position)/(sl[cs].value+1f);
	   		vp[cs,stb(cs).Count-1] =  gt[cs].transform.position;
	   		vr[cs,stb(cs).Count-1] = new Vector3(sl[13].value,sl[14].value,sl[15].value);//gt[cs].transform.eulerAngles;
/*	   		
	   		if(vr[cs,stb(cs).Count-1].x>180){vr[cs,stb(cs).Count-1].x-=360;}
	   		if(vr[cs,stb(cs).Count-1].x<-180){vr[cs,stb(cs).Count-1].x+=360;}
	 		if(vr[cs,stb(cs).Count-1].y>180){vr[cs,stb(cs).Count-1].y-=360;}
	   		if(vr[cs,stb(cs).Count-1].y<-180){vr[cs,stb(cs).Count-1].y+=360;}
	   		if(vr[cs,stb(cs).Count-1].z>180){vr[cs,stb(cs).Count-1].z-=360;}
	   		if(vr[cs,stb(cs).Count-1].z<-180){vr[cs,stb(cs).Count-1].z+=360;}
*/
		    setc[cs,stb(cs).Count-1] = (int)sl[cs].value;
		    stb(cs)[stb(cs).Count-2].transform.localScale = new Vector3(0.2f,0.2f,0.2f);
	    	}else{
	    		vp[cs,0] = stb(cs)[0].transform.position;
	    		vr[cs,0] = new Vector3(sl[13].value,sl[14].value,sl[15].value);
	    		setc[cs,0] = 0;
		    	}
		    sl[cs+5].maxValue++;
	    	sl[cs+5].value++;
	    	vs[cs] = (int)sl[cs+5].maxValue;
    		gt[cs].transform.position = stb(cs)[stb(cs).Count-1].transform.position;
    		gt[cs].transform.eulerAngles = stb(cs)[stb(cs).Count-1].transform.eulerAngles;

	    	}else if(stb(cs).Count<100 && (int)sl[cs+5].value < stb(cs).Count){
	    		stb(cs)[(int)sl[cs+5].value].transform.position = gt[cs].transform.position + new Vector3(0,5,0);
	    		stb(cs)[(int)sl[cs+5].value].transform.rotation = gt[cs].transform.rotation;
	    		vp[cs,(int)sl[cs+5].value] = gt[cs].transform.position;
		   		vr[cs,(int)sl[cs+5].value] = new Vector3(sl[13].value,sl[14].value,sl[15].value);// gt[cs].transform.eulerAngles;
/*
		   		if(vr[cs,(int)sl[cs+5].value].x>180){vr[cs,(int)sl[cs+5].value].x-=360;}
		   		if(vr[cs,(int)sl[cs+5].value].x<-180){vr[cs,(int)sl[cs+5].value].x+=360;}
	   			if(vr[cs,(int)sl[cs+5].value].y>180){vr[cs,(int)sl[cs+5].value].y-=360;}
	   			if(vr[cs,(int)sl[cs+5].value].y<-180){vr[cs,(int)sl[cs+5].value].y+=360;}
	   			if(vr[cs,(int)sl[cs+5].value].z>180){vr[cs,(int)sl[cs+5].value].z-=360;}
	   			if(vr[cs,(int)sl[cs+5].value].z<-180){vr[cs,(int)sl[cs+5].value].z+=360;}
*/
		   		if((int)sl[cs+5].value!=0){setc[cs,(int)sl[cs+5].value] = (int)sl[cs].value;}
		   		stb(cs)[(int)sl[cs+5].value].GetComponent<TextMesh>().text = ((cs+1)+",P"+((int)sl[cs+5].value)+","+(int)sl[cs].value);
	    	}
	    	//cspt(sl[cs+5].value);
    	}
    }
    List<GameObject> stb(int i){
    	switch(i){
    		case 0:
    		return gmp1;
    		case 1:
    		return gmp2;
    		case 2:
    		return gmp3;
    		case 3:
    		return gmp4;
    		case 4:
    		return gmp5;

    		default: return null;
    	}
    }
    public void delp(){
    	if(anm==0&&gt[cs].activeSelf){
    		int ci = (int)sl[cs+5].value;
    		if(ci!=0){
    		if(stb(cs).Count>ci){
    		Destroy(stb(cs)[ci]);
    		stb(cs).RemoveAt(ci);

    		for(k=ci;k<stb(cs).Count;k++){
    			vp[cs,k] = vp[cs,k+1];
    			setc[cs,k] = setc[cs,k+1];
    			stb(cs)[k].GetComponent<TextMesh>().text = ((cs+1)+",P"+k+","+setc[cs,k]);
    		}
    		setc[cs,k] = 0;
		    sl[cs+5].maxValue--;
	    	sl[cs+5].value=0;
            vs[cs] = (int)sl[cs+5].maxValue;
		    }
			}
		}
	}
	public void lcsp(){
    	mp = Input.mousePosition;
    	gp.x = (gt[cs].transform.localScale.x/gt[cs].transform.lossyScale.x)*gt[cs].transform.lossyScale.x;
    	gp.y = (gt[cs].transform.localScale.y/gt[cs].transform.lossyScale.y)*gt[cs].transform.lossyScale.y;
    	gp.z = (gt[cs].transform.localScale.z/gt[cs].transform.lossyScale.z)*gt[cs].transform.lossyScale.z;

    }
	public void lcsc(int i){
		Vector2 vc = Input.mousePosition - mp;
		switch(i){
			case 0:
			gt[cs].transform.localScale = new Vector3(gp.x+(vc.x*0.001f),gp.y,gp.z);
			if(gt[cs].transform.lossyScale.x<0.1f){
				gt[cs].transform.localScale = new Vector3((gt[cs].transform.localScale.x/gt[cs].transform.lossyScale.x) * 0.1f,gp.y,gp.z);
			}

			break;
			case 1:
			gt[cs].transform.localScale = new Vector3(gp.x,gp.y+(vc.x*0.001f),gp.z);
			if(gt[cs].transform.lossyScale.y<0.1f){
				gt[cs].transform.localScale = new Vector3(gp.x,(gt[cs].transform.localScale.y/gt[cs].transform.lossyScale.y) * 0.1f,gp.z);
			}
			break;
			case 2:
			gt[cs].transform.localScale = new Vector3(gp.x,gp.y,gp.z+(vc.x*0.001f));
			if(gt[cs].transform.lossyScale.z<0.1f){
				gt[cs].transform.localScale = new Vector3(gp.x,gp.y,(gt[cs].transform.localScale.z/gt[cs].transform.lossyScale.z) * 0.1f);
			}

			break;
		}
	}
	public void lspr(){
		tx[21].text = ("x:"+(Mathf.Round(gt[cs].transform.lossyScale.x*100f)*0.01f));
		tx[22].text = ("y:"+(Mathf.Round(gt[cs].transform.lossyScale.y*100f)*0.01f));
		tx[23].text = ("z:"+(Mathf.Round(gt[cs].transform.lossyScale.z*100f)*0.01f));
	}
	public void svc(int n){
		sv=n;
		rt[1].anchoredPosition = Vector2.zero;
	}
	public IEnumerator save(){
		bool ys=false;
		for(int i=0;i<=obc;i++){
			if(mn[i]>0){ys=true;}else{ys=false;break;}
			if(vs[i]>1){ys=true;}else{ys=false;break;}
		}
		if(ys){
		yield return new WaitForSeconds(0);
		date.vq[sv] = vqs[sv];
		date.vqsp[sv] =  Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		vqi[sv].sprite = date.vqsp[sv];
		date.vqtx[sv] = new Texture2D(50,50,TextureFormat.RGB24,false);
		Graphics.CopyTexture(date.rw,date.vqtx[sv]);
		vqs[sv].GetComponent<vlocs>().dtin(obc,setc,vp,vr,vs,type);
		vqs[sv].GetComponent<vlocs>().msin(obc,mf,mr,gt,mn);
		Start();
		}
	}
	public void load(){
		Start();
		if(date.vq[sv]!=null){
			vlocs vl = date.vq[sv].GetComponent<vlocs>();
			obc = vl.ous()-1;
			for(int i=0;obc>=i;i++){
				cs=i;
               
				msin(vl.oumm()[i]-1);
				gp = vl.ovp(i)[0];
				gr = vl.ovr(i)[0];
				vp[i,0] = gp;
				vr[i,0] = gr;
				stb(i).Add(Instantiate(mvp,gp,Quaternion.Euler(gr),transform));
				stb(i)[0].GetComponent<TextMesh>().text = (1+",P"+1+","+0);
				stb(i)[0].SetActive(true);
				for(int l=1;l<vl.ovt(i).Length;l++){
					setc[i,l] = vl.ovt(i)[l];
					gp = vl.ovp(i)[l];
					gr = vl.ovr(i)[l];//*vl.ovt(i)[l];
					stb(i).Add(Instantiate(mvp,gp + new Vector3(0,5,0),Quaternion.identity,transform));
					stb(i)[l].transform.eulerAngles = gr;
					stb(i)[l].GetComponent<TextMesh>().text = ((i+1)+",P"+l+","+vl.ovt(i)[l]);
					stb(i)[l].SetActive(true);
					vp[i,l] = gp;//stb(i)[l].transform.position;
					vr[i,l] = gr;//stb(i)[l].transform.eulerAngles;
				}
				sl[i+5].maxValue = vl.ovt(i).Length;
				vs[i] = vl.ovt(i).Length;
				gt[i].transform.localScale = new Vector3((gt[i].transform.localScale.x/gt[i].transform.lossyScale.x) * vl.osz()[i].x,
														 (gt[i].transform.localScale.y/gt[i].transform.lossyScale.y) * vl.osz()[i].y,
														 (gt[i].transform.localScale.z/gt[i].transform.lossyScale.z) * vl.osz()[i].z);
				mr[i].material.color = vl.ocl()[i];
				gt[i+5].SetActive(true);
			}
		}
	}
}
