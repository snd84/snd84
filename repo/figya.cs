using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class figya : MonoBehaviour {
public Button[] gb = new Button[2];
public Slider[] sl = new Slider[20];
public Text[] tx = new Text[12];
public Image[] im = new Image[6];
public Sprite[] sp = new Sprite[4];
public Toggle[] tg = new Toggle[1];
public Image[] scj = new Image[24];
public Image[] sit = new Image[40];
bool[,] bk = new bool[141,141];

public RectTransform mvs;
public RectTransform[] pn = new RectTransform[5];
public GameObject cb;
public GameObject cbx;
public GameObject csp;

public Camera cmr;
public GameObject tcm;

public RectTransform fw;
public RawImage ri;
Texture2D wtx;

int[] st = new int[100];

GameObject rby;
GameObject amst;
GameObject[] asy;
int sjn=0;

int nb;
int i;
Vector2 mp;
Vector2 mvp = Vector2.zero;
Vector3 vvp;
rovoko rb;
//BoxCollider bcl;
//CapsuleCollider bcl;

bool onb=false;
public Rigidbody2D rgd;
public RectTransform gnp;
public RectTransform enc;
int ct=0;
int gr=0;
int gmx=0;
//public GameObject[] dng =new GameObject[100];
public AudioClip[] ac;
public RectTransform rcc;
public AudioSource au;
int cc;
public Button[] rdv =new Button[50]; 
public Text[] otx = new Text[12];
public Mesh[] mes = new Mesh[3];
bool bys = true;
//int amn = 0;
//int cldc;
	// Use this for initialization
	void Start () {

	}
	void Update () {
		if(sjn==2){// && onb){
			if(gnp.anchoredPosition.x>=400){
			gnp.anchoredPosition = new Vector2(0,35);
			rgd.velocity = Vector2.zero;
			}
			if((enc.anchoredPosition.x*0.25f)<st[53]){
			if(gr>0){gr--;}
			if(gr<=0){
			gnp.anchoredPosition = new Vector2(0,35);
			rgd.velocity = Vector2.zero;
			ct=0;
			}
			if(ct==0){
				if(gmx>0){gmx--;rgd.AddForce(new Vector2(10000,0));ct=1;gr=(int)sl[2].value;
				}else{gmx=(int)sl[3].value;ct=1;gr=(int)(sl[4].value*sl[4].value);}
			}
			
			tx[25].text = (gmx+"\n"+gr);
			}
		}
	}
	public void enpt(){
	mp = Input.mousePosition;
	mvp = enc.anchoredPosition;
	}
	public void enpm(){
	Vector2 v = ((Vector2)Input.mousePosition - mp);
	enc.anchoredPosition = mvp + new Vector2(v.x,0);
	if(enc.anchoredPosition.x<0){enc.anchoredPosition = new Vector2(0,35);}
	if(enc.anchoredPosition.x>400){enc.anchoredPosition = new Vector2(400,35);}

	}
	public void acof(float n){
		au.clip = ac[(int)n];
		au.Stop();
		au.Play();
		otx[12].text = (""+n);
	}
	public void acoi(int n){
		if(date.ac[n]!=null){
		au.clip = date.ac[n];
		au.Stop();
		au.Play();
		}
		otx[12].text = ("rec"+n);
	}
	public void onot(){
		if(rby!=null){
		rb.inot(au.clip,au.volume,cc);
		otx[cc].text = (""+otx[12].text);
		}
	}
	public void offt(){
		if(rby!=null){
		rb.inot(null,0,cc);
		otx[cc].text = ("-");
		}
	}
	public void acbt(int n){
		sl[19].value += n;
	}
	public void swdc(int n){
		rcc.localPosition = Vector2.zero;
		cc=n;
		if(rb!=null && rb.ouot(n)!=null){
			au.clip = rb.ouot(n);
				au.Stop();
				au.Play();
		}
	}
	public void sprb(){
		cbx.transform.position = new Vector3(0,0,0);
		cmr.transform.position = new Vector3(0,0,-5);

		cb.transform.position = Vector3.zero;
		tcm.transform.position = new Vector3(140,280,140);

		for(i=0;i<20;i++){
			if(date.rb[i]!=null){
				sit[i].sprite = date.rbsp[i];
			}else{
				sit[i].sprite = null;
			}
			if(date.it[i]!=null){
				sit[20+i].sprite = date.itsp[i];
			}else{
				sit[20+i].sprite = null;
			}
		}
		for(i=0;i<50;i++){
			if(date.ac[i]!=null){
				rdv[i].interactable = true;
			}else{
				rdv[i].interactable = false;
			}
		}
	}

	public void chos(int n){
		if(date.rb[n]!=null){
		Destroy(rby);
		im[5].sprite = date.rbsp[n];
		rby = Instantiate(date.rb[n],Vector3.zero,Quaternion.identity,transform);
		rby.SetActive(true);
		rby.transform.localScale = Vector3.one * (rby.transform.lossyScale.x/rby.transform.localScale.x);
		Transform[] cp = rby.GetComponentsInChildren<Transform>();
		foreach(Transform cl in cp){
			cl.gameObject.layer = 9;
		}
		rb = date.rb[n].GetComponent<rovoko>();
		//bcl = date.rb[n].GetComponent<CapsuleCollider>();
		//cb.transform.position = bcl.center;
		//cb.transform.localScale = new Vector3(bcl.radius*2,bcl.height/2,bcl.radius*2);

		cmr.transform.position = new Vector3(0,0,-5);
//		cldc = rby.GetComponent<rovoko>().oub();
//		cldc--;
//		asy = new GameObject[cldc];
//		asy = rby.GetComponent<rovoko>().ougc();
		Destroy(rby.GetComponent<Rigidbody>());
		Destroy(rby.GetComponent<rovoko>());
		settu();
		}
		
	}
	public void settu(){
		st = rb.sit();
		sl[0].value = Mathf.Sqrt((float)st[4]/((float)st[68]*0.005f));
		sl[1].value = st[9];
		sl[2].value = st[10];
		sl[3].value = st[11];
		sl[4].value = Mathf.Sqrt(st[12]);
		sl[5].value = Mathf.Sqrt((float)st[13]/((float)st[68]*0.005f));
		sl[6].value = st[14];
		sl[7].value = st[15];
		sl[8].value = st[60];
		sl[9].value = st[59];
		sl[10].value = st[18];
		sl[11].value = st[17];
		sl[12].value = st[61];
		sl[13].value = st[50];
		sl[14].value = st[52];
		sl[15].value = st[51];
		sl[16].value = st[62];
		sl[17].value = st[53];
		sl[20].value = st[68]*0.1f;
		sl[21].value = st[65];
		sl[22].value = st[66];
		sl[23].maxValue = rb.oub();

		for(i=0;i<24;i++){
			switch(st[20+i]){
			case 0:
			scj[i].color = new Color(0.5f,0.5f,1f,0.5f);
			break;
			case 1:
			scj[i].color = new Color(0.5f,1f,0.5f,0.5f);
			break;
			case 2:
			scj[i].color = new Color(1f,0.5f,0.5f,0.5f);
			break;
			case 3:
			scj[i].color = new Color(1f,1f,0.5f,0.5f);
			break;
			}
		}
		switch(st[5]){
		case 0:
		im[0].color = Color.red;
		break;
		case 1:
		im[0].color = Color.blue;
		break;
		case 2:
		im[0].color = Color.green;
		break;
		}
		switch(st[6]){
		case 0:
		im[1].sprite = sp[0];
		break;
		case 1:
		im[1].sprite = sp[1];
		break;
		case 2:
		im[1].sprite = sp[2];
		break;
		}
		switch(st[7]){
		case 0:
		im[2].sprite = sp[0];
		break;
		case 1:
		im[2].sprite = sp[1];
		break;
		case 2:
		im[2].sprite = sp[2];
		break;
		}
		switch(st[8]){
		case 0:
		im[3].sprite = sp[0];
		break;
		case 1:
		im[3].sprite = sp[1];
		break;
		case 2:
		im[3].sprite = sp[2];
		break;
		}
		gnkn(st[54]);
		b58(st[58]);
		b63(st[63]);
		if(st[56]>0){tx[18].text = (st[56]*0.1f+","+st[57]*0.1f);}else if(st[56]<0){tx[18].text = ("-");}
		for(int i=0;i<12;i++){
			if(rb.ouot(i)!=null){
			otx[i].text = ("+");}else{
				otx[i].text = ("-");
			}
		}

/*
		if(st[17]==0){
		tg[0].isOn = true;
		gb[0].interactable=false;
		gb[1].interactable=false;
		}else{
		tg[0].isOn = false;
		gb[0].interactable=true;
		gb[1].interactable=true;
		}
		if(st[18]==0){
		pn[4].transform.SetParent(gb[0].transform);
		pn[4].anchoredPosition = Vector2.zero;	
		}else{
		pn[4].transform.SetParent(gb[1].transform);
		pn[4].anchoredPosition = Vector2.zero;	
		}
*/
		//mvs.sizeDelta = new Vector2(st[1]-st[0],st[3]-st[2]);
		//mvs.anchoredPosition = new Vector2((st[0]+st[1])/2f,(st[2]+st[3])/2f);
		bk = rb.ouwk();
		Color[] c = new Color[141*141];
		Color r = new Color(0,0,0.5f,0.25f);
		Color m = new Color(0,0,0,0f);
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
				if(bk[i,j]){
					c[(j*141)+i] = r;
				}else{
					c[(j*141)+i] = m;
				}
			}
		}
		wtx = new Texture2D(141,141);
		wtx.SetPixels(c);
		wtx.Apply();
		ri.color = new Color(1,1,1,1);
		ri.texture = wtx;
		onb = true;
	}
	public void rcd(){
		Destroy(rby);
		cb.transform.position = Vector3.zero;
		cb.transform.localScale = Vector3.one;
		rb = null;
	//	bcl = null;
		st = new int[100];
		im[4].sprite = sp[4];
		im[5].sprite = sp[4];

		bool[,] bk = new bool[141,141];
		wtx = new Texture2D(141,141);
		ri.texture = wtx;
		ri.color = new Color(1,1,1,0);

		for(i=0;i<24;i++){
			scj[i].color = new Color(0.5f,0.5f,1f,0.5f);
		}
		im[0].color = Color.red;
		onb=false;
	}
	public void sscp(){
		mp = Input.mousePosition;
		vvp.y = cb.transform.position.y;
		vvp.x = cb.transform.localScale.x;
		vvp.z = cb.transform.localScale.y;
	}
	public void ssgp(){
		if(rby!=null){
		Vector2 v = (Vector2)Input.mousePosition-mp;
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		cb.transform.position = (Vector3.up*((v.y*0.02f)+vvp.y));
		if(cb.transform.position.y<-5){cb.transform.position = new Vector3(0,-5f,0);}
		if(cb.transform.position.y>5){cb.transform.position = new Vector3(0,5f,0);}
		}
		if(Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		cb.transform.localScale = (Vector3.one*(((v.y*0.05f)+vvp.x)));
		if(cb.transform.localScale.x<0.5f){cb.transform.localScale = new Vector3(0.5f,cb.transform.localScale.y,0.5f);}
		if(cb.transform.localScale.y<0.5f){cb.transform.localScale = new Vector3(cb.transform.localScale.x,0.5f,cb.transform.localScale.z);}
		if(cb.transform.localScale.x>2f){cb.transform.localScale = (Vector3.one*2f);}
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		cb.transform.localScale = new Vector3(cb.transform.localScale.x,((v.y*0.05f)+vvp.z),cb.transform.localScale.z);
		if(cb.transform.localScale.y<1f){cb.transform.localScale = new Vector3(cb.transform.localScale.x,1f,cb.transform.localScale.z);}
		if(cb.transform.localScale.y>5f){cb.transform.localScale = new Vector3(cb.transform.localScale.x,5f,cb.transform.localScale.z);}
		}
//		bcl.size = cb.transform.localScale;
//		bcl.radius = cb.transform.localScale.x/2;
//		bcl.height = cb.transform.localScale.y*2;
//		bcl.center = cb.transform.position;
		}
	}

	public void btn(){
		st[5]++;
		if(st[5]>2){
			st[5]=0;
		}
		switch(st[5]){
		case 0:
		im[0].color = Color.red;

		break;
		case 1:
		im[0].color = Color.blue;
		break;
		case 2:
		im[0].color = Color.green;
		break;
		}
		
	}
	public void bts(int n){
		st[6+n]++;
		if(st[6+n]>1){
			st[6+n]=0;
		}
		im[n+1].sprite = sp[st[6+n]];

	}

	public void ft0(float f){
		tx[3].text = (""+f);
		st[9] = (int)f;
	}
	public void ft1(float f){
		tx[4].text = (""+f);
		st[10] = (int)f;
	}
	public void ft2(float f){
		tx[5].text = ("×"+f);
		st[11] = (int)f;
	}
	public void ft3(float f){
		f = Mathf.Round(f*f);
		tx[6].text = (""+f);
		st[12] = (int)f;
	}
	public void ft4(float f){
		tx[7].text = (""+f);
		st[13] = (int)((st[64]*0.05f)*(sl[5].value*sl[5].value));
	}
	public void ft5(float f){
		tx[8].text = (""+f);
		st[14] = (int)(f*10);
	}
	public void ft6(float f){
		f = Mathf.Round(f*100);
		f = f*0.01f;
		tx[9].text = (""+(f*0.01f));
		st[15] = (int)f;
	}
	public void ft7(float f){
		tx[10].text = (""+f);
		st[16] = (int)f;
	}
	public void bl17(float f){
		st[17] = (int)f;
		tx[16].text = (""+(f*0.01f));
	}
	public void bl18(float f){
		st[18] = (int)f;
		tx[17].text = ("-"+(f*0.01f));
	}
	public void b19(int n){
		st[19] = n;
	}
	public void b50(float f){
		st[50] = (int)f;
		//tx[13].text = (""+f);
		tx[13].text = (f+"/500");
		b65(st[65]);
	}
	public void b51(float f){
		st[51] = (int)f;
		tx[15].text = (""+f);
	}
	public void b52(float f){
		st[52] = (int)f;
		tx[14].text = (f+"/500");
		tx[27].text = (f+"/500");
		b66(st[66]);
	}
	public void b53(float f){
		st[53] = (int)f;
		tx[22].text = (""+f);
//		enc.anchoredPosition = new Vector2(3.8f*f,35);
	}
	public void b54(int n){
		st[54] = n; 
	}
	public void b55(float f){
		st[61] = (int)f; 
		tx[19].text = (""+f);
	}
	public void b556c(){
		st[55] = -1;
		st[56] = -1;
		tx[18].text = ("-");
	}
	public void b556i(){
		mp = Input.mousePosition;
		mvp.x = st[56];
		mvp.y = st[57];

	}
	public void b556(){
		Vector2 vc = (Vector2)Input.mousePosition - mp;
		st[56] = (int)(mvp.x + (vc.x*4));
		if(st[56]<0){st[56]=0;}
		if(st[56]>2800){st[56]=2800;}
		st[57] = (int)(mvp.y + (vc.y*4));
		if(st[57]<0){st[57]=0;}
		if(st[57]>2800){st[57]=2800;}
		tx[18].text = ((st[56]*0.1f)+"  "+(st[57]*0.1f));

	}
	public void b58(int n){
		st[58] = n; 
		switch(st[58]){
		case 0:
		pn[12].transform.SetParent(pn[9].transform);
		pn[12].transform.localPosition = Vector2.zero;
		pn[14].gameObject.SetActive(false);
		break;
		case 1:
		pn[12].transform.SetParent(pn[10].transform);
		pn[12].transform.localPosition = Vector2.zero;
		pn[14].gameObject.SetActive(false);
		break;
		case 2:
		pn[12].transform.SetParent(pn[11].transform);
		pn[12].transform.localPosition = Vector2.zero;
		pn[14].gameObject.SetActive(true);
		break;
		}
	}
	public void b59(float f){
		st[59] = (int)f; 
		tx[20].text = ("-"+(f*0.001f));
	}
	public void b60(float f){
		st[60] = (int)f; 
		tx[21].text = ("-"+(f*0.001f));
	}
	public void b62(float f){
		st[62] = (int)(f*f); 
		tx[24].text = ("<"+st[62]);
	}
	public void b63(int n){
		st[63] = n; 
		for(i=2;i<8;i++){
			gb[i].interactable = true;
		}
			gb[n+2].interactable = false;
		
	}
	public void b64(int n){
		st[64] = n;
		gb[8].interactable = true;
		gb[9].interactable = true;
		gb[10].interactable = true;
		gb[n+8].interactable = false;		
	}
	public void b65(float f){
		st[65] = (int)(f); 
		tx[26].text = (f+"/"+st[50]);
	}
	public void b66(float f){
		st[66] = (int)(f); 
		tx[27].text = (f+"/"+st[52]);
	}
	public void b67(int n){
		st[67] = n;
		gb[11].interactable = true;
		gb[12].interactable = true;
		gb[13].interactable = true;
		gb[n+11].interactable = false;		
	}
	public void masc(float f){
		st[68] = (int)(f*10);
		st[4] = (int)((st[68]/200f)*(sl[0].value*sl[0].value));
		st[13] = (int)((st[68]/200f)*(sl[5].value*sl[5].value));
		tx[28].text = (""+f/10);
	}
	public void tsjl(int n){
		if(Input.GetMouseButton(0)){
		if(sjn<4){st[20+n] = sjn;}
//		if(st[20+n]>3){
//			st[20+n]=0;
//		}
		switch(st[20+n]){
			case 0:
			scj[n].color = new Color(0.5f,0.5f,1f,0.5f);
			break;
			case 3:
			scj[n].color = new Color(1f,1f,0.5f,0.5f);
			break;
			case 1:
			scj[n].color = new Color(0.5f,1f,0.5f,0.5f);
			break;
			case 2:
			scj[n].color = new Color(1f,0.5f,0.5f,0.5f);
			break;
		}
		}
	}

	public void fmwk(){
		if(onb){
		Vector3[] v = new Vector3[4];
		fw.GetWorldCorners(v);
		int mx = (int)(((Input.mousePosition.x-v[0].x)/Screen.width)*1280f);
		int my = (int)(((Input.mousePosition.y-v[0].y)/Screen.height)*720f);
		mx = (int)(0.35f*(float)mx);
		my = (int)(0.35f*(float)my);
		Color[] cx = wtx.GetPixels();
		if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
			Color cb =  new Color(0,0,0.5f,0.25f);
			for(int i=-7;i<7;i++){
				for(int j=-7;j<7;j++){
				if(mx+i>=0&&141>mx+i && my+j>=0&&141>my+j){
				cx[((my+j)*141 )+ mx+i] = cb;
				bk[mx+i,my+j] = true;
				}
			}
			}
		}
		if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
			Color cr =  new Color(0,0,0,0f);
			for(int i=-7;i<7;i++){
				for(int j=-7;j<7;j++){
				if(mx+i>=0&&141>mx+i && my+j>=0&&141>my+j){
				cx[((my+j)*141 )+ mx+i] = cr;
				bk[mx+i,my+j] = false;
				}
			}
			}
		}
		wtx.SetPixels(cx);
		wtx.Apply();
		}
	}

	public void ent(){
		mp = Input.mousePosition;
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		mvp = mvs.anchoredPosition;
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		mvp = mvs.sizeDelta;
		}
	}
	public void snt(){
		mp = Input.mousePosition;
		mvp = mvs.sizeDelta;
	}
	public void widt(){
		Vector2 vc = (Vector2)Input.mousePosition - mp;
		mvs.sizeDelta = mvp + new Vector2((vc.x*0.1f)+(vc.y*0.5f),0);
		if(mvs.sizeDelta.x<2){mvs.sizeDelta = new Vector2(2,mvs.sizeDelta.y);}
		if(mvs.sizeDelta.x>240){mvs.sizeDelta = new Vector2(240,mvs.sizeDelta.y);}
		mvcc();
	}
	public void hegt(){
		Vector2 vc = (Vector2)Input.mousePosition - mp;
		mvs.sizeDelta = mvp + new Vector2(0,(vc.x*0.1f)+(vc.y*0.5f));
		if(mvs.sizeDelta.y<2){mvs.sizeDelta = new Vector2(mvs.sizeDelta.x,2);}
		if(mvs.sizeDelta.y>240){mvs.sizeDelta = new Vector2(mvs.sizeDelta.x,240);}
		mvcc();
	}
	public void mvt(){
		Vector2 vc = (Vector2)Input.mousePosition - mp;
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		mvs.anchoredPosition = mvp + vc;
		mvcc();
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		mvs.sizeDelta = mvp + new Vector2((vc.x*0.2f),(vc.y*0.2f));
		if(mvs.sizeDelta.x<2){mvs.sizeDelta = new Vector2(2,mvs.sizeDelta.y);}
		if(mvs.sizeDelta.x>400){mvs.sizeDelta = new Vector2(400,mvs.sizeDelta.y);}
		if(mvs.sizeDelta.y<2){mvs.sizeDelta = new Vector2(mvs.sizeDelta.x,2);}
		if(mvs.sizeDelta.y>400){mvs.sizeDelta = new Vector2(mvs.sizeDelta.x,400);}
		mvcc();
		}
	}
	void mvcc(){
		if(mvs.anchoredPosition.x-(mvs.sizeDelta.x/2)<0){
			mvs.anchoredPosition = new Vector2((mvs.sizeDelta.x/2),mvs.anchoredPosition.y);
		}
		if(mvs.anchoredPosition.x+(mvs.sizeDelta.x/2)>400){
			mvs.anchoredPosition = new Vector2(400-(mvs.sizeDelta.x/2),mvs.anchoredPosition.y);
		}
		if(mvs.anchoredPosition.y-(mvs.sizeDelta.y/2)<0){
			mvs.anchoredPosition = new Vector2(mvs.anchoredPosition.x,(mvs.sizeDelta.y/2));
		}
		if(mvs.anchoredPosition.y+(mvs.sizeDelta.y/2)>400){
			mvs.anchoredPosition = new Vector2(mvs.anchoredPosition.x,240-(mvs.sizeDelta.y/2));
		}
		st[0] = (int)(mvs.anchoredPosition.x-(mvs.sizeDelta.x/2f));
		st[1] = (int)(mvs.anchoredPosition.x+(mvs.sizeDelta.x/2f));
		st[2] = (int)(mvs.anchoredPosition.y-(mvs.sizeDelta.y/2f));
		st[3] = (int)(mvs.anchoredPosition.y+(mvs.sizeDelta.y/2f));
		tx[0].text = (""+(st[1]-st[0]));
		tx[1].text = (""+(st[3]-st[2]));

	}
	public void gnkn(int n){
		st[54] = n;
		switch(st[54]){
		case 0:
		pn[8].transform.SetParent(pn[5].transform);
		pn[8].localPosition = Vector2.zero;
		pn[13].gameObject.SetActive(false);
		break;
		case 1:
		pn[8].transform.SetParent(pn[6].transform);
		pn[8].transform.localPosition = Vector2.zero;
		pn[13].gameObject.SetActive(false);
		break;
		case 2:
		pn[8].transform.SetParent(pn[7].transform);
		pn[8].transform.localPosition = Vector2.zero;
		pn[13].gameObject.SetActive(true);
		break;
		}
	}
	public void mvsp(float f){
		if(rgd!=null){
		st[4] = (int)((sl[20].value*0.05f)*(f*f));
		}
		tx[2].text = (""+f);
	}
	public void dngn(int n){
		if(rb != null){
			if(date.it[n]!=null && date.it[n].tag==("Fire")){
			rb.dng(date.it[n]);
			im[4].sprite = date.itsp[n];
			}
		}
	}
	public void amgn(int n){
		if(rb != null){
			if(n==20){
			rb.dngnull();
			im[4].sprite = sp[4];
			return;
			}
			if(date.it[n]!=null && date.it[n].tag==("Fire")){
			rb.dng(date.it[n]);
			im[4].sprite = date.itsp[n];
			}

		}
	}
	/*
	public void amgn(int n){
		if(rb != null){
			if(date.it[n]!=null && date.it[n].tag==("wepn")){
			rb.wep(date.it[n]);
			amst = Instantiate(date.it[n]);
			Destroy(amst.GetComponent<Rigidbody>());
			Destroy(amst.GetComponent<itm>());
			amst.layer = 9;
			amst.SetActive(true);
			im[6].sprite = date.itsp[n];
			}
		}
	}
	public void puam(){
		if(amst!=null){
		amn++;
		if(amn>cldc){amn = cldc;}
		amst.transform.localPosition = Vector3.zero;
		amst.transform.parent = asy[amn].transform;
		}
	}
	public void muam(){
		if(amst!=null){
		amn--;
		if(0>amn){amn=0;}
		amst.transform.localPosition = Vector3.zero;
		amst.transform.parent = asy[amn].transform;
		}
	}
	public void mvam(int n){
		if(amst!=null){
		if(n==0){
			mvp = Input.mousePosition;
			vvp = amst.transform.localPosition;
		}
		if(n==1){
			mvp = Input.mousePosition;
			vvp = amst.transform.eulerAngles;
		}
		}
	}

	public void mvps(){
		if(amst!=null){
		Vector2 vm = (Vector2)Input.mousePosition - mvp;
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		st[44] = (int)(vm.x*0.1f);
		st[45] = (int)(vm.y*0.1f);
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		st[46] = (int)(vm.x*0.1f);
		}
		amst.transform.localPosition = vvp + new Vector3(st[44]*0.1f,st[45]*0.1f,st[46]*0.1f);
		tx[11].text = (""+st[44]*0.1f + "  "+st[45]*0.1f + "  "+st[46]*0.1f);
		}
	}
	public void mvrt(){
		if(amst!=null){
		Vector2 vm = (Vector2)Input.mousePosition - mvp;
		if(Input.GetMouseButton(0)&&!Input.GetMouseButton(1)){
		st[47] = (int)(vvp.x-(vm.x*0.1f));
		st[48] = (int)(vvp.y-(vm.y*0.1f));
		}
		if(!Input.GetMouseButton(0)&&Input.GetMouseButton(1)){
		st[49] = (int)(vvp.z-(vm.x*0.1f));
		}
		amst.transform.eulerAngles = new Vector3(st[47],st[48],st[49]);
		tx[12].text = (""+st[47] + "  "+st[48] + "  "+st[49]);
		}
	}
*/

	public void figir(float f){
		if(rb!=null){
			if(f>0){
				f = f - 1;
			switch(rb.ougcl((int)f)){
				case 0:
				cb.GetComponent<MeshFilter>().mesh = null;

				break;
				case 1:
				cb.transform.localScale = (cb.transform.localScale.x/cb.transform.lossyScale.x) * (rb.ougc()[(int)f].transform.lossyScale.x * rb.ougc()[(int)f].GetComponent<BoxCollider>().size);
				cb.transform.position = rb.ougc()[(int)f].transform.position + rb.ougc()[(int)f].GetComponent<BoxCollider>().center;
				cb.GetComponent<MeshFilter>().mesh = mes[0];
				
				break;
				case 2:
				cb.transform.localScale = Vector3.one * ((rb.ougc()[(int)f].transform.lossyScale.x * rb.ougc()[(int)f].GetComponent<SphereCollider>().radius) * (cb.transform.localScale.x/cb.transform.lossyScale.x));
				cb.transform.position = rb.ougc()[(int)f].transform.position + rb.ougc()[(int)f].GetComponent<SphereCollider>().center;
				cb.GetComponent<MeshFilter>().mesh = mes[1];
				
				break;
				case 3:
				cb.transform.localScale = new Vector3((rb.ougc()[(int)f].GetComponent<CapsuleCollider>().radius * (cb.transform.localScale.x/cb.transform.lossyScale.x))/2,
													  (rb.ougc()[(int)f].GetComponent<CapsuleCollider>().height * (cb.transform.localScale.y/cb.transform.lossyScale.y))*2,
													  (rb.ougc()[(int)f].GetComponent<CapsuleCollider>().radius * (cb.transform.localScale.z/cb.transform.lossyScale.z))/2
													  ) * rb.ougc()[(int)f].transform.lossyScale.x;
				cb.transform.position = rb.ougc()[(int)f].transform.position + rb.ougc()[(int)f].GetComponent<CapsuleCollider>().center;
				cb.GetComponent<MeshFilter>().mesh = mes[2];
				
				break;
			}
			}else{
				if(rb.ougm().GetComponent<BoxCollider>()!=null){
				cb.transform.localScale = (cb.transform.localScale.x/cb.transform.lossyScale.x) * (rb.ougm().transform.lossyScale.x * rb.ougm().GetComponent<BoxCollider>().size);
				cb.transform.position = rb.ougm().transform.position + rb.ougm().GetComponent<BoxCollider>().center;
				cb.GetComponent<MeshFilter>().mesh = mes[0];
				}
				if(rb.ougm().GetComponent<SphereCollider>()!=null){
				cb.transform.localScale = Vector3.one * ((rb.ougm().transform.lossyScale.x * rb.ougm().GetComponent<SphereCollider>().radius) * (cb.transform.localScale.x/cb.transform.lossyScale.x));
				cb.transform.position = rb.ougm().transform.position + rb.ougm().GetComponent<SphereCollider>().center;
				cb.GetComponent<MeshFilter>().mesh = mes[1];
				}
				if(rb.ougm().GetComponent<CapsuleCollider>()!=null){
					cb.transform.localScale = Vector3.one * 
											(rb.ougm().transform.lossyScale.x * rb.ougm().GetComponent<CapsuleCollider>().height)*
											(rb.ougm().transform.lossyScale.x * rb.ougm().GetComponent<CapsuleCollider>().radius)*
											(cb.transform.localScale.x/cb.transform.lossyScale.x);
					//new Vector3(rb.ougm().GetComponent<CapsuleCollider>().radius,
					//									  rb.ougm().GetComponent<CapsuleCollider>().height,
					//									  rb.ougm().GetComponent<CapsuleCollider>().radius);
					cb.transform.position = rb.ougm().transform.position + rb.ougm().GetComponent<CapsuleCollider>().center;
					cb.GetComponent<MeshFilter>().mesh = mes[2];
				}
			}			
		}
	}
	public void figrc(int n){
		if(rb!=null){
		if(sl[23].value>0){
		switch(rb.ougcl((int)sl[23].value-1)){
				case 0:
				break;
				case 1:
				Destroy(rb.ougc()[(int)sl[23].value-1].GetComponent<BoxCollider>());
				break;
				case 2:
				Destroy(rb.ougc()[(int)sl[23].value-1].GetComponent<SphereCollider>());
				break;
				case 3:
				Destroy(rb.ougc()[(int)sl[23].value-1].GetComponent<CapsuleCollider>());
				break;
		}
		switch(n){
				case 0:
				cb.GetComponent<MeshFilter>().mesh = null;
				break;
				case 1:
				rb.ougc()[(int)sl[23].value-1].AddComponent<BoxCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[0];
				break;
				case 2:
				rb.ougc()[(int)sl[23].value-1].AddComponent<SphereCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[1];
				break;
				case 3:
				rb.ougc()[(int)sl[23].value-1].AddComponent<CapsuleCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[2];
				break;
		}
		}else{
			/*
				if(rb.ougm().GetComponent<BoxCollider>()!=null){
				Destroy(rb.ougm().GetComponent<BoxCollider>());
				}
				if(rb.ougm().GetComponent<SphereCollider>()!=null){
				Destroy(rb.ougm().GetComponent<SphereCollider>());
				}
				if(rb.ougm().GetComponent<CapsuleCollider>()!=null){
				Destroy(rb.ougm().GetComponent<CapsuleCollider>());
				}
				switch(n){

				case 1:
				rb.ougm().AddComponent<BoxCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[0];
				break;
				case 2:
				rb.ougm().AddComponent<SphereCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[1];
				break;
				case 3:
				rb.ougm().AddComponent<CapsuleCollider>();
				cb.GetComponent<MeshFilter>().mesh = mes[2];
				break;
				}
		*/
		}

		
		}
	}

	public void figpt(){
		if(rb!=null && bys){
			if(sl[23].value>0){
				switch(rb.ougcl((int)sl[23].value-1)){
					case 1:
					cb.transform.position = rb.ougc()[(int)sl[23].value-1].transform.position + new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougc()[(int)sl[23].value-1].GetComponent<BoxCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougc()[(int)sl[23].value-1].GetComponent<BoxCollider>().size = Vector3.one * sl[27].value;
					break;
					case 2:
					cb.transform.position = rb.ougc()[(int)sl[23].value-1].transform.position + new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougc()[(int)sl[23].value-1].GetComponent<SphereCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougc()[(int)sl[23].value-1].GetComponent<SphereCollider>().radius = sl[27].value;
					break;
					case 3:
					cb.transform.position = rb.ougc()[(int)sl[23].value-1].transform.position + new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougc()[(int)sl[23].value-1].GetComponent<CapsuleCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougc()[(int)sl[23].value-1].GetComponent<CapsuleCollider>().radius = sl[27].value*2f;
					rb.ougc()[(int)sl[23].value-1].GetComponent<CapsuleCollider>().height = sl[27].value/2;
					break;
				}
			}else{
			cb.transform.position = rb.ougm().transform.position + new Vector3(sl[24].value,sl[25].value,sl[26].value);
			cb.transform.localScale = rb.ougm().transform.localScale + Vector3.one * sl[27].value;
			if(rb.ougm().GetComponent<BoxCollider>()!=null){
					cb.transform.position = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougm().GetComponent<BoxCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougm().GetComponent<BoxCollider>().size = Vector3.one * sl[27].value;
				}
			if(rb.ougm().GetComponent<SphereCollider>()!=null){
					cb.transform.position = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougm().GetComponent<SphereCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougm().GetComponent<SphereCollider>().radius = sl[27].value;
				}
			if(rb.ougm().GetComponent<CapsuleCollider>()!=null){
					cb.transform.position = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					cb.transform.localScale = Vector3.one * sl[27].value;
					rb.ougm().GetComponent<CapsuleCollider>().center = new Vector3(sl[24].value,sl[25].value,sl[26].value);
					rb.ougm().GetComponent<CapsuleCollider>().radius = sl[27].value/2f;
					rb.ougm().GetComponent<CapsuleCollider>().height = sl[27].value*2;
				}		
			}
			//figpp();
		}
	}
	public void  fcmr(float f){
		cbx.transform.eulerAngles = new Vector3(0,f,0);
		cmr.transform.LookAt(cb.transform);
	}
	public void  fcmrz(){
		cmr.transform.position +=  Vector3.forward * Input.mouseScrollDelta.x;
		if(cmr.transform.position.z>-1){cmr.transform.position = new Vector3(0,0,-1);}
		if(cmr.transform.position.z<-5){cmr.transform.position = new Vector3(0,0,-5);}

	}

	public void figpp(){
		if(rb!=null){
		bys=false;
		sl[24].value = cb.transform.position.x;
		sl[25].value = cb.transform.position.y;
		sl[26].value = cb.transform.position.z;
		sl[27].value = cb.transform.lossyScale.x;
		bys = true;
		}
	}

	public void flist(){
		bys=false;
		sl[24].value = 0;
		sl[25].value = 0;
		sl[26].value = 0;
		sl[27].value = 1;
		bys = true;
		figpt();
	}	

	public void pnll(int n){
		pn[0].gameObject.SetActive(false);
		pn[1].gameObject.SetActive(false);
		pn[2].gameObject.SetActive(false);
		pn[3].gameObject.SetActive(false);
		pn[4].gameObject.SetActive(false);
		pn[15].gameObject.SetActive(false);
		pn[16].gameObject.SetActive(false);
		pn[17].gameObject.SetActive(false);		
		pn[18].gameObject.SetActive(false);

		pn[n].gameObject.SetActive(true);
		sjn = n;

	}

	public void  setv(){
	if(rb!=null){
		if(rb!=null){
			rb.setp(st);
		}

		}
	}

	[ContextMenu ("sm")]
	void sm(){
	AudioClip[] a = Resources.LoadAll<AudioClip>("minisd"); 
	ac = new AudioClip[a.Length];
	for(int i=0;i<a.Length;i++){
	ac[i] = a[i];
	}
	}
}
