using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rovoko : MonoBehaviour {
//Vector3[,,] rm = new Vector3[9,22,300];

Vector3[,] rm0;
Vector3[,] rm1;
Vector3[,] rm2;
Vector3[,] rm3;
Vector3[,] rm4;
Vector3[,] rm5;
Vector3[,] rm6;
Vector3[,] rm7;
Vector3[,] rm8;

public GameObject[] gc = new GameObject[21];
public int[] lm = new int[9];
int a=0;
public int b=0;
int c=0;

public int cn=0;
public Rigidbody rb;
CapsuleCollider bc;
//BoxCollider bc;
//SphereCollider sc;

int i=0;
//int t;
float f=0;
public int dr=0;
Vector3 vc;
public GameObject en;
rovoko ed;
GameObject rester;

public float life = 100;
public float yen=0;
public float stmn = 0;
public GameObject dgn;
public GameObject ddgn;
public GameObject wepn;

int rlo=0; 
int ad;
int count=0;
int lfj;
Vector3[,] tnsk;
int[,] bm;
int[] xy = new int[4];
List<int> cnt;
public int slb=0;
int pk=0;
Vector3 lop;
float hift;
//public int[] gp = new int[3];
public int[] st = new int[100];
public bool[,] bw = new bool[141,141];

Vector3 nps;
bool loc=false;
float size;
public AudioSource ao;
public AudioClip[] acp = new AudioClip[13];

int wi;
//int wct;
Vector3 wn;
Vector3 lsc;
//float ch=1;
blds act;
itm aci;
rovoko acr;

RaycastHit h;
Vector3 enlp;
public LayerMask lsk;
public LayerMask nest;


	// Use this for initialization
	void Start () {
//		bc = GetComponent<BoxCollider>();
		bc = GetComponent<CapsuleCollider>();
		size = transform.localScale.x;
		lsc = transform.localScale;
//		sc = GetComponent<SphereCollider>();
		life = st[50];
		yen = st[51];
		stmn = st[52];
		lfj = st[55];
		rb.mass = st[68]*0.01f;
		rlo=0;
		//ad=st[11];
		hift = (bc.height*0.5f)*transform.localScale.x;
		if(ddgn!=null){ddgn = Instantiate(ddgn,transform.localPosition,Quaternion.identity,transform);ddgn.SetActive(false);}
		switch(st[5]){
			case 0: gameObject.tag = ("glp1");break;
			case 1: gameObject.tag = ("glp2");break;
			case 2: gameObject.tag = ("glp3");break;
		}

	}

	// Update is called once per frame
	void Update () {
		vc = transform.position;
		if(vc.x<0.1f){vc.x=0.1f;transform.position = vc;}
		if(vc.x>279.9f){vc.x=279.9f;transform.position = vc;}
		if(vc.z<0.1f){vc.z=0.1f;transform.position = vc;}
		if(vc.z>279.9f){vc.z=279.9f;transform.position = vc;}
		switch(cn){
			case 0:
				cah();
			break;
			
			case 1:
			wi--;
			if(wi>=0){	
				if(slb==1){tbox();}else{
					a=1;
					kck();
					trl();
					if(wi <=0 || dstn(nps,vc)< 5){
					a=0;
					cn=0;
					slb=0;
//					transform.eulerAngles = new Vector3(0,vc.y,vc.z);
					}
				}						
			}else{cn=0;}
			break;
			case 2:
			if(en!=null){
			if(dstn(enlp,vc)< 5){
				if(loc){
					count+=date.pt+1;
					if(count>60){
						life += act.get0(4);count=0;
						if(!act.ons()){loc=false;}
						if(life>=st[50]){life = st[50];
							if(st[20+date.tm]!=3){loc=false;}
						}
						if(!loc){cn=0;en=null;transform.parent=null;transform.localScale=lsc;break;}
					}
				}else{
					transform.parent = en.transform;
					transform.localScale = Vector3.zero;
					loc=true;
					otpr(7);
				}				
				
				}else{
			if(slb==1){tbox();c=0;}else{

				kck();
				trl();
			}
			}
			//if(wct>10){if(st[20+date.tm]!=0){cn=0;}else{wct=0;}}

			}else{cn=0;}
			break;
			case 3:
			if(en!=null){
				wkms();			
			}else{cn=0;}
			break;
			case 4:
			if(en!=null){
//			mibt();
			mift();
			}else{
				cn=0;
				dr=0;
				a=0;
			}
			break;
			case 5://des
			if(lm[6]>c){
				for(i=0;i<b;i++){				
				//gc[i].transform.localEulerAngles = rm[6,i,c];
				gc[i].transform.localEulerAngles = rm6[i,c];

				}
				gc[0].transform.localPosition = rm6[b,c];
				c++;
			}
				if(lm[6]<=c){
					switch(st[54]){
					case 0:Destroy(gameObject);break;
					case 1:cn=12;dr=4;rb.constraints = RigidbodyConstraints.None;break;
					case 2:lfj--;
						if(lfj<0){
							lfj=st[55];
							life = st[50];
							stmn = st[52];
							if(st[56]>=0){
							Ray r = new Ray(new Vector3((st[56]*0.1f),200,(st[57]*0.1f)),Vector3.down);
							RaycastHit h;
							Physics.Raycast(r,out h,Mathf.Infinity,256);
							Vector3 v=h.point;v.y+=GetComponent<CapsuleCollider>().height*(transform.lossyScale.y+1);
							transform.position = v;
							}
							dr=0;
							cn=0;
							Start();
							otpr(4);					
						}
					break;
					}
				}			
			break;
			case 7://待機
				if(a==0){
						wi--;
						if(wi<0){
							a=0;
							cn = 0;
							//sarci();
							if(en!=null){
								if(st[64]>life){sarci(true);}
								if(st[67]>stmn){sarci(false);}								
								}
						}
					}else{
						a=0;
						c=0;
					}
			break;
			case 8://umaru
			rb.Sleep();
			transform.position += new Vector3(0,st[17]*0.01f,0);			
			life -= st[18]*0.01f;
			wn = transform.position;
			if(wn.y-hift > date.izm[(int)(wn.x/2),(int)(wn.z/2)].x){
				bc.isTrigger=false;
				rb.velocity = new Vector3(0,10,0);
				cn=0;
				dr=0;
			}
		
			break;

			case 9:
			contr();
			break;
			case 10:
			if(en!=null){
			if(dstn(en.transform.position,vc)< 5){
				if(en.gameObject.tag==("itms")){aci = en.GetComponent<itm>();life += aci.itf[0];if(life>st[50]){life=st[50];}Destroy(en.gameObject);cn=0;otpr(6);break;}
				if(en.gameObject.tag==("enag")){aci = en.GetComponent<itm>();stmn += aci.itf[0];if(stmn>st[52]){life=st[52];}Destroy(en.gameObject);cn=0;otpr(6);break;}
				trl();
			}else{
			a=1;
			//lop = tnen();
			if(slb==1){tbox();}else{
				if(dstn(nps,vc)>10){kck();}else{srt();}
				trl();
			}

			}
			}else{cn=0;}
			break;
			case 11:
			if(en!=null){
			if(dstn(enlp,vc)< 5){otpr(6);
				if(en.gameObject.tag==("itms")&&(yen>act.pr[4])){
					life += act.pr[5];
					yen -= act.pr[4];
					if(life>st[50]||yen <act.pr[4]){cn=0;en=null;break;}
				}
				if(en.gameObject.tag==("enag")&&(yen>act.pr[4])){
					stmn += act.pr[5];
					yen -= act.pr[4];
					if(stmn>st[51]||yen <act.pr[4]){cn=0;en=null;break;}
				}

				trl();
			}else{
			if(!act.ons()){en=null;break;}
			a=1;
			//lop = tnen();
			if(slb==1){tbox();}else{
				if(dstn(nps,vc)>10){kck();}else{srt();}
				trl();
			}

			}
			}else{cn=0;}
			break;

			case 12:
			int xp= Mathf.FloorToInt(wn.x/2);
			int zp= Mathf.FloorToInt(wn.z/2);
			if(zp>139){zp=139;}if(xp>139){xp=139;}
			if(wn.y+hift < date.izm[xp,zp].x && wn.y+hift < date.izm[xp,zp+1].x && wn.y+hift < date.izm[xp+1,zp].x && wn.y+hift < date.izm[xp+1,zp+1].x){
			rb.Sleep();
			otpr(10);
			}

			if(st[54]==1&&life>0){
				cn=0;
				a=0;
				c=0;
				en=null;
				//rb.constraints = RigidbodyConstraints.FreezeRotation;
				transform.eulerAngles = Vector3.zero;
				switch(st[5]){
				case 0: gameObject.tag = ("glp1");break;
				case 1: gameObject.tag = ("glp2");break;
				case 2: gameObject.tag = ("glp3");break;
				}
			}
			if(st[58]==1&&stmn>0){
				cn=0;
				a=0;
				c=0;
				en=null;
				//rb.constraints = RigidbodyConstraints.FreezeRotation;
				transform.eulerAngles = Vector3.zero;
				switch(st[5]){
				case 0: gameObject.tag = ("glp1");break;
				case 1: gameObject.tag = ("glp2");break;
				case 2: gameObject.tag = ("glp3");break;
				}
			}

			break;

		}

		//fgon();
		if(life<0){
			
			if(cn!=5){
			gameObject.tag =("rbd");
			cn = 5;
			dr = 9;
			en = null;
			otpr(3);
			}
		}else{
		wtin();
		rote();
		wn = transform.eulerAngles;
		wn.x=0;
		wn.z=0;
		transform.eulerAngles = wn;
		if(st[60]>0){stmn -= st[60]*0.001f;}
		if(stmn<=0){
			stmn=0;
			switch(st[58]){
				case 0:cn=5;en=null;break;
				case 1:cn=12;dr=9;break;//rb.constraints = RigidbodyConstraints.None;
				case 2:life -=st[59]*0.001f;
				break;
			}
		}
		if(cn!=10&&cn!=11){
		if(st[66]>stmn){
			switch(st[67]){
				case 1:
				sarcb(false);
				break;
				case 2:
				sarci(false);
				break;
				
			}
		}
		if(cn!=2&&st[65]>life){
			switch(st[64]){
				case 0:
					rester = null;
					Collider[] yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,4096);
					for(i=0;i<yu.Length;i++){
						if(yu[i].tag == ("camp")){
							wn = yu[i].transform.position;
							if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
								if(rester!=null && f>dstn(wn,vc)){
									f = dstn(wn,vc);
									rester = yu[i].gameObject;
								}else if(rester==null){rester = yu[i].gameObject;cn=2;c=0;slb=1;f = dstn(wn,vc);}
								}
						}
					}
					if(rester!=null){act = rester.transform.parent.gameObject.GetComponent<blds>();
					tbit(vc,rester.transform.position);enlp = rester.transform.position;
					en = rester;
					}else{

					}//cheb();}
				break;
				case 1:
				sarcb(true);
				break;
				case 2:
				sarci(true);
				break;

			}
		}
		}

		}


	}
	void wkms(){
		switch(st[63]){
			case 0:
			if(!loc){
				if(dstn(enlp,vc) < 5){
					transform.localScale = Vector3.zero;
					transform.parent = en.transform;
					rb.Sleep();
					loc=true;
				}else{
					if(slb==1){tbox();}else{
						if(dstn(enlp,vc) > 5){kck();}else{srt();}
						trl();
					}
					a=1;
				}
			}else{
				count+=date.pt+1;
				if(count>100){yen += act.wk();count=0;}
				if(st[20+date.tm]!=1||!act.ons()||en==null){cn=0;en=null;transform.parent=null;transform.localScale = lsc;loc=false;}

				}	
			break;
			case 2:
				if(dstn(enlp,vc) < 5){
					if(dstn(en.transform.position,vc)<5){
					yen += (int)en.GetComponent<itm>().ouf(49);
					Destroy(en);
					cn=0;
					otpr(8);
					}else{srt();trl();}
				}else{
					if(slb==1){tbox();}else{
						if(dstn(enlp,vc) > 5){kck();trl();
						}
					}
					a=1;
				}
			break;
			case 3:
				if(dstn(enlp,vc) < 5){
					yen += (int)en.GetComponent<itm>().ouf(49);
					Destroy(en);
					cn=0;
					otpr(6);
				}else{
					if(slb==1){tbox();}else{
						if(dstn(enlp,vc) > 5){kck();}else{srt();}
						trl();
					}
					a=1;
				}
			break;
			case 4:
				if(dstn(enlp,vc) < 5){
					rlo--;
					if(rlo<0){
					en.transform.parent.gameObject.GetComponent<blds>().damg(10);
					rlo=100;
					}
					a=4;
				}else{
					if(slb==1){tbox();}else{
						if(dstn(enlp,vc) > 5){kck();}else{srt();}
						trl();
					}
					a=1;
				}
			break;

		}
	}
	public void contr(){
		if(Input.anyKey){
		wi=60;
//		rb.AddForce(transform.forward*(Input.GetAxis("Vertical")*st[4]));
		if(Input.GetButton("Vertical")){
		Vector3 cp = Camera.main.transform.forward;
		cp.y=0;
		rb.AddForce(cp*Input.GetAxis("Vertical")*st[4]);
		a=1;
		}
		if(Input.GetButton("Horizontal")){
		Vector3 cp = Camera.main.transform.right;
		cp.y=0;
		rb.AddForce(cp*Input.GetAxis("Horizontal")*st[4]);
		a=1;
		}
		if(rb.velocity!=Vector3.zero){
		transform.rotation = Quaternion.LookRotation(rb.velocity);}
		//rb.AddForce(transform.right*(Input.GetAxis("Horizontal")*st[4]));
		//transform.Rotate(Vector3.up * Input.GetAxis("Horizontal")*2.5f);
		wn = transform.eulerAngles;
		wn.x=0;
		transform.eulerAngles = wn;
		if(Input.GetMouseButton(0)){
			if(dr!=4){
			dr=4;
			rb.velocity = Vector3.zero;
			Ray r = new Ray(vc,transform.forward);
			RaycastHit h;
			if(Physics.Raycast(r,out h,size,1024)){
				h.collider.gameObject.GetComponent<rovoko>().rbb(st[53],gameObject);
			}
			}
		}
		/*
		if(rlo <= 0 && ad>0){
			if(ddgn == null){
				GameObject g = Instantiate(dgn,transform.position,transform.rotation);
				g.transform.position += transform.forward*(size+1);
				ad--;
				rlo = st[10];
			}else{
				GameObject k = Instantiate(ddgn,transform.position,transform.rotation);	
				k.transform.position += transform.forward*(size+1);
				k.SetActive(true);
				ad--;
				rlo = st[10];
			}
		}
		if(ad <=0){ad = st[11];rlo = st[12];}
		*/
		
		if(Input.GetMouseButtonUp(0)){
			//a=0;c=0;
		}
		if(Input.GetButtonDown("Jump")){
			if(Physics.Raycast(new Ray(transform.position,Vector3.down),out h,hift*1.1f,lsk)){
				if(h.collider.tag == ("zimen")){
					Vector3 v = rb.velocity + new Vector3(0,7+(2f*size),0);
					rb.velocity = v;
					dr=5;
					c=0;
				}
			}
		}
		}else{
			wi--;
			if(a==0 && wi<0){c=0;wi=lm[0]+60;}
		}
		//if(rlo>0){rlo--;}
		trl();
	}

	void scjl(){
	
		nps = new Vector3(UnityEngine.Random.Range(0,280),0,UnityEngine.Random.Range(0,280));
		nps.y = date.izm[(int)(nps.x/2),(int)(nps.z/2)].z+hift;
		
		if(bw[(int)(nps.x/2),(int)(nps.z/2)]){
		//chpt();
		tbit(vc,nps);

		wi = 2400;
		cn=1;
		}else{
		wi = UnityEngine.Random.Range(240,800);
			cn = 7;
			c=0;
			otpr(11);
		}

	}

	void tbit(Vector3 ip,Vector3 op){
		xy[0] = (int)(ip.x/4f);
		xy[1] = (int)(ip.z/4f);
		xy[2] = (int)(op.x/4f);
		xy[3] = (int)(op.z/4f);
		enlp.x = xy[2]*4;
		enlp.z = xy[3]*4; 
		tnsk = new Vector3[71,71];
		bm = new int[71,71];
		for(int i=0;i<70;i++){
			for(int j=0;j<70;j++){
				tnsk[i,j].z =  (Mathf.Abs(xy[2]-i) + Mathf.Abs(xy[3] - j))*2;
				if(bw[i*2,j*2]&&bw[(i*2)+1,j*2]&&bw[i*2,(j*2)+1]&&bw[(i*2)+1,(j*2)+1]){
				tnsk[i,j].x = 
				(date.izm[1+(i*2),1+(j*2)].x+date.izm[1+(i*2),j*2].x+
				date.izm[i*2,1+(j*2)].x+date.izm[(i*2),(j*2)].x)/4f;
				}else{
				tnsk[i,j].x = 	50 + (date.izm[1+(i*2),1+(j*2)].x+date.izm[1+(i*2),j*2].x+
				date.izm[i*2,1+(j*2)].x+date.izm[(i*2),(j*2)].x)/4f;	
				}
				tnsk[i,j].y = 0;
			}
		}
		for(int i=0;i<70;i++){
			tnsk[i,70].z =  (Mathf.Abs(xy[2]-i) + Mathf.Abs(xy[3] - 70))*2;
			if(bw[i*2,140]&&bw[(i*2)+1,140]){
			tnsk[i,70].x = 
				(date.izm[(i*2),140].x+date.izm[(i*2)+1,140].x)/2f;
			}else{
				tnsk[i,70].x = 50 + (date.izm[(i*2),140].x+date.izm[(i*2)+1,140].x)/2f;	
			}
			tnsk[i,70].y = 0;
			tnsk[70,i].z =  (Mathf.Abs(xy[2]-70) + Mathf.Abs(xy[3] - i))*2;
			if(bw[140,i*2]&&bw[140,(i*2)+1]){
			tnsk[70,i].x = 
				(date.izm[140,i*2].x+date.izm[140,(i*2)+1].x)/2f;
			}else{
				tnsk[70,i].x = 50 + (date.izm[140,i*2].x+date.izm[140,(i*2)+1].x)/2f;	
			}
			tnsk[70,i].y = 0;
		}
		bm[xy[0],xy[1]] = 1;		
		tnsk[xy[0],xy[1]].y = 1;
		cnt = new List<int>();
		cnt.Add(xy[0]);
		cnt.Add(xy[1]);
		slb=1;
		pk=0;
	}

    void tbox(){
    	a=0;
		int i=0;
		int j=0;
		int ii=0;
		int jj=0;
		for(int inf=0;inf<5;inf++){
		ii = cnt[pk];
		jj = cnt[pk+1];
		cnt.RemoveAt(pk+1);
		cnt.RemoveAt(pk);
		for(i = -1+ii; i < 2+ii; i++){
			for(j = -1+jj; j < 2+jj; j++){

			if(i>=0 && i <71 && j>=0 && j <71 && bm[i,j] == 0){ 
				if(tnsk[i,j].x < tnsk[ii,jj].x+1f)
				{
				tnsk[i,j].y = tnsk[ii,jj].y+1f;
				//tnsk[i,j].x = tnsk[i,j].z + tnsk[i,j].y;
				bm[i,j] = 1;
				cnt.Add(i);
				cnt.Add(j);
				if(i==xy[2]&&j==xy[3]){slb=2;bm[ii,jj]=2;chbk();return;}
				}else{}
			}
			

			}
		}
		bm[ii,jj]=2;
		if(cnt.Count>1){pk=0;
		for(int s=2;cnt.Count>s;s+=2){
			if(tnsk[cnt[s],cnt[s+1]].z < tnsk[cnt[pk],cnt[pk+1]].z || (tnsk[cnt[s],cnt[s+1]].z <= tnsk[cnt[pk],cnt[pk+1]].z && tnsk[cnt[s],cnt[s+1]].y < tnsk[cnt[pk],cnt[pk+1]].y)){
				pk=s;
			}
		}
		}else{slb=2;return;}
		}
//		end:
	}
	void chbk(){
		int i=0;
		int j=0;
		int ii=xy[2];
		int jj=xy[3];
		for(int inf=0;inf<20000;inf++){

		for(i = -1+ii; i < 2+ii; i++){
			for(j = -1+jj; j < 2+jj; j++){
			if(i>=0 && i <71 && j>=0 && j <71 && bm[i,j] == 2){
				if(tnsk[i,j].y < tnsk[ii,jj].y){
				ii=i;
				jj=j;
				bm[i,j]=3;
				if(i==xy[0]&&j==xy[1]){return;}
				goto to;
				}
			}
			}
		}
		to:;
		}
	}	
	Vector3 wrvc(){
		int px = (int)(vc.x/4f);
		int pz = (int)(vc.z/4f);
		Vector3 vv = Vector3.zero;
		float fs = 0;
		tnsk[px,pz].x += 0.2f;
		if(tnsk[px,pz].x>100){cn=0;en=null;}
		for(int k=-1;k<2;k++){
			for(int p=-1;p<2;p++){
			if(px+k>=0 && pz+p>=0 && px+k < 71 && pz+p < 71){
				if(bm[px+k,pz+p]==3 && fs < tnsk[px+k,pz+p].y){
					vv.x = k;
					vv.z = p;
					fs = tnsk[px+k,pz+p].y;
					//return vv ;
					if(date.izm[(int)(vc.x/2)+k,(int)(vc.z/2)+p].x>vc.y-hift+0.1f){
						if(Physics.SphereCast(vc,hift,Vector3.down,out h,1f,lsk)){dr=5;a=2;c=0;rb.velocity=new Vector3(0,7+(2f*size),0);}
/*						if(date.izm[(int)(vc.x/2)+k,(int)(vc.z/2)+p].x>vc.y+hift){
							cn=0;
							slb=0;
							a=0;
						}
*/					}

				}

			}
		}
		}
		if(vv == Vector3.zero){
				if(en!=null){
				vv = enlp-vc;
				vv.y=0;
				}else{
				vv = nps-vc;
				vv.y=0;	
				}

				if(Physics.SphereCast(vc,hift,Vector3.down,out h,1f,lsk)){dr=5;a=2;c=0;rb.velocity=new Vector3(0,7+(2f*size),0);}
		}

		//tbit(new Vector3(xy[0]*4,0,xy[1]*4),new Vector3(xy[2]*4,0,xy[3]*4));}
		return  vv;

	}

	void cah(){
			if(en==null){
				Collider[] yu;
				switch (st[20+date.tm]){
					case 0:
					//sarci();
					//if(en==null){sarcb();}
					if(en==null){scjl();}
					break;
					case 3:
					yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,4096);
					for(i=0;i<yu.Length;i++){
						if(yu[i].tag == ("camp")){
							wn = yu[i].transform.position;
							if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
								if(en!=null && f>dstn(wn,vc)){
									f = dstn(wn,vc);
									en = yu[i].gameObject;
								}else if(en==null){en = yu[i].gameObject;cn=2;slb=1;c=0;f = dstn(en.transform.position,vc);}
								}
						}
					}
					if(en!=null){act = en.transform.parent.gameObject.GetComponent<blds>();
					tbit(vc,en.transform.position);}//cheb();}
					if(en==null){scjl();}
					break;
					case 1:
						switch(st[63]){
						case 0:
						yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,4096);
						for(i=0;i<yu.Length;i++){
							if(yu[i].tag == ("wk")){
								wn = yu[i].transform.position;
								if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
									if(en!=null && f>dstn(wn,vc)){
										f = dstn(wn,vc);
										en = yu[i].gameObject;
									}else if(en==null){en = yu[i].gameObject;cn=3;slb=1;c=0;f = dstn(en.transform.position,transform.position);}
								}
							}
						}
						if(en!=null){act = en.transform.parent.gameObject.GetComponent<blds>();
						tbit(vc,en.transform.position);}//cheb();}
						if(en==null){scjl();}
						break;
						case 2:
						yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,8192);
						for(i=0;i<yu.Length;i++){
							if(yu[i].tag == ("coin")){
								wn = yu[i].transform.position;
								if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
									if(en!=null && f>dstn(wn,vc)){
										f = dstn(wn,vc);
										en = yu[i].gameObject;
									}else if(en==null){en = yu[i].gameObject;cn=3;c=0;slb=1;f = dstn(en.transform.position,transform.position);}
								}
							}
						}
						if(en!=null){tbit(vc,en.transform.position);}else{scjl();}
						break;
						case 3:
						yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,8192);
						for(i=0;i<yu.Length;i++){
							if(yu[i].tag == ("enag")){
								wn = yu[i].transform.position;
								if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
									if(en!=null && f>dstn(wn,vc)){
										f = dstn(wn,vc);
										en = yu[i].gameObject;
									}else if(en==null){en = yu[i].gameObject;cn=3;c=0;slb=1;f = dstn(en.transform.position,transform.position);}
								}
							}
						}
						if(en!=null){tbit(vc,en.transform.position);}else{scjl();}
						break;
						case 4:
						yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,4096);
						for(i=0;i<yu.Length;i++){
							if(yu[i].tag == ("tree")){
								wn = yu[i].transform.position;
								if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].z){
									if(en!=null && f>dstn(wn,vc)){
										f = dstn(wn,vc);
										en = yu[i].gameObject;
									}else if(en==null){en = yu[i].gameObject;cn=3;c=0;slb=1;f = dstn(en.transform.position,transform.position);}
								}
							}
						}
						if(en!=null){tbit(vc,en.transform.position);}else{scjl();}
						break;
						}
					break;
					case 2:
					gameObject.layer = 0;
					yu = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,100,140),Quaternion.identity,1024);
					gameObject.layer = 10;
					f=0;
					//yu = Physics.OverlapBox(new Vector3((st[0]+st[1])/2,50,(st[2]+st[3])/2),new Vector3((st[1]+st[0])*2,100,(st[3]+st[2])*2),Quaternion.identity,nest);
					for(i=0;i<yu.Length;i++){
						if( (st[6]==1 && yu[i].tag == ("glp1")) || (st[7]==1 && yu[i].tag == ("glp2")) ||(st[8]==1 && yu[i].tag == ("glp3"))){
							wn = yu[i].transform.position;
							if(bw[(int)(wn.x/2),(int)(wn.z/2)] && wn.y > date.izm[(int)(wn.x/2),(int)(wn.z/2)].x+1){
								if(en!=null && f>dstn(wn,vc)){
									f=dstn(wn,vc);
									en = yu[i].gameObject;
								}else if(en==null){en = yu[i].gameObject;cn=4;c=0;f=dstn(en.transform.position,vc);}
							}
						}
					}
					if(en!=null){
						otpr(5);
						tbit(vc,en.transform.position);
						acr = en.GetComponent<rovoko>();
						}else{scjl();}
					break;
				}
			}else{en=null;}
	}
	void kck(){
		lop = wrvc();
		lop = lop.normalized;
		if(rb.velocity!=Vector3.zero){transform.rotation = Quaternion.LookRotation(rb.velocity);
			}else{
				if(Physics.Raycast(new Ray(transform.position,Vector3.down),out h,hift*1.1f,lsk)){
				rb.velocity += new Vector3(0,size,0);
				dr=5;
				c=0;
				}
			}
		if(dr!=1){rb.AddForce(lop * st[4]);}else{rb.AddForce(lop * st[13]);}

	}
	void trl(){
		wn = transform.eulerAngles;
		wn.x=0;
		transform.eulerAngles = wn;
	}
	void srt(){
		transform.LookAt(en.transform);
		if(dr!=1){rb.AddForce(transform.forward * st[4]);}else{rb.AddForce(transform.forward  * st[13]);}
	}
	float dstn(Vector3 v,Vector3 c){
		return (Mathf.Abs(v.x - c.x) + Mathf.Abs(v.z - c.z));
	}
