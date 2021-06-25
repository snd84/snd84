using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ptmk : MonoBehaviour {
int sc = -1;
public GameObject g;
public MeshRenderer mr;
public MeshFilter ms;
public Material somt;
public GameObject cmr;
public Slider  sl;
public RawImage ptx;
public RectTransform px;
public RectTransform bvf;
public RectTransform ux;
public Slider[] sx = new Slider[6];
public RectTransform sm1;
public RectTransform sm2;
//public RectTransform sss;
public Text tx;
public Image pi;
public RawImage pig;
public RectTransform piv;
public RectTransform pip;
public Image[] ig = new Image[50];

public Camera cam;
public MeshCollider mec;
public LayerMask mk;
public RectTransform jt;
public Image ims;
public RectTransform imz;


public RectTransform tszc;

public RenderTexture ttx;
public GameObject brs;
int txs=256;

Texture2D grf;

Color cr = Color.black;
Color[] cs = new Color[400];

Vector2 v;
Vector3 r;
Vector3 vm;
Vector2 vf;
Vector2 vr;
Vector2[] vu;

float ck = 1;
float brt = 0.01f;
int ps;
int tsz = 256;
int ch = 0;
int xx;
int yy;
int xm;
int ym;
int of =0;
int cx;
int cy;
int pz =3;
int cl;
bool bo=false;
bool pns = true;
bool btr = true;
//Vector3[] vec;
//int[] vi;
//Vector2[] vu;

/*
void pxx(){
	Texture2D tk = new Texture2D(210,25);
	int i;
	int j;
	for(i=0;i<35;i++){
		Color c = new Color(1f,0f,((1f/255f)*(i*7.3f)));
		for(j=0;j<25;j++){
			tk.SetPixel(i,j,c);
			}
		}
	for(i=0;i<35;i++){
		Color c = new Color((1f-(1f/255f)*(i*7.3f)),0,1f);
		for(j=0;j<25;j++){
			tk.SetPixel(i+35,j,c);
			}
		}
	for(i=0;i<35;i++){
		Color c = new Color(0f,((1f/255f)*(i*7.3f)),1f);
		for(j=0;j<25;j++){
			tk.SetPixel(i+70,j,c);
		}
	}
	for(i=0;i<35;i++){
		Color c = new Color(0f,1f,(1f-(1f/255f)*(i*7.3f)));
		for(j=0;j<25;j++){
			tk.SetPixel(i+105,j,c);
		}
	}
	for(i=0;i<35;i++){
		Color c = new Color(((1f/255f)*(i*7.3f)),1f,0f);
		for(j=0;j<25;j++){
			tk.SetPixel(i+140,j,c);
			}
		}
	for(i=0;i<35;i++){
		Color c = new Color(1f,(1f-(1f/255f)*(i*7.3f)),0f);
		for(j=0;j<25;j++){
			tk.SetPixel(i+175,j,c);
		}
	}

	tk.Apply();
	Sprite sp;
	sp = Sprite.Create(tk,new Rect(0,0,210,25),new Vector2(0.5f, 0.5f));
	pi.sprite = sp;

}
*/


	// Use this for initialization
	void Start () {
	// (float)512f/tsz;
	}
	public void init(){
	//	sss.gameObject.SetActive(false);
		bvf.gameObject.SetActive(false);
		ux.gameObject.SetActive(false);
		grf = new Texture2D(1,1);
		ms.mesh = null;
		mec.sharedMesh = null;
		tx.text = ("");
		ptx.texture = null;
		ch = 0;
		if(sc>=0){
			ig[sc].color = Color.white;
		}
		sc = -1;
		bo=false;
		sl.maxValue =0;
			}
	public void msnu(){
		for(int i=0;i<50;i++){
			if(date.ms[i] != null){
				ig[i].sprite = date.se[i];
			}else{
				ig[i].sprite = null;
			}
		}
		init();
	}
	
	// Update is called once per frame
	public void on(int i){
		if(sc!=i &&	date.ms[i]!=null){
			if(sc>=0){ig[sc].color = Color.white;}
		sc = i;
		bo=true;
		cam.transform.position= new Vector3(0,0,-5);
		g.transform.position=Vector3.zero;
		g.transform.eulerAngles=Vector3.zero;
		//sss.gameObject.SetActive(true);
		//sss.anchoredPosition = Vector3.zero;
		ig[i].color = Color.gray;
		ms.mesh = date.ms[i];
		mec.sharedMesh = date.ms[i];
		//vec = date.ms[sc].vertices;
		//vi = date.ms[sc].triangles;
		//vu = date.ms[sc].uv;
		sl.maxValue = (int)(date.ms[sc].vertexCount/4f)-1;
		btr=false;
		sl.value = 0;
		btr=true;
		tx.text = ((ch+1)+"/"+(sl.maxValue+1));
			if(date.mt[i]!=null){
			mr.materials[0] = date.mt[i];
			mr.materials[0].mainTexture = date.tx[i];
			xx = 0;
			yy = 0;
			of = 0;
			vu = date.ms[i].uv;
			tsz = date.tx[i].width;
			sx[0].maxValue = tsz;
			sx[1].maxValue = tsz;
			sx[2].maxValue = tsz-1;
			sx[3].maxValue = tsz;
			sx[4].maxValue = tsz;
			sx[5].maxValue = tsz-1;
			slvr(0f);
			pcor(cl);
			}else{
			date.mt[i] = Instantiate(somt);
			date.tx[i] = new Texture2D(tsz,tsz,TextureFormat.RGB24,false);
			date.tx[i].filterMode = FilterMode.Point;
			date.mt[i].mainTexture = date.tx[i];
			mr.materials[0] = date.mt[i];
			mr.materials[0].mainTexture = date.tx[i];

			int m = ms.mesh.vertexCount;
			vu = new Vector2[m];
			int np = Mathf.CeilToInt(Mathf.Sqrt(sl.maxValue));
			float f = (1f/tsz)*(Mathf.Floor(((float)tsz/(float)np)));
			int c = 0;
			for(int j=0;j<np;j++){
				for(int h=0;h<np;h++){
					if(m>c){
					vu[c] = new Vector2((h*f),1f-(j*f));
					vu[c+1] = new Vector2(((h+1)*f),1f-(j*f));
					vu[c+2] = new Vector2((h*f),1f-((j+1)*f));
					vu[c+3] = new Vector2(((h+1)*f),1f-((j+1)*f));
					c+=4;
					}else{
						break;
					}
				}
			}
			ms.mesh.uv = vu;
			date.ms[i].uv = vu;
			xx = 0;
			yy = 0;
			of = 0;
			bo=true;
			slvr(0f);
			pcor(cl);
			}

		}else{
		//sss.gameObject.SetActive(false);
		}
	}


	public void txc(int n){
		tszc.localPosition = Vector3.zero;
		txs = n;
	}
	public void txz(){
		if(sc!=-1){
		tsz = txs;
		ps = 7;
		sx[0].maxValue = tsz;
		sx[1].maxValue = tsz;
		sx[2].maxValue = tsz-1;
		sx[3].maxValue = tsz;
		sx[4].maxValue = tsz;
		sx[5].maxValue = tsz-1;
		bfc();
		date.tx[sc] = new Texture2D(tsz,tsz,TextureFormat.RGB24,false);
		date.tx[sc].wrapMode = TextureWrapMode.Clamp;
		date.tx[sc].filterMode = FilterMode.Point;
		date.mt[sc].mainTexture = date.tx[sc];
		mr.materials[0].mainTexture = date.tx[sc];
		int m = ms.mesh.vertexCount;
		vu = new Vector2[m];
		int np = Mathf.CeilToInt(Mathf.Sqrt(sl.maxValue));
		float f = (1f/tsz)*(Mathf.Floor(((float)tsz/(float)np)));
		int c = 0;
		for(int j=0;j<np;j++){
			for(int h=0;h<np;h++){
				if(m>c){
				vu[c] = new Vector2((h*f),1f-(j*f));
				vu[c+1] = new Vector2(((h+1)*f),1f-(j*f));
				vu[c+2] = new Vector2((h*f),1f-((j+1)*f));
				vu[c+3] = new Vector2(((h+1)*f),1f-((j+1)*f));
				c+=4;
				}else{
					break;
				}
			}
		}
		ms.mesh.uv = vu;
		date.ms[sc].uv = vu;
		xx = 0;
		yy = 0;
		of = 0;
		bo=true;
		sl.value = 0;
		slvr(0f);
		bfc();
		}
	}


	public void next(){
		sl.value += 1;
	}

	public void rivr(){
		sl.value -= 1;
	}

	public void slvr(float f){
		if(btr){
		ch = (int)f;
		if(of==0 && bo==true){
		xx = Mathf.RoundToInt(vu[ch*4+2].x * (float)tsz);
		yy = Mathf.RoundToInt(vu[ch*4+2].y * (float)tsz);
		
		xm = Mathf.FloorToInt(vu[ch*4+3].x * (float)tsz)-xx;
		ym = Mathf.FloorToInt(vu[ch*4].y * (float)tsz)-yy;
		grf = new Texture2D(xm,ym);
		ptx.texture =  grf;
		ptx.texture.wrapMode = TextureWrapMode.Clamp;
		ptx.texture.filterMode = FilterMode.Point;
		Color c;
		for(int i=0;i<ym;i++){
			for(int j=0;j<xm;j++){
				c = date.tx[sc].GetPixel(xx+j,yy+i);
				grf.SetPixel(j,i,c);
			}
		}
		grf.Apply();
		tx.text = ((ch+1)+"/"+(sl.maxValue+1));
		}else{
			bfc();
			tx.text = ((ch+1)+"/"+(sl.maxValue+1));
		}
	}
	}



	public void rots(){
		v = Input.mousePosition;
		if(Input.GetMouseButton(2) && !Input.GetMouseButton(1)){r = g.transform.eulerAngles;}
		if(Input.GetMouseButton(1) && !Input.GetMouseButton(2)){vm = cam.transform.position;}
		if(btr && Input.GetMouseButton(0)){

			Vector2 mp = Input.mousePosition;
			Vector3[] v = new Vector3[4];
			jt.GetWorldCorners(v);
			mp.x = (mp.x-v[0].x)/jt.transform.lossyScale.x;
			mp.y = (mp.y-v[0].y)/jt.transform.lossyScale.y;
			Ray ray = cam.ScreenPointToRay(mp);
			RaycastHit rh;
			if(Physics.Raycast(ray,out rh,Mathf.Infinity,mk)){
			int i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
			slvr(i);
			sl.value = i;
			}
		}
	}

	public void rotn(){
		Vector2 mm = Input.mousePosition;
		mm = mm - v;
		if(Input.GetMouseButton(2)){
		Vector3 rt = r + new Vector3(mm.y,-mm.x,0);;
		g.transform.eulerAngles = rt;
		}
		if(Input.GetMouseButton(1)){
		cam.transform.position = vm + new Vector3(mm.x*0.05f,mm.y*0.05f,0f);
		}
	}


	public void rsiz(float n){
		pz = (int)n;
		imz.localScale = Vector3.one * (0.2f+(n*0.04f));

	}
	public void rsfl(float n){
		ck = n;
		cr.a = n;
		ims.color = cr;
	}




	public void pixp(){
		if(bo==true && ch>=0){
			Vector3[] v = new Vector3[4];
			px.GetWorldCorners(v);
			int mx = (int)((Input.mousePosition.x-v[0].x)/px.transform.lossyScale.x);
			int my = (int)((Input.mousePosition.y-v[0].y)/px.transform.lossyScale.y);
			mx = (int)(((float)xm/(float)512)*(float)mx);
			my = (int)(((float)ym/(float)512)*(float)my);
		if(btr){
			if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
			if(mx>=0&&mx<xm && my>=0&&my<ym){
	
			int h = pz/2;
			Color c;
			Color32[] cp = grf.GetPixels32();
			Color32[] ct = date.tx[sc].GetPixels32();
			for(int n=0;n<pz;n++){
				for(int k=0;k<pz;k++){
					if(mx+n-h>=0 && mx+n-h <xm && my+k-h>=0 && my+k-h <ym){
						if(pns==true || ((h-n)*(h-n))+((h-k)*(h-k))<1+h*h){
						if(ck==1f){
						cp[(n-h)+mx+(xm*(my+k-h))] = cr;
						ct[(xx+(n-h)+mx)+(tsz*(my+k-h+yy))] = cr;
						//grf.SetPixel(mx+n-h,my+k-h,cr);date.tx[sc].SetPixel(xx+mx+n-h,yy+my+k-h,cr);
						}else{
						c = (Color)cp[(n-h)+mx+(xm*(my+k-h))];//grf.GetPixel(mx+n-h,my+k-h);
						c.b += ((cr.b-c.b)*(ck*ck));
						c.r += ((cr.r-c.r)*(ck*ck));
						c.g += ((cr.g-c.g)*(ck*ck));
						cp[(n-h)+mx+(xm*(my+k-h))] = c;
						ct[(xx+(n-h)+mx)+(tsz*(my+k-h+yy))] = c;
						//grf.SetPixel(mx+n-h,my+k-h,c);date.tx[sc].SetPixel(xx+mx+n-h,yy+my+k-h,c);
						}
						}
					}
				}
			}
			grf.SetPixels32(cp);
			date.tx[sc].SetPixels32(ct);
			grf.Apply();	
			date.tx[sc].Apply();
			}

			}else{

				cr = grf.GetPixel(mx,my);
				ims.color = cr;
				Color a = new Color(cr.r/19f,cr.g/19f,cr.b/19f,1f);
				for(int i=0;i<20;i++){
				cs[i] = Color.black + (a * (float)i);
				for(int j=1;j<20;j++){
				cs[(j*20)+i] = cs[i] + (new Color(brt,brt,brt,0f)*j);//(new Color(0.025f,0.025f,0.025f,0f)*j);
				}
				}
				for(int i=1;i<20;i++){
				cs[i*20] = new Color(0.0527f,0.0527f,0.0527f,1f) * i;
				}
			Texture2D t = new Texture2D(20,20);
			t.SetPixels(cs);
			t.Apply();
			t.filterMode = FilterMode.Point;
			pig.texture = t;
			pig.texture.wrapMode = TextureWrapMode.Clamp;

			}

		}else{
			if(!Input.GetMouseButtonDown(2) && !Input.GetMouseButtonDown(1)){
			rotn();
			}
			if(Input.GetMouseButton(0)){
			Vector2 mp = Input.mousePosition;
			px.GetWorldCorners(v);
			mp.x = (mp.x-v[0].x)/px.transform.lossyScale.x*0.586f;
			mp.y = (mp.y-v[0].y)/px.transform.lossyScale.x*0.586f;
			Ray ray = cam.ScreenPointToRay(mp);
			RaycastHit rh;
			if(Physics.Raycast(ray,out rh,Mathf.Infinity,mk)){
				//brs.transform.position = rh.point;
				//brs.transform.localScale = Vector3.one * ((brs.transform.localScale.x/brs.transform.lossyScale.x)*0.025f*pz);
			//	int k = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				Vector3[] vq =  ms.mesh.vertices;
				Vector2[] vus =  ms.mesh.uv;
				int[] vi = ms.mesh.triangles;
				rh.point = g.transform.InverseTransformPoint(rh.point);
				Vector3 vp1 =rh.point-vq[vi[(rh.triangleIndex*3)]];
				Vector3 vp2 =vq[vi[(rh.triangleIndex*3)+1]]-vq[vi[(rh.triangleIndex*3)]];
				Vector3 vp3 =vq[vi[(rh.triangleIndex*3)+2]]-vq[vi[(rh.triangleIndex*3)]];
				Vector3 hv = Vector3.Cross(vp2,vp3);
				Vector2 ht;
				if(hv.z == 0){
				vp1.x = Mathf.Abs(vp1.x)+((hv.x*vp1.z));
				vp1.y = Mathf.Abs(vp1.y)+((hv.y*vp1.z));
				vp2.x = Mathf.Abs(vp2.x)+((hv.x*vp2.z));
				vp2.y = Mathf.Abs(vp2.y)+((hv.y*vp2.z));
				vp3.x = Mathf.Abs(vp3.x)+((hv.x*vp3.z));
				vp3.y = Mathf.Abs(vp3.y)+((hv.y*vp3.z));
				}
				float vv = ((vp3.x*vp2.y)-(vp3.y*vp2.x))/2f;
				float v1 = ((vp3.x*vp1.y)-(vp1.x*vp3.y))/2f;
				float v2 = ((vp1.x*vp2.y)-(vp1.y*vp2.x))/2f;

				ht.x = Mathf.Abs(v1/vv);
				ht.y = Mathf.Abs(v2/vv);
				if(0 < ht.x && ht.x < 1 && 0 < ht.y && ht.y < 1){
				Vector2 s1 = (vus[vi[(rh.triangleIndex*3)]]);
				Vector2 s2 = (vus[vi[(rh.triangleIndex*3)+1]]);
				Vector2 s3 = (vus[vi[(rh.triangleIndex*3)+2]]);
				Vector2 po;
				po = ((s2-s1)*ht.x);
				po += ((s3-s1)*ht.y);
				int xs = (int)((s1.x*tsz)+(po.x*tsz));
				int ys = (int)((s1.y*tsz)+(po.y*tsz));
				int kk = 1 +(pz/2);
				int ss = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				xx = Mathf.RoundToInt(vu[ss*4+2].x * (float)tsz);
				yy = Mathf.RoundToInt(vu[ss*4+2].y * (float)tsz);	
				xm = Mathf.FloorToInt(vu[ss*4+3].x * (float)tsz);
				ym = Mathf.FloorToInt(vu[ss*4].y * (float)tsz);

				Color cc;
				Color32[] vct = date.tx[sc].GetPixels32();
				for(int ii=xs-kk;ii <xs+kk;ii++){
					for(int jj = ys-kk;jj <ys+kk;jj++){
						if(pns==true || ((ii-xs)*(ii-xs))+((jj-ys)*(jj-ys))<kk*kk){
						if(ck==1f){
							if(ii >= xx && ii < xm &&jj >= yy && jj < ym){vct[(jj * tsz)+ii] = cr;}
						}else{
							if(ii >= xx && ii < xm &&jj >= yy && jj < ym){
							cc = (Color)vct[(jj*tsz)+ii];//grf.GetPixel(mx+n-h,my+k-h);
							cc.b += ((cr.b-cc.b)*(ck*ck));
							cc.r += ((cr.r-cc.r)*(ck*ck));
							cc.g += ((cr.g-cc.g)*(ck*ck));
							vct[(jj*tsz)+ii] = cc;
							}
						}
						}
					}
				}
				
				date.tx[sc].SetPixels32(vct);
				date.tx[sc].Apply();
				}
			}
			}
		}
	}
	}

	[ContextMenu("tes")]
	void tes(){
		pcor(0);
	}
	public void pnsc(bool b){
		pns=b;
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

	}

	public void pcorr(){
		Vector3[] v = new Vector3[4];
		piv.GetWorldCorners(v);
		int mx = (int)(((Input.mousePosition.x-v[0].x)/Screen.width)*1280f);
		int my = (int)(((Input.mousePosition.y-v[0].y)/Screen.height)*720f);

		if(mx>=0&&mx<200 && my>=0&&my<200){
			cx = mx/10;
			cy = my/10;
			cr = cs[cx+(cy*20)];
			cr.a = ck;
			ims.color = cr;
			pip.anchoredPosition = new Vector2(5+(cx*10),5+(cy*10));
		}
	}

	public void msr(){
		if(Input.mouseScrollDelta.y!=0){
			cmr.transform.localPosition += new Vector3(0,0,Input.mouseScrollDelta.y/2f);
			if(cmr.transform.localPosition.z > 0){ cmr.transform.position = new Vector3(cmr.transform.position.x,cmr.transform.position.y,0f);}
			if(cmr.transform.localPosition.z < -65){ cmr.transform.position = new Vector3(cmr.transform.position.x,cmr.transform.position.y,-65f);}
		}
	}
	
	public void msrr(){
		if(!btr && Input.mouseScrollDelta.y!=0){
			cmr.transform.localPosition += new Vector3(0,0,Input.mouseScrollDelta.y/2f);
			if(cmr.transform.localPosition.z > 0){ cmr.transform.position = new Vector3(cmr.transform.position.x,cmr.transform.position.y,0f);}
			if(cmr.transform.localPosition.z < -65){ cmr.transform.position = new Vector3(cmr.transform.position.x,cmr.transform.position.y,-65f);}
		}
	}
	
	public void bb(){
		r = Input.mousePosition;
		vf.x = sx[2].value;
		vf.y = sx[5].value;
		ps = 6;
	}
	public void bfv(){
	Vector2 mp = r - Input.mousePosition;
	switch(tsz){
	case 512:
	xfx(vf.x - mp.x);
	yfy(vf.y + mp.y);
	break;
	case 256:
	xfx(vf.x - (mp.x/2f));
	yfy(vf.y + (mp.y/2f));
	break;
	case 128:
	xfx(vf.x - (mp.x/4f));
	yfy(vf.y + (mp.y/4f));
	break;
	}

	}

	public void bf(){
		//float f = 512f/(float)tsz;
		switch(tsz){
		case 512:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value),0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value));
		bvf.anchoredPosition = new Vector2(sx[2].value,-sx[5].value);
		bvf.sizeDelta = new Vector2(2+((sx[1].value-sx[0].value)),2+((sx[4].value-sx[3].value)));
		break;
		case 256:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value)*2f,0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value)*2f);
		bvf.anchoredPosition = new Vector2(sx[2].value*2f,-sx[5].value*2f);
		bvf.sizeDelta = new Vector2(2+((float)(sx[1].value-sx[0].value))*2f,2+((float)(sx[4].value-sx[3].value))*2f);
		break;
		case 128:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value)*4f,0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value)*4f);
		bvf.anchoredPosition = new Vector2(sx[2].value*4f,-sx[5].value*4f);
		bvf.sizeDelta = new Vector2(2+((float)(sx[1].value-sx[0].value))*4f,2+((float)(sx[4].value-sx[3].value))*4f);
		break;
		}
		if(sm1.sizeDelta.x<20){sm1.sizeDelta = new Vector3(20,0);}
		if(sm2.sizeDelta.y<20){sm2.sizeDelta = new Vector3(0,20);}		
		float f =  (1f / (float)tsz);
		vu[ch*4].x = (sx[0].value * f);
		vu[ch*4].y = 1f - (sx[3].value * f);

		vu[ch*4+1].x = (sx[1].value * f);
		vu[ch*4+1].y = 1f - (sx[3].value * f);

		vu[ch*4+2].x = (sx[0].value * f);
		vu[ch*4+2].y = 1f - (sx[4].value * f);

		vu[ch*4+3].x = (sx[1].value * f);
		vu[ch*4+3].y = 1f - (sx[4].value * f);

		ms.mesh.uv = vu;
		date.ms[sc].uv = vu;

	}
	void bfc(){
		ps = 7;
		sx[0].value = vu[ch*4].x * tsz;
		sx[1].value = vu[ch*4+1].x * tsz;
		sx[2].value = sx[0].value + ((sx[1].value-sx[0].value)*0.5f);
		sx[3].value = (1f-vu[ch*4].y) * tsz;
		sx[4].value = (1f-vu[(ch*4)+2].y) * tsz;
		sx[5].value = sx[3].value + ((sx[4].value-sx[3].value)*0.5f);
		switch(tsz){
		case 512:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value),0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value));
		bvf.anchoredPosition = new Vector2(sx[2].value,-sx[5].value);
		bvf.sizeDelta = new Vector2(2+((sx[1].value-sx[0].value)),2+((sx[4].value-sx[3].value)));
		break;
		case 256:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value)*2f,0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value)*2f);
		bvf.anchoredPosition = new Vector2(sx[2].value*2f,-sx[5].value*2f);
		bvf.sizeDelta = new Vector2(2+((sx[1].value-sx[0].value))*2f,2+((sx[4].value-sx[3].value))*2f);
		break;
		case 128:
		sm1.sizeDelta = new Vector2((sx[1].value-sx[0].value)*4f,0);
		sm2.sizeDelta = new Vector2(0,(sx[4].value-sx[3].value)*4f);
		bvf.anchoredPosition = new Vector2(sx[2].value*4f,-sx[5].value*4f);
		bvf.sizeDelta = new Vector2(2+((sx[1].value-sx[0].value))*4f,2+((sx[4].value-sx[3].value))*4f);
		break;
		}

	}
	public void psx(int n){
		ps = n;
	}

	public void  uvxa(){
		ps = 0;
		sx[0].value -= 1;
	}
	public void  uvxb(){
		ps = 0;
		sx[0].value += 1;
	}
	public void  uvxc(){
		ps = 1;
		sx[1].value -= 1;
	}
	public void  uvxd(){
		ps = 1;
		sx[1].value += 1;
	}
	public void  uvya(){
		ps =3;
		sx[3].value -= 1;
	}
	public void  uvyb(){
		ps = 3;
		sx[3].value += 1;
	}
	public void  uvyc(){
		ps = 4;
		sx[4].value -= 1;
	}
	public void  uvyd(){
		ps = 4;
		sx[4].value += 1;
	}


	public void xxx(float f){
		if(ps==0){
		int n = (int)f;
		if(sx[1].value<=n){
			sx[0].value = sx[1].value-1;
		}
		sx[2].value = (int)(sx[0].value+sx[1].value)*0.5f;
		bf();
		}
	}
	public void xxf(float f){
		if(ps==1){
		int n = (int)f;
		if(sx[0].value>=n){
			sx[1].value = sx[0].value+1;
		}
		sx[2].value = (int)(sx[0].value+sx[1].value)*0.5f;
		bf();
		}
	}
	public void xfx(float f){
		if(ps==2 || ps==6){
		int n = (int)f;
		int t = (int)((sx[1].value-sx[0].value)*0.5f);
		if(0<n-t && tsz > n+t){	
			sx[2].value = n;	
			sx[1].value = n + t;
			sx[0].value = n - t;
		}else{
			if(0>=n-t){
			sx[2].value = t;
			sx[0].value = 0;
			sx[1].value = t*2;
			}
			if(tsz < n+t){
			sx[2].value = tsz-t-1;
			sx[0].value = (tsz-(t*2))-1;
			sx[1].value = tsz;
			}
		}
		bf();
		//sx[2].value = (int)(sx[0].value+sx[1].value)*0.5f;
		//sm1.sizeDelta = new Vector2(sx[1].value-sx[0].value,0);
		}
	}

	public void yyy(float f){
		if(ps==3){
		int n = (int)f;
		if(sx[4].value<=n){
			sx[3].value = sx[4].value-1;
		}
		sx[5].value = (int)(sx[4].value+sx[3].value)*0.5f;
		bf();
		}
	}
	
	public void yyf(float f){
		if(ps==4){
		int n = (int)f;
		if(sx[3].value>=n){
			sx[4].value = sx[3].value+1;
		}
		sx[5].value = (int)(sx[4].value+sx[3].value)*0.5f;
		bf();
		}
		
	}

	public void yfy(float f){
		if(ps==5 || ps==6){
		int n = (int)f;
		int t = (int)((sx[4].value-sx[3].value)*0.5f);
		if(0<n-t && tsz > n+t){	
			sx[5].value = n;		
			sx[3].value = n - t;
			sx[4].value = n + t;
		}else{
			if(0>=n-t){
			sx[5].value = t;
			sx[3].value = 0;
			sx[4].value = t*2;
			}
			if(tsz < n+t){
			sx[5].value = tsz-t-1;
			sx[3].value = (tsz-(t*2))-1;
			sx[4].value = tsz;
			}
		}
		bf();
		//sx[2].value = (int)(sx[0].value+sx[1].value)*0.5f;
		//sm1.sizeDelta = new Vector2(sx[1].value-sx[0].value,0);
		}
	}

	public void onpn(){
		if(btr){
		if(sc>=0){
		ptx.raycastTarget = true;
		bvf.gameObject.SetActive(false);
		ux.gameObject.SetActive(false);
		of = 0;
		slvr(ch);		
		}
		}else{
		swet();	
		onpn();
		}
	}
	public void onwk(){
		if(btr){
		if(sc>=0){
		ptx.raycastTarget = false;
		bvf.gameObject.SetActive(true);
		ux.gameObject.SetActive(true);
		ptx.texture = date.tx[sc];
		of = 1;	
		bfc();
		}
		}else{
		swet();
		onwk();
		}	
	}
	public void onrr(){
		if(sc>=0){
		Vector3[] v = ms.mesh.vertices;
		Vector3 s;

		s = v[ch*4+1];
		v[ch*4+1]= v[ch*4+3];
		v[ch*4+3]=v[ch*4+2];
		v[ch*4+2]= v[ch*4];
		v[ch*4]= s;

		ms.mesh.vertices = v;
		date.ms[sc].vertices = v;
		}	
	}

	public void swet(){
		if(btr&&sc>=0){
		ptx.texture = ttx;
		ptx.raycastTarget = true;
		bvf.gameObject.SetActive(false);
		ux.gameObject.SetActive(false);
		btr=false;
		}else{		
		btr=true;
		onpn();
		}
	}

}