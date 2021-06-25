using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vlocs : MonoBehaviour
{
	public GameObject[] gm = new GameObject[5];
	public Vector3[] vp1;
	public Vector3[] vp2;
	public Vector3[] vp3;
	public Vector3[] vp4;
	public Vector3[] vp5;

	public Vector3[] vr1;
	public Vector3[] vr2;
	public Vector3[] vr3;
	public Vector3[] vr4;
	public Vector3[] vr5;

	public int[] vt1;
	public int[] vt2;
	public int[] vt3;
	public int[] vt4;
	public int[] vt5;

//	public Vector3[] vs;
    public int[] acf = new int[5];
    public int[] act = new int[5];
    public int tp;
    public int[] mms = new int[5];
    public int os=0;
    int n;
    public Rigidbody[] rb = new Rigidbody[5];
    public MeshCollider[] mc = new MeshCollider[5];
    Quaternion qt;
    public bool[] ons = new bool[5];
   // Vector3 vf = new Vector3(0,25,0);
    Vector3 rtn;
    // Start is called before the first frame update
    void Start()
    {
            transform.position = new Vector3(0,0,0);
            transform.localScale = new Vector3(1,1,1);

        for(n=0;n<=os;n++){
        	gm[n].transform.position = op(n)[0];
        	gm[n].transform.eulerAngles = transform.eulerAngles + or(n)[0];
        	if(tp!=0){ons[n] =false;}
        	acf[n]=1;
        	act[n]=0;
        }
    }

    // Update is called once per frame
    void Update()
    {
    	
		for(n=0;n<=os;n++){
			if(ons[n] || tp==0){
       		if(ot(n)[acf[n]]>act[n]){
       		rb[n].MovePosition(op(n)[acf[n]-1] + ((op(n)[acf[n]] - op(n)[acf[n]-1]) / (float)ot(n)[acf[n]]) * act[n]);
       		qt.eulerAngles = or(n)[acf[n]-1] + ((or(n)[acf[n]] - or(n)[acf[n]-1]) / (float)ot(n)[acf[n]]) * (act[n]+1);
       		rb[n].MoveRotation(qt);


       		//if(date.tiz<6){date.tiz=11;}
 			//	izm.sgp[(int)(gm[n].transform.position.x/2f),(int)(gm[n].transform.position.z/2f)].w = izm.q;
 			//	izm.sgp[(int)(gm[n].transform.position.x/2f),(int)(gm[n].transform.position.z/2f)].x = 9;
 			//	izm.sgp[(int)(gm[n].transform.position.x/2f),(int)(gm[n].transform.position.z/2f)].z = 5;
       		//rb[n].MoveRotation(Quaternion.Euler(or(n)[act[n]]));
       		act[n]++;
       		}else{
       			acf[n]++;
       			act[n]=0;

      			if(acf[n]>=ot(n).Length){
       				acf[n]=1;
       				act[n]=0;
       				gm[n].transform.position = transform.position + op(n)[0];
       				gm[n].transform.eulerAngles = transform.eulerAngles + (or(n)[0]);
       				if(tp==0){ons[n]=true;}else{ons[n]=false;}
       			}
       		}
		}
		}
    }
    Vector3[] op(int n){
    	switch(n){
    		case 0:
    		return vp1;
    		case 1:
    		return vp2;
    		case 2:
    		return vp3;
    		case 3:
    		return vp4;
    		case 4:
    		return vp5;

    		default: return null;
    	}
    }
	Vector3[] or(int n){
    	switch(n){
    		case 0:
    		return vr1;
    		case 1:
    		return vr2;
    		case 2:
    		return vr3;
    		case 3:
    		return vr4;
    		case 4:
    		return vr5;

    		default: return null;
    	}
    }
    int[] ot(int n){
    	switch(n){
    		case 0:
    		return vt1;
    		case 1:
    		return vt2;
    		case 2:
    		return vt3;
    		case 3:
    		return vt4;
    		case 4:
    		return vt5;

    		default: return null;
    	}
    }
   public void pro(int n,int p){
    	switch(n){
    		case 0:
    		vp1 =  new Vector3[p];
    		vr1 =  new Vector3[p];
    		vt1 =  new int[p];
    		break;
    		case 1:
    		vp2 =  new Vector3[p];
    		vr2 =  new Vector3[p];
    		vt2 =  new int[p];
    		break;
    		case 2:
    		vp3 =  new Vector3[p];
    		vr3 =  new Vector3[p];
    		vt3 =  new int[p];
    		break;
    		case 3:
    		vp4 =  new Vector3[p];
    		vr4 =  new Vector3[p];
    		vt4 =  new int[p];
    		break;
    		case 4:
    		vp5 =  new Vector3[p];
    		vr5 =  new Vector3[p];
    		vt5 =  new int[p];
    		break;
    	}
    }

    public void dtin(int t,int[,] sc,Vector3[,] vp,Vector3[,] vr,int[] c,int y){

    	for(n=0;n<=4;n++){
    		if(t>=n){
			pro(n,c[n]);
			op(n)[0] = vp[n,0];
			or(n)[0] = vr[n,0];
    		for(int k=1;k<c[n];k++){    	
	    	op(n)[k] = vp[n,k];//-vp[n,k-1])/(float)sc[n,k];
    		or(n)[k] = vr[n,k];//(vr[n,k]-vr[n,k-1])/(float)sc[n,k];
    		ot(n)[k] += sc[n,k];
    		}
    		}
    	}
    	os = t;
    	tp = y;
    }

    public void msin(int u,MeshFilter[] mf,MeshRenderer[] mr,GameObject[] vl,int[] mi){
    	for(int i=0;i<5;i++){
            if(i<=u){
        	gm[i].GetComponent<MeshFilter>().mesh = Instantiate(mf[i].mesh);
            gm[i].GetComponent<MeshRenderer>().material = Instantiate(mr[i].material);
            gm[i].transform.localScale = vl[i].transform.lossyScale;
        	mc[i].sharedMesh = gm[i].GetComponent<MeshFilter>().mesh;
        	mms[i] = mi[i];
    	   }else{
            gm[i].GetComponent<MeshFilter>().mesh = null;
            gm[i].GetComponent<MeshRenderer>().material = null;
            gm[i].transform.localScale = Vector3.zero;
            mc[i].sharedMesh = null;
           }
        }	
    }
    public void clon(){
    	if(tp==2){
    		for(n=0;n<=os;n++){
            ons[n]=true;
            }
    	}
    }

    public void hits(){
    	if(tp==1){
    		for(n=0;n<=os;n++){
    		ons[n]=true;
    		}
    	}
    }
    public int ous(){
        return os+1;
    }
    public void ins(int n){
        os = n-1;
    }

    public int outp(){
        return tp;
    }        
    public void intp(int n){
        tp = n;
    }        

    public Vector3[] ovp(int n){
        switch(n){
        case 0:
        return vp1;
        case 1:
        return vp2;
        case 2:
        return vp3;
        case 3:
        return vp4;
        case 4:
        return vp5;
        default : return null;
        }
    }
    public Vector3[] ovr(int n){
        switch(n){
        case 0:
        return vr1;
        case 1:
        return vr2;
        case 2:
        return vr3;
        case 3:
        return vr4;
        case 4:
        return vr5;
        default : return null;
        }
    }
    public Vector3[] osz(){
        Vector3[] v = new Vector3[5];
        v[0] = gm[0].transform.lossyScale;
        v[1] = gm[1].transform.lossyScale;
        v[2] = gm[2].transform.lossyScale;
        v[3] = gm[3].transform.lossyScale;
        v[4] = gm[4].transform.lossyScale;

        return v;
    }
    public Color[] ocl(){
        Color[] c = new Color[os+1];
        for(int i=0;i<=os;i++){
        c[i] = gm[i].GetComponent<MeshRenderer>().material.color;
        }
        return c;
    }

    public int[] ovt(int n){
        switch(n){
        case 0:
        return vt1;
        case 1:
        return vt2;
        case 2:
        return vt3;
        case 3:
        return vt4;
        case 4:
        return vt5;

        default : return null;
        }
    }
    public int[] oumm(){
        return mms;
    }
    public void iset(int n,Vector3[] vp,Vector3[] vr,int[] vt,Vector3 ls,int mn,Mesh m,int t,Color[] cl){
        pro(n,vp.Length);
        vp.CopyTo(op(n),0);
        vr.CopyTo(or(n),0);
        vt.CopyTo(ot(n),0);
        mms[n] = mn;
        gm[n].GetComponent<MeshFilter>().mesh = Instantiate(m);
        gm[n].GetComponent<MeshRenderer>().material = Instantiate(gm[n].GetComponent<MeshRenderer>().material);
        gm[n].GetComponent<MeshRenderer>().material.color = cl[n];
        mc[n].sharedMesh = gm[n].GetComponent<MeshFilter>().mesh;
        
        tp = t;
        gm[n].transform.localScale = ls;
    }

}