/*
	void chpt(){
		Vector3 rdm =vc;
		int px = (int)(rdm.x)/2;
		int pz = (int)(rdm.z)/2;
		tnsk = new Vector3[141,141];
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
				tnsk[i,j].x = date.izm[i,j].x;//*(nps.y-date.izm[i,j].x);
				tnsk[i,j].z = (Mathf.Abs(nps.x - (i+i)) + Mathf.Abs(nps.z - (j+j)))/20;
				if(st[0]<i+i && st[1]>i+i && st[2]<j+j && st[3]>j+j){tnsk[i,j].y = 0;}else{tnsk[i,j].y = 2;}
				if(!bw[i,j]){tnsk[i,j].z += 50000;}
			}
		}
	}

	Vector3 tnski(){
		Vector3 v = Vector3.zero;
		Vector3 vs = Vector3.zero;
		int xp = (int)(transform.position.x)/2;		
		int zp = (int)(transform.position.z)/2;
		float yp =vc.y;
		tnsk[xp,zp].y+=2f;
		if(tnsk[xp,zp].y>100){
			if(Physics.Raycast(new Ray(transform.position,Vector3.down),out h,hift*1.1f,lsk)){dr=5;a=2;c=0;rb.velocity=new Vector3(0,5*size,0);}
		}
		f = tnsk[xp,zp].y+tnsk[xp,zp].z;

		for(int k=-2;k<2;k++){
			for(int p=-2;p<2;p++){
				if(xp+k>=0 && zp+p>=0 && xp+k <= 140 && zp+p <= 140){
				if(tnsk[xp+k,zp+p].x  < yp + 2){
				  if(tnsk[xp+k,zp+p].z+tnsk[xp+k,zp+p].y <f){f = tnsk[xp+k,zp+p].y+tnsk[xp+k,zp+p].z;v.x=k;v.z=p;}
				  	}
				tnsk[xp+k,zp+p].y+=5f;
				}
	
			}
		}
		for(int k=-5;k<5;k++){
			for(int p=-5;p<5;p++){
				if(xp+k>=0 && zp+p>=0 && xp+k <= 140 && zp+p <= 140){
				if(tnsk[xp+k,zp+p].z+tnsk[xp+k,zp+p].y <f){f = tnsk[xp+k,zp+p].y+tnsk[xp+k,zp+p].z;v.x=k;v.z=p;}
				}
			}
		}
		return v;
	}

	void cheb(){
		Vector3 rdm = transform.position;
		Vector3 ep = en.transform.position;
		int px = (int)(rdm.x)/2;
		int pz = (int)(rdm.z)/2;
		wi=40;
		wct=0;
		tnsk = new Vector3[141,141];
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
				tnsk[i,j].x = date.izm[i,j].x;//*(nps.y-date.izm[i,j].x);
				tnsk[i,j].z = (Mathf.Abs(ep.x - (i+i)) + Mathf.Abs(ep.z - (j+j)))/20;
				if(ep.x-5<i+i && ep.x+5>i+i && ep.z-5<j+j && ep.z+5 >j+j){tnsk[i,j].y = 0;}else{tnsk[i,j].y = 2;}
				if(!bw[i,j]){tnsk[i,j].z += 50000;}
			}
		}
	}
	
	Vector3 tnen(){
		Vector3 v = Vector3.zero;
		int xp = (int)(transform.position.x)/2;		
		int zp = (int)(transform.position.z)/2;
		float yp = transform.position.y;
		wi=40;
		wct++;
		tnsk[xp,zp].y+=2f;
		if(tnsk[xp,zp].y>100){
			if(Physics.Raycast(new Ray(transform.position,Vector3.down),out h,hift*1.1f,lsk)){dr=5;a=2;c=0;rb.velocity=new Vector3(0,5*size,0);}
		}
		f = tnsk[xp,zp].y+tnsk[xp,zp].z;

		for(int k=-2;k<2;k++){
			for(int p=-2;p<2;p++){
				if(xp+k>=0 && zp+p>=0 && xp+k <= 140 && zp+p <= 140){
				if(tnsk[xp+k,zp+p].x  < yp + 1){
				  if(tnsk[xp+k,zp+p].z+tnsk[xp+k,zp+p].y <f){f = tnsk[xp+k,zp+p].y+tnsk[xp+k,zp+p].z;v.x=k;v.z=p;}
				  	}
				tnsk[xp+k,zp+p].y+=5f;
				}
			}
		}
		if(v==Vector3.zero){
		for(int k=-5;k<5;k++){
			for(int p=-5;p<5;p++){
				if(xp+k>=0 && zp+p>=0 && xp+k <= 140 && zp+p <= 140){
				  if(tnsk[xp+k,zp+p].z+tnsk[xp+k,zp+p].y <f){f = tnsk[xp+k,zp+p].y+tnsk[xp+k,zp+p].z;v.x=k;v.z=p;}
				}
			}
		}
		}
		return v;
	}
*/


	public int[] sit(){
		return st;
	}

	public void dng(GameObject g){
		ddgn = g;
	}
	public void dngnull(){
		ddgn = null;
	}

	public void wep(GameObject g){
		wepn = g;
	}

	void wtin(){
		wn = transform.position;
		int xp= Mathf.FloorToInt(wn.x/2);
		int zp= Mathf.FloorToInt(wn.z/2);

		if((wn.y+hift < date.umi) ||  (date.izm[xp,zp].y>0 && date.izm[xp,zp].z> wn.y+hift) ){
			rb.AddForce(0,st[14]*0.98f,0);
			life -= st[15]*0.001f;
			if(dr==0){
				dr=1;
				c=0;
				otpr(9);
			}
		}
		if(cn!=8){
			if(zp>139){zp=139;}if(xp>139){xp=139;}
			if(wn.y+hift < date.izm[xp,zp].x && wn.y+hift < date.izm[xp,zp+1].x && wn.y+hift < date.izm[xp+1,zp].x && wn.y+hift < date.izm[xp+1,zp+1].x){
			cn=8;
			dr=9;
			bc.isTrigger=true;
			otpr(10);
			}
		}

	}

	void rote(){
		switch(dr){
		case 0:
		if(lm[a]<=c){c=0;}
		for(i=0;i<b;i++){
				switch(a){
				case 0:
				gc[i].transform.localEulerAngles = rm0[i,c];
				break;
				case 1:
				gc[i].transform.localEulerAngles = rm1[i,c];
				break;
				case 4:
				gc[i].transform.localEulerAngles = rm4[i,c];
				break;
				case 6:
				gc[i].transform.localEulerAngles = rm6[i,c];
				break;
				
			}
		}

		switch(a){
				case 0:
				gc[0].transform.localPosition = rm0[b,c] * size;
				break;
				case 1:
				gc[0].transform.localPosition = rm1[b,c] * size;
				break;
				case 4:
				gc[0].transform.localPosition = rm4[b,c] * size;
				break;
				case 6:
				gc[0].transform.localPosition = rm6[b,c] * size;
				break;
				}
		c++;
		break;
		case 1:
			for(i=0;i<b;i++){
			if(lm[3]>c){
			gc[i].transform.localEulerAngles = rm3[i,c];
			}else{
			dr=0;
			c=0;
			}
		}
		gc[0].transform.localPosition = rm3[b,c] * size;
		c++;
		break;	
		case 2:
			for(i=0;i<b;i++){
			if(lm[7]>c){
			gc[i].transform.localEulerAngles = rm7[i,c];
			}else{
			c=0;
			}
		}
		gc[0].transform.localPosition = rm7[b,c] * size;
		c++;
		break;
		case 3:
		for(i=0;i<b;i++){
			if(lm[5]>c){
			gc[i].transform.localEulerAngles = rm5[i,c];
			}else{
			dr=0;
			c=0;
			otpr(2);
			}
		}
		gc[0].transform.localPosition = rm5[b,c] * size;
		c++;
		break;
		case 4:
		for(i=0;i<b;i++){
			if(lm[4]>c){
			gc[i].transform.localEulerAngles = rm4[i,c];
			}else{
			dr=0;
			c=0;
			a=0;
			}
		}
		gc[0].transform.localPosition = rm4[b,c] * size;
		c++;
		break;
		case 5:
		for(i=0;i<b;i++){
			if(lm[2]>=c){
			gc[i].transform.localEulerAngles = rm2[i,c];
			}else{
			if(Physics.Raycast(new Ray(transform.position,Vector3.down),out h,size*1.1f,lsk)){
				dr=0;
				a=0;
				c=0;
				otpr(0);
			}
			}
		}
		if(lm[2]>c){
		gc[0].transform.localPosition = rm2[b,c] * size;
		}
		c++;
		break;
		case 9:
		break;
		}
	}

	
	void mift(){
		if(en.gameObject.tag==("rbd")){cn=0;return;}
		if(dr!=4){
		if(dstn(vc,en.transform.position)< size + 4){
			enlp = en.transform.position;
			transform.LookAt(en.transform);
			if(dr!=4){rlo--;a=0;}
			if(rlo<0){
				dr=4;
				c=0;
				rb.velocity = Vector3.zero;
				rlo = st[10];
				acr.rbb(st[53],gameObject);
				loc=true;
			}
		}else{
			if(slb==1){tbox();}else{
				transform.LookAt(en.transform);
				Ray r = new Ray(vc,transform.forward);
				RaycastHit h;
				if(Physics.Raycast(r,out h,Mathf.Infinity,1280)){
				if(h.collider.gameObject.tag==("zimen")){
					kck();		
					}
				if(h.collider.gameObject==en){
					a=1;
					if(dr!=1){rb.AddForce(transform.forward * st[4]);}else{rb.AddForce(transform.forward * st[13]);}
				}
				}
				if(dstn(enlp,vc)<5 && dstn(en.transform.position,vc)>5){cn=0;}
				trl();
			}
		}			
		}
	}
	void mibt(){
//		if(Physics.Raycast(vc,transform.forward,out h, st[53])){
//		if(h.collider.gameObject == en){
		if(dstn(vc,en.transform.position)<=st[53]){
				enlp = en.transform.position;
				if(a==4){
						rlo--;
					if(rlo <= 0){
						if(ad>0){
							ad--;
							transform.LookAt(en.transform);
							Ray r = new Ray(vc,transform.forward);
							RaycastHit h;
							if(Physics.Raycast(r,out h,Mathf.Infinity,1280)){
								if(h.collider.gameObject.tag==("zimen")){
									
								}
							}
							if(ddgn == null){
							GameObject g = Instantiate(dgn,transform.position,transform.rotation);
							wn = en.transform.position-transform.position;
							g.transform.position += wn.normalized*(1+size);
							g.transform.localScale = Vector3.one*(size*0.2f);

							}else{
							GameObject k = Instantiate(ddgn,transform.position,transform.rotation);	
							wn = en.transform.position-transform.position;
							k.transform.position += wn.normalized*(1+size);
							k.transform.localScale = Vector3.one*(size*0.2f);
							k.SetActive(true);
							}
							rlo = st[10];
						}else{
							ad = st[11];
							rlo = st[12];
							if(en.gameObject.tag==("rbd")){cn=0;}
					}
				}
			}else{
				a=4;
				c=0;
			}
		}else{
			if(a==1){
				a=1;
				c=0;		
				}

			if(dstn(vc,enlp)>=10){
			transform.LookAt(enlp);
			if(dr!=1){rb.AddForce(transform.forward * st[4]);}else{rb.AddForce(transform.forward * st[13]);}
			}else{
				cn=0;c=0;
			}
		}			
		trl();
	}

	public void strt(GameObject[] g,int[] n,int m){
//		Array.Copy(vec,0,rm,0,59400);
		
		g.CopyTo(gc,0);
		n.CopyTo(lm,0);
		b = m;
	}
	public void rbon(GameObject[] g,int[] n,int m,int[] s){
/*		int u=0;
		for(int i=0;i<9;i++){
			for(int o=0;o<22;o++){
				for(int p=0;p<300;p++){
					rm[i,o,p] = vec[u];
					u++;
				}
			}
		}
*/
		g.CopyTo(gc,0);
		n.CopyTo(lm,0);
		b = m;
		s.CopyTo(st,0);
	}

	public Vector3[,] ouc(int n){
		switch(n){
		case 0:	return rm0;
		case 1:	return rm1;
		case 2:	return rm2;
		case 3:	return rm3;
		case 4:	return rm4;
		case 5:	return rm5;
		case 6:	return rm6;
		case 7:	return rm7;
		case 8:	return rm8;
		default: Vector3[,] v = new Vector3[1,1]; return v;
		}
	
	}
	public Vector3[,,] oucld(){
		Vector3[,,] vec = new Vector3[9,22,300];
		int n=0;
		int k=0;
		for(n=0;n<b;n++){
			for(k=0;k<300;k++){
			if(lm[0]>=k){vec[0,n,k] += rm0[n,k];}
			if(lm[1]>=k){vec[1,n,k] += rm1[n,k];}
			if(lm[2]>=k){vec[2,n,k] += rm2[n,k];}
			if(lm[3]>=k){vec[3,n,k] += rm3[n,k];}
			if(lm[4]>=k){vec[4,n,k] += rm4[n,k];}
			if(lm[5]>=k){vec[5,n,k] += rm5[n,k];}
			if(lm[6]>=k){vec[6,n,k] += rm6[n,k];}
			if(lm[7]>=k){vec[7,n,k] += rm7[n,k];}
			if(lm[8]>=k){vec[8,n,k] += rm8[n,k];}
			}
		}
		for(n=b;n<b+1;n++){
			for(k=0;k<300;k++){
			if(lm[0]>=k){vec[0,21,k] += rm0[n,k];}
			if(lm[1]>=k){vec[1,21,k] += rm1[n,k];}
			if(lm[2]>=k){vec[2,21,k] += rm2[n,k];}
			if(lm[3]>=k){vec[3,21,k] += rm3[n,k];}
			if(lm[4]>=k){vec[4,21,k] += rm4[n,k];}
			if(lm[5]>=k){vec[5,21,k] += rm5[n,k];}
			if(lm[6]>=k){vec[6,21,k] += rm6[n,k];}
			if(lm[7]>=k){vec[7,21,k] += rm7[n,k];}
			if(lm[8]>=k){vec[8,21,k] += rm8[n,k];}
			}
		}

		return vec;
	}

	public int[] ous(){
		return st;
	}
	public int oub(){
		return b;
	}
	public GameObject[] ougc(){
		return gc;
	}
	public int ougcl(int n){
		if(gc[n].GetComponent<BoxCollider>()!=null){
		return 1;
		}
		if(gc[n].GetComponent<SphereCollider>()!=null){
		return 2;
		}
		if(gc[n].GetComponent<CapsuleCollider>()!=null){
		return 3;
		}

		return 0;
	}

	public int[] oulm(){
		return lm;
	}
	public int oulc(int n){
		return lm[n]+1;
	}
	

	public GameObject oug(){
		if(ddgn!=null){
		return ddgn;
		}else{
		return null;
		}
	}
	public void ins(int[] s){
		s.CopyTo(st,0);
	}

	public void inc(Vector3[,,] vec,int[] s){
		/*		
		for(a=0;a<9;a++){
			for(int i=0;i<22;i++){
				for(c=0;c<300;c++){
					rm[a,i,c] = new Vector3(vc[a,i,c].x,vc[a,i,c].y,vc[a,i,c].z);
				}
			}
		}a=0;c=0;i=0;
		*/
		//Array.Copy(vec,0,rm,0,59400);
		rm0 = new Vector3[b+1,lm[0]+1];
		rm1 = new Vector3[b+1,lm[1]+1];
		rm2 = new Vector3[b+1,lm[2]+1];
		rm3 = new Vector3[b+1,lm[3]+1];
		rm4 = new Vector3[b+1,lm[4]+1];
		rm5 = new Vector3[b+1,lm[5]+1];
		rm6 = new Vector3[b+1,lm[6]+1];
		rm7 = new Vector3[b+1,lm[7]+1];
		rm8 = new Vector3[b+1,lm[8]+1];
		int n=0;
		int y=0;
		for(n=0;n<b;n++){
			for(y=0;y<300;y++){
				if(lm[0]>=y){rm0[n,y] += vec[0,n,y];}
				if(lm[1]>=y){rm1[n,y] += vec[1,n,y];}
				if(lm[2]>=y){rm2[n,y] += vec[2,n,y];}
				if(lm[3]>=y){rm3[n,y] += vec[3,n,y];}
				if(lm[4]>=y){rm4[n,y] += vec[4,n,y];}
				if(lm[5]>=y){rm5[n,y] += vec[5,n,y];}
				if(lm[6]>=y){rm6[n,y] += vec[6,n,y];}
				if(lm[7]>=y){rm7[n,y] += vec[7,n,y];}
				if(lm[8]>=y){rm8[n,y] += vec[8,n,y];}
			}
		}
		for(n=b;n<b+1;n++){
			for(y=0;y<300;y++){
				if(lm[0]>=y){rm0[n,y] += vec[0,21,y];}
				if(lm[1]>=y){rm1[n,y] += vec[1,21,y];}
				if(lm[2]>=y){rm2[n,y] += vec[2,21,y];}
				if(lm[3]>=y){rm3[n,y] += vec[3,21,y];}
				if(lm[4]>=y){rm4[n,y] += vec[4,21,y];}
				if(lm[5]>=y){rm5[n,y] += vec[5,21,y];}
				if(lm[6]>=y){rm6[n,y] += vec[6,21,y];}
				if(lm[7]>=y){rm7[n,y] += vec[7,21,y];}
				if(lm[8]>=y){rm8[n,y] += vec[8,21,y];}
			}
		}
		s.CopyTo(st,0);
		//Array.Copy(vc,0,rm,0,59400);
	}
	public void inmta(Vector3[] v0,Vector3[] v1,Vector3[] v2,Vector3[] v3,Vector3[] v4,Vector3[] v5,Vector3[] v6,Vector3[] v7,Vector3[] v8){
		rm0 = new Vector3[b+1,lm[0]+1];
		rm1 = new Vector3[b+1,lm[1]+1];
		rm2 = new Vector3[b+1,lm[2]+1];
		rm3 = new Vector3[b+1,lm[3]+1];
		rm4 = new Vector3[b+1,lm[4]+1];
		rm5 = new Vector3[b+1,lm[5]+1];
		rm6 = new Vector3[b+1,lm[6]+1];
		rm7 = new Vector3[b+1,lm[7]+1];
		rm8 = new Vector3[b+1,lm[8]+1];
		int n=0;
		int y=0;
		int k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[0];y++){
				rm0[n,y] += v0[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[1];y++){
				rm1[n,y] += v1[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[2];y++){
				rm2[n,y] += v2[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[3];y++){
				rm3[n,y] += v3[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[4];y++){
				rm4[n,y] += v4[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[5];y++){
				rm5[n,y] += v5[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[6];y++){
				rm6[n,y] += v6[k];
				k++;
			}
		}
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[7];y++){
				rm7[n,y] += v7[k];
				k++;
			}
		}		
		k=0;
		for(n=0;n<b+1;n++){
			for(y=0;y<=lm[8];y++){
				rm8[n,y] += v8[k];
				k++;
			}
		}


	}

	public void inmt0(Vector3[,] vec,int s){
		rm0 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm0,0,(b+1)*s);
	}
	public void inmt1(Vector3[,] vec,int s){
		rm1 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm1,0,(b+1)*s);
	}
	public void inmt2(Vector3[,] vec,int s){
		rm2 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm2,0,(b+1)*s);
	}
	public void inmt3(Vector3[,] vec,int s){
		rm3 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm3,0,(b+1)*s);
	}
	public void inmt4(Vector3[,] vec,int s){
		rm4 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm4,0,(b+1)*s);
	}
	public void inmt5(Vector3[,] vec,int s){
		rm5 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm5,0,(b+1)*s);
	}
	public void inmt6(Vector3[,] vec,int s){
		rm6 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm6,0,(b+1)*s);
	}
	public void inmt7(Vector3[,] vec,int s){
		rm7 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm7,0,(b+1)*s);
	}
	public void inmt8(Vector3[,] vec,int s){
		rm8 = new Vector3[b+1,s];
		Array.Copy(vec,0,rm8,0,(b+1)*s);
	}


