using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itm : MonoBehaviour {
public Rigidbody rb;
//public int[] it = new int[29];

public float[] itf = new float[59];

public bool b;
public float[] ps;
public float[] ps2;
public GameObject psit;
public GameObject psed;
public GameObject pspt;

int pi = 41;
Vector3 vc;
int i;
int x;
int z;
int ct;
bool wt = false;
	// Use this for initialization
	void Start () {
		if((int)itf[0]==0){
			rb.AddForce(transform.forward *(itf[1])*5);
			rb.AddForce(transform.right * (itf[2])*5);
			rb.AddForce(transform.up * (itf[3])*5);
		}else{
		rb.velocity = new Vector3(itf[7],itf[8],itf[9]);
		rb.AddForce(transform.forward *(itf[13])*5);
		}
		ct = (int)itf[18];
		if(pspt!=null){
			pspt.transform.localScale = transform.localScale * itf[37];
		}
		if(psed!=null){
			psed.transform.localScale = transform.localScale * itf[38];

		}

	}
	
	// Update is called once per frame
	void Update () {
		if(ct>0){
			if((int)itf[0]==0){
				rb.AddForce(transform.forward *(itf[4]));
				rb.AddForce(transform.right * (itf[5]));
				rb.AddForce(transform.up * (itf[6]));
			}else{
				rb.AddForce(new Vector3(itf[10],itf[11],itf[12]));
			}

/*
				bool g=false;
				Collider[] ns = Physics.OverlapSphere(transform.position,it[2]);
				for(i=0;i<ns.Length;i++){
					if( (it[14]==0 && ns[i].tag == ("glp1")) || (it[15]==0 && ns[i].tag == ("glp2")) || (it[16]==0 && ns[i].tag == ("glp3")) ){
						rovoko r = ns[i].GetComponent<rovoko>();
						r.hit(it[0]);
						//if(it[1]!=0){r.coin(it[1]);}
					}else if(ns[i].tag == ("zimen")){
						g = true;
					}
				}
				if(g){
				Collider[] yu = Physics.OverlapCapsule(new Vector3(transform.position.x,100,transform.position.z),
				new Vector3(transform.position.x,-20,transform.position.z),it[2],256);
				for(i=0;i<yu.Length;i++){
						if(yu[i].name != ("sot")){
						grund j = yu[i].gameObject.GetComponent<grund>();
						j.bk(transform.position,it[0],it[2]);
						}else{
						yu[i].gameObject.SendMessage("upck",transform.position);
						}
					}			
				}	
				}			
			*/
		ct--;
		if(itf[pi+4]>0){
			x = (int)(transform.position.x)/2;
			z = (int)(transform.position.z)/2;
			if((0<=x && 141>x)&&(0<=z && 141>z)){
				if((transform.position.y < date.umi) ||  transform.position.y < date.izm[x,z].z){
					if(wt==false){
					izm.sgp[(int)(transform.position.x/2f),(int)(transform.position.z/2f)].z = (rb.velocity.magnitude*0.05f)*0.1f+(transform.localScale.magnitude*0.5f);
					izm.sgp[(int)(transform.position.x/2f),(int)(transform.position.z/2f)].x = 9;
					izm.sgp[(int)(transform.position.x/2f),(int)(transform.position.z/2f)].w = izm.q;

		       		if(date.tiz<6){date.tiz=11;}
		       		wt=true;
		       		}
					if(itf[pi+12]>0){rb.AddForce(0,itf[29],0);}
					if(itf[pi+13]>0){rb.drag = itf[30]*10;}					
					}else{
					if(itf[pi+13]>0){rb.drag = itf[19];}	
					wt=false;
					}
				}
			}
		}else{
			if(itf[pi+17]>0){
			if(psit!=null){
			psit.SetActive(true);
			psit.transform.parent = null;
			}
			if(psed!=null){
			psed.SetActive(true);
			psed.transform.localScale = Vector3.one * itf[38];
			psed.transform.parent = null;

			}

			Destroy(gameObject);
			}else{
				ct=8000;
			}
		}

	}
	

	public void set(float[] n){
		n.CopyTo(itf,0);
	}
	public void lset(float[] n){
		n.CopyTo(itf,0);
		if(gameObject.GetComponent<BoxCollider>()){
				Destroy(gameObject.GetComponent<BoxCollider>());
			}
			if(gameObject.GetComponent<SphereCollider>()){
				Destroy(gameObject.GetComponent<SphereCollider>());
			}
		if((int)itf[32]==1){
		BoxCollider bo = gameObject.AddComponent<BoxCollider>();
		bo.size = new Vector3(itf[15],itf[16],itf[17]);
		}else{
		SphereCollider so = gameObject.AddComponent<SphereCollider>();
		so.radius = itf[14];
		}
		rb.mass = itf[19];
		rb.drag = itf[20];
		if((int)itf[33]==1){
			rb.useGravity = true;
		}else{
			rb.useGravity = false;
		}

		if(psit!= null && itf[36]>=0){
			psit.GetComponent<AudioSource>().clip = date.adc[(int)itf[36]];

		}else if(psit!= null && psit.GetComponent<AudioSource>()!=null){
			Destroy(psit);
		}
		if(itf[35]<=0){
			GetComponent<AudioSource>().clip = null;
		}
	}
	public float[] get(){
		return itf;
	}
	void OnCollisionEnter(Collision co){
		if(co.gameObject.tag ==("del")){
			Destroy(gameObject);
		}
		if( (itf[pi]>0 && co.gameObject.tag == ("glp1")) || (itf[pi+1]>0 && co.gameObject.tag == ("glp2")) || (itf[pi+2]>0 && co.gameObject.tag == ("glp3")) ){
		rovoko c = co.gameObject.GetComponent<rovoko>();
			if(itf[pi+6]>0){c.hit((int)itf[21]);}
			if(itf[pi+7]>0){c.stin((int)itf[22]);}
			if(itf[pi+16]>0){c.coin((int)itf[34]);}

			if(itf[pi+15]>0){co.collider.attachedRigidbody.velocity = gameObject.transform.forward*itf[23];}
			ct=0;
			itf[pi+17]=1;
		}

		if((itf[pi+3]>0 && co.gameObject.layer == 8)){
			if(itf[pi+9]!=0){
				Collider[] yu = Physics.OverlapCapsule(new Vector3(transform.position.x,100,transform.position.z),
				new Vector3(transform.position.x,-20,transform.position.z),5,256);
				for(i=0;i<yu.Length;i++){
						if(yu[i].name != ("sot")){
						grund j = yu[i].gameObject.GetComponent<grund>();
						j.bk(transform.position,5,(int)itf[24]);
						}else{
						yu[i].gameObject.SendMessage("upck",transform.position);
						}
					}			
				}

			if(itf[pi+10]>0 && date.ftx!=null){
					int px = (int)((transform.position.x/280f)*1024);
					int py = (int)((transform.position.z/280f)*1024);
					int hp = 5 + (int)(transform.localScale.x+transform.localScale.y+transform.localScale.z)*2;
					Color32[] clr = date.ftx.GetPixels32();
					Color cr = new Color(itf[25],itf[26],itf[27]);
					for(int n=px-hp;n <=px+hp;n++){
						for(int k=py-hp;k <=py+hp;k++){
							if(n>0 && n <1024 && k>0 && k < 1024) {
								if( ((n-px)*(n-px)) + ((k-py)*(k-py)) < (hp*hp) ){
									clr[k*1024 + n] = cr;
								}
							}
						}
					}
					date.ftx.SetPixels32(clr);
					date.ftx.Apply();
					ct=0;
					itf[pi+17]=1;
				}
			if(itf[pi+11]>0){
				int x = (int)(transform.position.x)/2;
				int y = (int)(transform.position.z)/2;
				if(x<0){x=0;}if(x>140){x=140;}
				if(y<0){y=0;}if(y>140){y=140;}
				date.izm[x,y].y += (int)itf[28]*0.25f;
				date.vl += (int)itf[28]*0.25f;
				if(date.tiz<6){date.tiz=11;}
			}
			ct=0;
			itf[pi+17]=1;
		}
		if(itf[pi+5]>0 && co.gameObject.layer == 12){
			blds bl = co.gameObject.GetComponent<blds>();
			if(itf[pi+13]>0 && co.gameObject.tag == ("bl")){
				bl.damg((int)itf[31]);
			ct=0;
			itf[pi+17]=1;
			}
		}

	}


	/*
	void OnTriggerEnter(Collider co){
		if((it[14]==0 && co.gameObject.tag == ("glp1")) ||(it[15]==0 &&  co.tag == ("glp2"))||(it[16]==0&& co.tag == ("glp3")) ){
			rovoko c = co.gameObject.GetComponent<rovoko>();
			c.hit(it[0]);
			Destroy(gameObject);
		}	
		if(it[6]==0 && co.tag == ("zimen")){
			Destroy(gameObject);
		}

		if(it[8]==0 && co.tag == ("bl") ){
			Destroy(gameObject);
		}
		if(co.gameObject.tag == ("del")){
			Destroy(gameObject);
		}

		if(it[13]==10){
			if((it[14]==1 && co.gameObject.tag == ("glp1")) || (it[15]==1 && co.gameObject.tag == ("glp2")) || (it[16]==1 && co.gameObject.tag == ("glp3")) ){
			co.attachedRigidbody.AddForce(transform.forward*(it[0]*25));
			}
			if(co.gameObject.tag == ("it")){
			co.attachedRigidbody.AddForce(transform.forward*(it[0]*25));	
			}
			/*
			if(co.gameObject.tag == ("zimen")){
				int x = (int)(transform.position.x)/2;
				int z = (int)(transform.position.z)/2;
				Vector3 v = rb.velocity.normalized;
				if(v.x>0 && date.izm[x,z].x>0.03f){
					if(date.izm[x,z].x+0.5f>date.izm[x+1,z+1].x){
					date.izm[x,z].x -= v.x*it[0]*0.05f;
					date.izm[x+1,z+1].x += v.x*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x+1,z].x){
					date.izm[x,z].x -= v.x*it[0]*0.05f;;
					date.izm[x+1,z].x += v.x*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x+1,z-1].x){
					date.izm[x,z].x -= v.x*it[0]*0.05f;;
					date.izm[x+1,z-1].x += v.x*it[0]*0.05f;;
					}
				}
				if(v.z>0 && date.izm[x,z].x>0.03f){
					if(date.izm[x,z].x+0.5f>date.izm[x+1,z+1].x){
					date.izm[x,z].x -= v.z*it[0]*0.05f;;
					date.izm[x+1,z+1].x += v.z*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x,z+1].x){
					date.izm[x,z].x -= v.z*it[0]*0.05f;;
					date.izm[x,z+1].x += v.z*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x-1,z+1].x){
					date.izm[x,z].x -= v.z*it[0]*0.05f;;
					date.izm[x-1,z+1].x += v.z*it[0]*0.05f;;
					}
				}
				if(v.x<0 && date.izm[x,z].x>0.03f){
					if(date.izm[x,z].x+0.5f>date.izm[x-1,z+1].x){
					date.izm[x,z].x += v.x*it[0]*0.05f;;
					date.izm[x-1,z+1].x -= v.x*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x-1,z].x){
					date.izm[x,z].x += v.x*it[0]*0.05f;;
					date.izm[x-1,z].x -= v.x*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x-1,z-1].x){
					date.izm[x,z].x += v.x*it[0]*0.05f;;
					date.izm[x-1,z-1].x -= v.x*it[0]*0.05f;;
					}
				}
				if(v.z<0 && date.izm[x,z].x>0.03f){
					if(date.izm[x,z].x+0.5f>date.izm[x+1,z-1].x){
					date.izm[x,z].x += v.z*it[0]*0.05f;;
					date.izm[x+1,z-1].x -= v.z*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x,z-1].x){
					date.izm[x,z].x += v.z*it[0]*0.05f;;
					date.izm[x,z-1].x -= v.z*it[0]*0.05f;;
					}
					if(date.izm[x,z].x+0.5f>date.izm[x-1,z-1].x){
					date.izm[x,z].x += v.z*it[0]*0.05f;;
					date.izm[x-1,z-1].x -= v.z*it[0]*0.05f;;
					}
				}
				Collider[] ns = Physics.OverlapCapsule(new Vector3(transform.position.x,150,transform.position.z),
										new Vector3(transform.position.x,-50,transform.position.z),5);
				for(int i=0;i<ns.Length;i++){
					if(ns[i].tag == ("zimen")){
					ns[i].gameObject.SendMessage("upck",transform.position);
					}
				}
				date.tiz=11;	
				Destroy(gameObject);
			}
		}
	}
	*/
	public void inpt(float[] f){
		ps = f;
	}
	public float[] oupt(){
		return ps;
	}
	public void inpt2(float[] f){
		ps2 = f;
	}
	public float[] oupt2(){
		return ps2;
	}

	public float ouf(int n){
		return itf[n];
	}
	public void gm1(GameObject g){
		if(psit!=null){Destroy(psit);}
		psit = g;
	}

	public void gm2(GameObject g){
		if(psed!=null){Destroy(psed);}
		psed = g;
		ParticleSystem.MainModule pm = g.GetComponent<ParticleSystem>().main;
		pm.loop =false;
	}
	public void gm3(GameObject g){
		if(pspt!=null){Destroy(pspt);}
		pspt = g;
	}
	public void gm2d(){
		if(psed!=null){Destroy(psed);}
	}
	public void gm3d(){
		if(pspt!=null){Destroy(pspt);}
	}
//	public void inad(float[] f){
//		AudioSource au = gameObject.GetComponent<AudioSource>(); 
//		au.clip = AudioClip.Create("0",f.Length,1,44100,false);
//	}
}