/*
	public Vector3[,,] vctr(){
		return rm;
	}
	public GameObject[] gobr(){
		return gc;
	}
	public int[] nret(){
		return lm;
	}
	public int mret(){
		return b;
	}
*/



	public int[] che(){
		int[] nk = new int[3];
		nk[0] = (int)life;
		nk[1] = (int)yen;
		nk[2] = (int)stmn;

		return nk;
	}
	public void inot(AudioClip clip,float vl,int n){
		if(clip!=null){
		//acp[n] = AudioClip.Create(""+n,clip.samples,clip.channels,clip.frequency,false);
		//float[] f = new float[clip.samples * clip.channels];
		//clip.GetData(f,0);
		//acp[n].SetData(f,0);
		acp[n] = clip;
		}else{
		acp[n] = null;
		}
	}
	public AudioClip ouot(int n){
		if(acp[n]!=null){
			return acp[n];
		}else{
			return null;
		}
	}
	public void otpr(int n){
		if(acp[n]){
			ao.clip = acp[n];
			ao.Play();
		}
	}

/*
	public void OnTriggerEnter(Collider co){
		switch (scj[date.tm]){
		case 3:
		if(en == null){
			if(co.tag == ("glp1") && st[5]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
			}
			if(co.tag == ("glp2") && st[6]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
			}
			if(co.tag == ("glp3") && st[7]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
				}
		}
		break;
		}
	}

	public void OnTriggerStay(Collider co){
		switch (scj[date.tm]){
		case 3:
		if(en == null){
			if(co.tag == ("glp1") && st[5]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
			}
			if(co.tag == ("glp2") && st[6]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
			}
			if(co.tag == ("glp3") && st[7]==1){
				en = co.gameObject;
				cn=4;
				sc.enabled = false;
				}
		}
		break;
		}
	}
*/
	public void sarcb(bool b){
		//bool bh;
		//bool bs;		
		//if( ((st[50]-life)>0)){bh=true;}else{bh=false;}
		//if( ((st[52]-stmn)>0)){bs=true;}else{bs=false;}
		//Collider[] ns = Physics.OverlapCapsule(new Vector3(transform.position.x,150,transform.position.z),
		//	new Vector3(transform.position.x,0,transform.position.z),st[9],4096);
		//if(bh||bs){
		
		
		Collider[] ns = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,50,140),Quaternion.identity,4096);
				int ny=0;
				int hy=0;
				int bkn=0;

				for(int j=0;j<ns.Length;j++){
				if(b){
					if(ns[j].tag == ("itms")){
					int[] lc =  ns[j].GetComponent<blds>().ongm();
					hy =lc[5];
					if(yen>lc[4] && ny <hy){
						ny = hy;
						bkn = j;
					}
					}
				}else{
					if(ns[j].tag == ("enag")){
					int[] lc =  ns[j].GetComponent<blds>().ongm();
					hy =lc[5];
					if(yen>lc[4] && ny <hy){
						ny = hy;
						bkn = j;
					}
					}
				}
			}
				if(ny>0){
				en = ns[bkn].gameObject;
				enlp = en.transform.position;
				act = ns[bkn].GetComponent<blds>();
				cn = 11;
				tbit(vc,en.transform.position);
				//if(en!=null){tbit(vc,en.transform.position);}//cheb();}
		}
	}

	public void sarci(bool b){
	//	bool bh;
	//	bool bs;		
	//	if( ((st[50]-life)>0)){bh=true;}else{bh=false;}
	//	if( ((st[52]-stmn)>0)){bs=true;}else{bs=false;}
	//	if(bh&&bs){
		Collider[] ns = Physics.OverlapBox(new Vector3(140,50,140),new Vector3(140,50,140),Quaternion.identity,8192);
		f=100;
		float lo=100;
		int k=0;

		for(int d=0;d<ns.Length;d++){
			if(b){
			if(ns[d].tag ==("itms")){
			f = dstn(vc,ns[d].gameObject.transform.position);
			}
			}else{
			if(ns[d].tag ==("enag")){
			f = dstn(vc,ns[d].gameObject.transform.position);	
			}
			
/*
			if(bh && ns[d].tag ==("itms")){
			f = dstn(vc,ns[d].gameObject.transform.position);
			}
			if(bs && ns[d].tag ==("enag")){
			f = dstn(vc,ns[d].gameObject.transform.position);
			}
*/
		}
		if(f<lo){lo=f;k=d+1;}
		}
		if(k>0){
			en = ns[k-1].gameObject;
			enlp = en.transform.position;
			cn=10;
			tbit(vc,en.transform.position);
		}
		//if(en!=null){tbit(vc,en.transform.position);}//cheb();}
	}


	public void hit(int n){
		life += n;
		c=0;
		if(life>st[50]){life=st[50];}
		if(n <0 && dr!=4){dr=3;}
		if(n<0){otpr(1);}
	}
	public void rbb(int n,GameObject g){
		life -= Mathf.Abs(n);
		dr=3;
		c=0;
		if(n<0){otpr(1);}
		if(en != g&&cn!=4){
		if((st[6]==1 && g.tag == ("glp1")) || (st[7]==1 && g.tag == ("glp2")) ||(st[8]==1 && g.tag == ("glp3"))){
			en=g;
			cn=4;
			tbit(vc,en.transform.position);
			acr = en.GetComponent<rovoko>();
		}
		}
	}

	public void coin(int n){
		yen += n;
		if(n<0){otpr(8);}		
	}
	public void stin(int n){
		stmn += n;
		if(n<0){otpr(6);}
	}
	public void setp(int[] n){
		st = n;
		switch(st[5]){
		case 0:
		gameObject.tag = ("glp1");
		break;
		case 1:
		gameObject.tag = ("glp2");
		break;
		case 2:
		gameObject.tag = ("glp3");
		break;
		}
	}
	public void dn(GameObject g){
		dgn = g;
	}
	public void pgon(){
		cn =9;
		a=0;
		c=0;
	}
	public void pgoff(){
		cn =0;
		en=null;
		a=0;
		c=0;
	}

	public void onwk(bool[,] bl){
		//Array.Copy(bl,0,bw,0,19881);
		for(int q=0;q<141;q++){
			for(int j=0;j<141;j++){
				if(bl[q,j]){
					bw[q,j]=true;
					}else{
					bw[q,j]=false;
					}
			}
		}
	}
	public bool[,] ouwk(){
		return bw;
	}
	public GameObject ougm(){
		return gameObject;
	}
	void OnCollisionEnter(Collision co){
		if(cn==2 && en==co.gameObject && en.gameObject.tag == ("camp")){
			act = en.GetComponent<blds>();
		}
		if(cn==3 && en==co.gameObject && en.gameObject.tag == ("wk")){
			act = en.GetComponent<blds>();
		}
		if((cn==10 || cn==11) && en==co.gameObject){
			a=4;
			c=0;
		}
		if(co.gameObject.tag == ("glp1") || co.gameObject.tag == ("glp2") || co.gameObject.tag == ("glp3")){
			Vector3 vb = (transform.position-co.transform.position)*((Mathf.Abs(rb.velocity.x)+Mathf.Abs(rb.velocity.y)+Mathf.Abs(rb.velocity.z))/200);
			vb.y=0;
			co.gameObject.transform.position += vb;
		}
		if(co.gameObject.tag == ("del")){
			Destroy(gameObject);
		}
	}
	[ContextMenu ("ret")]
	public void ret(){
 	for(int i=0;i<141;i++){
 		for(int j=0;j<141;j++){
 			bw[i,j]=true;
 		}	
	}
	st[0]=0;
	st[1]=0;
	st[2]=0;
	st[3]=0;
	st[4]=18;
	st[5]=0;
	st[6]=1;
	st[7]=1;
	st[8]=1;
	st[9]=50;
	st[10]=20;
	st[11]=12;
	st[12]=240;
	st[13]=18;
	st[14]=10;
	st[15]=0;
	st[16]=100;
	st[17]=0;
	st[18]=0;
	st[19]=0;
	st[20]=0;
	st[21]=0;
	st[22]=0;
	st[23]=0;
	st[24]=0;
	st[25]=0;
	st[26]=0;
	st[27]=0;
	st[28]=0;
	st[29]=0;
	st[30]=0;
	st[31]=0;
	st[32]=0;
	st[33]=0;
	st[34]=0;
	st[35]=0;
	st[36]=0;
	st[37]=0;
	st[38]=0;
	st[39]=0;
	st[40]=0;
	st[41]=0;
	st[42]=0;
	st[43]=0;
	st[44]=0;
	st[45]=0;
	st[46]=0;
	st[47]=0;
	st[48]=0;
	st[49]=0;
	st[50]=100;
	st[51]=0;
	st[52]=100;
	st[53]=50;
	st[54]=0;
	st[55]=60;
	st[56]=-1;
	st[57]=-1;
	st[58]=0;
	st[59]=0;
	st[60]=0;
	st[61]=60;
	st[62]=3600;
	st[63]=0;
	st[64]=0;
	st[65]=0;
	st[66]=0;
	st[67]=0;
	st[68]=100;
	st[69]=10;
	
	}
}
