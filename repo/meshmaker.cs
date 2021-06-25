using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class meshmaker : MonoBehaviour
{
	public GameObject box;
	public RectTransform rmp;
	public Camera cmp;
	public GameObject cmc;
	public GameObject cmr;
	public LayerMask mk;
	public MeshCollider mc;
	public RectTransform glp;
	public RectTransform sclp;
	public MeshRenderer clgh;

	public Material mtr;
	public Material mtar;
	public MeshRenderer mtftr;

	public Slider[] sl = new Slider[4];
	Mesh ms;
	Vector3 rtnp;
	Vector3 vp;
	Vector3 vh;
	Vector3 cv;
	int mesi=0;
	int wid=0;
	//public GameObject hits;
//	bool[] bn;
	int cmvi=0;
	float csp = 0.025f;

	List<int> mn = new List<int>();
	List<Vector3> mv = new List<Vector3>();

	List<Vector3> vtc = new List<Vector3>();
	//List<Vector3> vtn = new List<Vector3>();
	List<Color> vtr = new List<Color>();
	List<int> vtt = new List<int>();
	List<Vector3> spv = new List<Vector3>();
	List<int> spi = new List<int>();
	List<bool>bn = new List<bool>();

	public Image[] onb = new Image[2];
	Color crd = new Color(0.9f,0.5f,0.5f,0.5f);
	Color csk = new Color(0.5f,0.5f,0.5f,0.5f);

	public Image[] msim = new Image[50];
	public RectTransform svc;
	int sv=0;
	public RectTransform onc;
	public RectTransform[] ontr = new RectTransform[8];
    // Start is called before the first frame update
    void Start()
    {	
    	ms = new Mesh();
        box.GetComponent<MeshFilter>().mesh = ms;     
        box.transform.position = Vector3.zero;
        cmr.transform.position = Vector3.zero;   
    }

    // Update is called once per frame
    void Update()
    {
    	if(cmvi>0){
    		switch(cmvi){
    			case 1:
    			if(cmr.transform.eulerAngles != new Vector3(90,0,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(90, 0, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(90,0,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;
    			case 2:
    			if(cmr.transform.eulerAngles != new Vector3(270,0,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(270, 0, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(270,0,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;
	  			case 3:
    			if(cmr.transform.eulerAngles != new Vector3(0,0,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(0, 0, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(0,0,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;	  			
    			case 4:
    			if(cmr.transform.eulerAngles != new Vector3(0,180,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(0,180, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(0,180,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;
    			case 5:
    			if(cmr.transform.eulerAngles != new Vector3(0,90,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(0, 90, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(0,90,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;
    			case 6:
    			if(cmr.transform.eulerAngles != new Vector3(0,270,0)){
    			cmr.transform.rotation = Quaternion.RotateTowards(cmr.transform.rotation, Quaternion.Euler(new Vector3(0,270, 0)),10);}
   				if(Vector3.Distance(cmr.transform.position,rtnp)>0.2f){cmr.transform.position  = Vector3.Lerp(cmr.transform.position,rtnp,0.4f);}else{cmr.transform.position=rtnp;}
   				if(cmr.transform.eulerAngles == new Vector3(0,270,0)&&Vector3.Distance(cmr.transform.position,rtnp)<0.1f){cmvi=0;}
    			break;

    		}
    	}
    	if(Input.GetKeyDown(KeyCode.LeftShift)){onb[0].color = crd;cv = cmr.transform.position;vp = Input.mousePosition;vh = cmr.transform.eulerAngles;}
		if(Input.GetKeyDown(KeyCode.LeftControl)){onb[1].color = crd;
		}
		if(Input.GetKeyUp(KeyCode.LeftShift)){onb[0].color = csk;cv = cmr.transform.position;vp = Input.mousePosition;vh = cmr.transform.eulerAngles;}
		if(Input.GetKeyUp(KeyCode.LeftControl)){onb[1].color = csk;}
		if(Input.GetKeyDown(KeyCode.Q)){meni(0);}
		if(Input.GetKeyDown(KeyCode.W)){meni(1);}
		if(Input.GetKeyDown(KeyCode.E)){meni(3);}
		if(Input.GetKeyDown(KeyCode.R)){meni(2);}
		if(Input.GetKeyDown(KeyCode.A)){onebox();}
		if(Input.GetKeyDown(KeyCode.S)){meni(4);}
		if(Input.GetKeyDown(KeyCode.D)){meni(6);}
		if(Input.GetKeyDown(KeyCode.Z)){mend();}
		if(Input.GetKeyDown(KeyCode.X)){delt();}
		if(Input.GetKeyDown(KeyCode.T)){allt();}
		if(Input.GetKeyDown(KeyCode.C)){allc();}

    }
    public void delt(){
		for(int i=spi.Count-1;i>=0;i--){
			int s = spi[i]*24;
			for(int n=0;n<24;n++){
			vtc.RemoveAt(s);
//			vtn.RemoveAt(s);
			vtr.RemoveAt(s);
			bn.RemoveAt(s);
			}
			s = spi[i]*36;
			for(int n=0;n<36;n++){
			vtt.RemoveAt(s);
			}			
    	}	
    	vtt.Clear();
    	for(int i=0;vtc.Count / 24>i;i++){
    		trir(i*24);
    	}
    	
			ms.SetTriangles(vtt,0);
			ms.SetVertices(vtc);
			ms.SetColors(vtr);
//			ms.SetNormals(vtn);
			spi.Clear();
			ms.RecalculateNormals();
			mc.sharedMesh = ms;
    }
    public void cmnv(int n){
    	cmvi = n;
    	Vector3 rtnv=Vector3.zero;

    	for(int i=0;i<ms.vertices.Length;i++){
    	rtnv += ms.vertices[i];
    	}
    	rtnv = rtnv/(float)ms.vertices.Length;
    	switch(n){
    		case 1: rtnp =  new Vector3(rtnv.x,Vector3.Distance(cmr.transform.position,rtnv),rtnv.z);break;
    		case 2: rtnp =  new Vector3(rtnv.x,-Vector3.Distance(cmr.transform.position,rtnv),rtnv.z);break;
    		case 3: rtnp =  new Vector3(rtnv.x,rtnv.y,-Vector3.Distance(cmr.transform.position,rtnv));break;
    		case 4: rtnp =  new Vector3(rtnv.x,rtnv.y,Vector3.Distance(cmr.transform.position,rtnv));break;
    		case 5: rtnp =  new Vector3(-Vector3.Distance(cmr.transform.position,rtnv),rtnv.y,rtnv.z);break;
			case 6: rtnp =  new Vector3(Vector3.Distance(cmr.transform.position,rtnv),rtnv.y,rtnv.z);break;    		
    	}
    }
    public void meni(int n){
    	mesi = n;
    	ontr[7].transform.SetParent(ontr[n].transform);
    	onc.anchoredPosition = Vector2.zero;
    	//covp();
    }
    public void mend(){
    	mesi = 5;
    	ontr[7].transform.SetParent(ontr[5].transform);
    	onc.anchoredPosition = Vector2.zero;
    	mn.Clear();
    	mv.Clear();
    	for(int i=0;i<vtr.Count;i++){
    		vtr[i] = Color.red;
    		bn[i] = false;
    	}
    	ms.SetColors(vtr);
    	sclp.gameObject.SetActive(false);
    }
    public void allt(){
	   	//onc.anchoredPosition = Vector2.zero;
    	for(int i=0;i<ms.vertices.Length;i++){
    		bn[i] = true;
   		}
    	mn.Clear();
    	mv.Clear();
		sclp.gameObject.SetActive(true);
    	covp();
    	coon();
    	if(Input.GetMouseButton(0)){
    		vp = Input.mousePosition;
    	}
    }
    public void allc(){
	   	//onc.anchoredPosition = Vector2.zero;
    	for(int n=0;n<ms.vertices.Length;n++){
    	bn[n] = false;
    	}
    	mn.Clear();
    	mv.Clear();
		sclp.gameObject.SetActive(false);
    	covp();
    }
    public void mcon(){
    	if(!Input.GetMouseButton(0) && Input.GetMouseButton(1)){
    	Vector3 mp = Input.mousePosition;
    	Vector3[] v = new Vector3[4];
		rmp.GetWorldCorners(v);
		mp.x = (mp.x-v[0].x)/rmp.transform.lossyScale.x;
		mp.y = (mp.y-v[0].y)/rmp.transform.lossyScale.y;
		Ray ray = cmp.ScreenPointToRay(mp);
		RaycastHit rh;
		int i;
		if(Physics.Raycast(ray,out rh,Mathf.Infinity,mk)){
			//hits.transform.position = rh.point;
			switch(mesi){
			case 0:
			Vector3 vi = rh.point / box.transform.lossyScale.x;
			if(Input.GetKey(KeyCode.LeftControl)){
				for(i=0;i<ms.vertices.Length;i++){
				if(Vector3.Distance(vi,ms.vertices[i])<0.15f){
					bn[i] = false;
				}
				}
			}else{
				for(i=0;i<ms.vertices.Length;i++){
				if(Vector3.Distance(vi,ms.vertices[i])<0.15f){
					bn[i] = true;
				}
				}
			}
			covp();
			break;
			case 1:
			i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
			int p;
			if(!Input.GetKey(KeyCode.LeftControl)){
				bn[i*4] = true;
				bn[(i*4)+1] = true;
				bn[(i*4)+2] = true;
				bn[(i*4)+3] = true;	
				p = Mathf.FloorToInt((float)i/6f);
				p = p*24;
				for(int n=p;n<p+24;n++){
					if(ms.vertices[i*4]==ms.vertices[n]){bn[n] =true;}
					if(ms.vertices[(i*4)+1]==ms.vertices[n]){bn[n] =true;}
					if(ms.vertices[(i*4)+2]==ms.vertices[n]){bn[n] =true;}
					if(ms.vertices[(i*4)+3]==ms.vertices[n]){bn[n] =true;}
				}	
			}else{
				bn[i*4] = false;
				bn[(i*4)+1] = false;
				bn[(i*4)+2] = false;
				bn[(i*4)+3] = false;	
				p = Mathf.FloorToInt((float)i/6f);
				p = p*24;
				for(int n=p;n<p+24;n++){
					if(ms.vertices[i*4]==ms.vertices[n]){bn[n] =false;}
					if(ms.vertices[(i*4)+1]==ms.vertices[n]){bn[n] =false;}
					if(ms.vertices[(i*4)+2]==ms.vertices[n]){bn[n] =false;}
					if(ms.vertices[(i*4)+3]==ms.vertices[n]){bn[n] =false;}	
				}
			}
			covp();
			break;
			case 3:
				i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				int s = Mathf.FloorToInt((float)i/6f);
				s = s*24;
				if(!Input.GetKey(KeyCode.LeftControl)){
				for(int n=s;n<s+24;n++){
					bn[n] = true;
				}
				}else{
				for(int n=s;n<s+24;n++){
					bn[n] = false;
				}	
				}
				covp();
			break;
			case 4:
				onebox();
				i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				int h = ms.vertices.Length - 24;
				Vector3 vv = Vector3.Cross(vtc[(i*4)+1]-vtc[i*4],vtc[(i*4)+2]-vtc[i*4]).normalized;
				spv.Clear();
				spi.Clear();
				vtc[h] = ms.vertices[(i*4)+1];
				vtc[h+1] = ms.vertices[(i*4)];
				vtc[h+2] = ms.vertices[(i*4)+3];
				vtc[h+3] = ms.vertices[(i*4)+2];
				
				vtc[h+4] = ms.vertices[(i*4)+1]+vv;spv.Add(vtc[h+4]);spi.Add(h+4);
				vtc[h+5] = ms.vertices[(i*4)+1];
				vtc[h+6] = ms.vertices[(i*4)+3]+vv;spv.Add(vtc[h+6]);spi.Add(h+6);
				vtc[h+7] = ms.vertices[(i*4)+3];

				vtc[h+8] = ms.vertices[(i*4)]+vv;spv.Add(vtc[h+8]);spi.Add(h+8);
				vtc[h+9] = ms.vertices[(i*4)+1]+vv;spv.Add(vtc[h+9]);spi.Add(h+9);
				vtc[h+10] = ms.vertices[(i*4)+2]+vv;spv.Add(vtc[h+10]);spi.Add(h+10);
				vtc[h+11] = ms.vertices[(i*4)+3]+vv;spv.Add(vtc[h+11]);spi.Add(h+11);

				vtc[h+12] = ms.vertices[(i*4)];
				vtc[h+13] = ms.vertices[(i*4)]+vv;spv.Add(vtc[h+13]);spi.Add(h+13);
				vtc[h+14] = ms.vertices[(i*4)+2];
				vtc[h+15] = ms.vertices[(i*4)+2]+vv;spv.Add(vtc[h+15]);spi.Add(h+15);

				vtc[h+16] = ms.vertices[(i*4)];
				vtc[h+17] = ms.vertices[(i*4)+1];
				vtc[h+18] = ms.vertices[(i*4)]+vv;spv.Add(vtc[h+18]);spi.Add(h+18);
				vtc[h+19] = ms.vertices[(i*4)+1]+vv;spv.Add(vtc[h+19]);spi.Add(h+19);

				vtc[h+20] = ms.vertices[(i*4)+2]+vv;spv.Add(vtc[h+20]);spi.Add(h+20);
				vtc[h+21] = ms.vertices[(i*4)+3]+vv;spv.Add(vtc[h+21]);spi.Add(h+21);
				vtc[h+22] = ms.vertices[(i*4)+2];
				vtc[h+23] = ms.vertices[(i*4)+3];
				for(int k = 0;k<24;k++){
				vtr[h+k] = Color.green;
				}
				spv.Add(vv);
				ms.SetVertices(vtc);
				ms.SetColors(vtr);
				ms.RecalculateNormals();
		        mc.sharedMesh = ms;
			break;
			case 5:
				i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				int ss = Mathf.FloorToInt((float)i/6f);	
				for(int n=0;n<spi.Count;n++){
					if(spi[n]==ss){
						for(int nn=ss*24;nn<(ss*24)+24;nn++){
						vtr[nn] = Color.red;
						}
						spi.RemoveAt(n);
						ms.SetColors(vtr);
						return;
					}
				}
				spi.Add(ss);
				ss = ss*24;
				for(int n=ss;n<ss+24;n++){
					vtr[n] = csk;
				}
				spi.Sort();
				ms.SetColors(vtr);
			break;
			case 6:
				i = Mathf.FloorToInt((float)rh.triangleIndex/2f);
				i = Mathf.FloorToInt((float)i/6f);
				i = i*24;
				for(int n=0;n<24;n++){
				vtc.Add(vtc[i+n]);
				vtr.Add(Color.yellow);
				bn.Add(true);
				}
				trir(vtc.Count-24);
				ms.SetVertices(vtc);
				ms.SetColors(vtr);
				ms.SetTriangles(vtt,0);
				ms.RecalculateNormals();
		        mc.sharedMesh = ms;
			break;
		}
		}
	}	
    	if(Input.GetMouseButton(0) || Input.GetMouseButton(1)){
			mv.Clear();
			mn.Clear();
			coon();
		}
		if(Input.GetMouseButton(2)){
   		clgh.enabled = true;
		}

    	vp = Input.mousePosition;
		vh = cmr.transform.eulerAngles;

	}
    void covp(){
    	for(int i=0;i<ms.vertices.Length;i++){
    		if(!bn[i]){
    		vtr[i] = Color.red;
			}else{
			vtr[i] = Color.yellow;
			}
    	}
    	ms.SetColors(vtr);
    }
    void coon(){

    	for(int n=0;n<ms.vertices.Length;n++){
			if(bn[n]){
				mn.Add(n);
				mv.Add(ms.vertices[n]);
			}
		}
		if(mn.Count>=6){
			sclp.gameObject.SetActive(true);
			widc(wid);
		}else{
			sclp.gameObject.SetActive(false);
		}
    }
    public void widc(int i){
    	wid = -1;
    	switch(i){
    		case 0:
    		sl[0].value = 0;sl[0].minValue = -10;sl[0].maxValue = 10;
    		sl[1].value = 0;sl[1].minValue = -10;sl[1].maxValue = 10;
    		sl[2].value = 0;sl[2].minValue = -10;sl[2].maxValue = 10;
    		break;
    		case 1:
    		sl[0].value = 0;sl[0].minValue = -1;sl[0].maxValue = 1;
    		sl[1].value = 0;sl[1].minValue = -1;sl[1].maxValue = 1;
    		sl[2].value = 0;sl[2].minValue = -1;sl[2].maxValue = 1;
    		break;
    		case 2:
    		sl[0].value = 0;sl[0].minValue = -180;sl[0].maxValue = 180;
    		sl[1].value = 0;sl[1].minValue = -180;sl[1].maxValue = 180;
    		sl[2].value = 0;sl[2].minValue = -180;sl[2].maxValue = 180;
    		break;
    	}
		for(int n=0;n<mv.Count;n++){
			mv[n] = ms.vertices[mn[n]];
		}
		wid = i;
    }

    public void mswd(){
    	if(wid!=-1){
    	Vector3 v;

    	switch(wid){
    		case 0:
    		    if(Input.GetMouseButton(1)){
    			sl[0].value = Mathf.Round(sl[0].value*2f)/2f;
    			sl[1].value = Mathf.Round(sl[1].value*2f)/2f;
    			sl[2].value = Mathf.Round(sl[2].value*2f)/2f;
    		    }
    		    for(int i=0;i<mn.Count;i++){
    				vtc[mn[i]] = mv[i] + new Vector3(sl[0].value,sl[1].value,sl[2].value);
    			}
    		break;
    		case 1:
    			if(Input.GetMouseButton(1)){
    			sl[0].value = Mathf.Round(sl[0].value*10f)/10f;
    			sl[1].value = Mathf.Round(sl[1].value*10f)/10f;
    			sl[2].value = Mathf.Round(sl[2].value*10f)/10f;
    		    }
	    		v = Vector3.zero;
	    		Vector3 b;
    			for(int i=0;i<mn.Count;i++){
    			v += mv[i];
   				}
   				v = v/(float)mn.Count;
   				for(int i=0;i<mn.Count;i++){
   					b = mv[i]-v;
    				vtc[mn[i]] = mv[i] + new Vector3(b.x*sl[0].value,b.y*sl[1].value,b.z*sl[2].value);
    			}
    		break;
    		case 2:
    		   	if(Input.GetMouseButton(1)){
    			sl[0].value = Mathf.Round(sl[0].value/15f)*15f;
    			sl[1].value = Mathf.Round(sl[1].value/15f)*15f;
    			sl[2].value = Mathf.Round(sl[2].value/15f)*15f;
    		    }
	    		v = Vector3.zero;
    			for(int i=0;i<mn.Count;i++){
    			v += mv[i];
   				}
   				v = v/(float)mn.Count;
   				Vector3 vv;
   				Vector3 vs;
    		    for(int i=0;i<mn.Count;i++){
    		    vv = mv[i] - v;
    			vs = new Vector3((
    				  Mathf.Cos(sl[0].value * Mathf.Deg2Rad)*vv.x)-(Mathf.Sin(sl[0].value * Mathf.Deg2Rad)*vv.z),vv.y,
    				 (Mathf.Sin(sl[0].value * Mathf.Deg2Rad)*vv.x)+(Mathf.Cos(sl[0].value * Mathf.Deg2Rad)*vv.z));
    			vs = new Vector3(vs.x,
    				 (Mathf.Cos(sl[1].value * Mathf.Deg2Rad)*vs.y)-(Mathf.Sin(sl[1].value * Mathf.Deg2Rad)*vs.z),
    				 (Mathf.Sin(sl[1].value * Mathf.Deg2Rad)*vs.y)+(Mathf.Cos(sl[1].value * Mathf.Deg2Rad)*vs.z));
    			vs = new Vector3(
    				 (Mathf.Cos(sl[2].value * Mathf.Deg2Rad)*vs.x)-(Mathf.Sin(sl[2].value * Mathf.Deg2Rad)*vs.y),
    				 (Mathf.Sin(sl[2].value * Mathf.Deg2Rad)*vs.x)+(Mathf.Cos(sl[2].value * Mathf.Deg2Rad)*vs.y),vs.z);
    			
    			//vtc[mn[i]] = v + new Vector3((Mathf.Cos(sl[2].value * Mathf.Deg2Rad)*v.x)-(Mathf.Sin(sl[2].value * Mathf.Deg2Rad)*v.y),
				//(Mathf.Sin(sl[2].value * Mathf.Deg2Rad)*v.x)+(Mathf.Cos(sl[2].value * Mathf.Deg2Rad)*v.y),v.z);
				vtc[mn[i]] = vs+v;
    			}
    		break;
    	}
    	ms.SetVertices(vtc);
    	mc.sharedMesh = ms;
   		}
    }
    public void mso(){
    	Vector3 mp = Input.mousePosition;
    	mp = mp-vp;
    	if(!Input.GetKey(KeyCode.LeftShift)){
    	for(int i=0;i<mn.Count;i++){
    		vtc[mn[i]] = mv[i] + (cmr.transform.up*(mp.y*csp)) + (cmr.transform.right*(mp.x*csp));
    	}
    	}else{
    	if(Mathf.Abs(mp.x)>Mathf.Abs(mp.y)){
    		mp.y = 0;
    	}else{
    		mp.x = 0;
    	}
    	for(int i=0;i<mn.Count;i++){
    		vtc[mn[i]] = mv[i] + (cmr.transform.up*(mp.y*csp)) + (cmr.transform.right*(mp.x*csp));
    	}
    	}
    	ms.SetVertices(vtc);
		ms.RecalculateNormals();
    }

    public void mstg(){

    	if(!Input.GetMouseButton(0) && !Input.GetMouseButton(1) && Input.GetMouseButton(2)){
    		Vector3 f = Input.mousePosition;
    	 	if(Input.GetKey(KeyCode.LeftShift)){
		  	f = f - vp;
		  	//cmr.transform.position = cv + new Vector3(f.x*0.05f,f.y*0.05f,0);
		  	cmr.transform.position = cv + (cmr.transform.up*(f.y*csp)) + (cmr.transform.right*(f.x*csp));
			}else{
//			if(!Input.GetKey(KeyCode.LeftShift)){
			f = f - vp;
			Vector3 v = vh + new Vector3(f.y*csp*5,-f.x*csp*5,0);
			//if(v.x>90 && v.x <180){v.x=90;}
			//if(v.x <270 && v.x>180){v.x=270;}
			cmr.transform.eulerAngles  = v;
			}

		}
		if(Input.GetMouseButton(0) && !Input.GetMouseButton(1)){
			mso();
		}
		if(mesi==2 && !Input.GetMouseButton(0) && Input.GetMouseButton(1)){
    		Vector3 f = Input.mousePosition;
    		Vector3 m = vp;
			Vector3[] v = new Vector3[4];
			rmp.GetWorldCorners(v);
			m.x = (vp.x-v[0].x)/rmp.transform.lossyScale.x;
			m.y = (vp.y-v[0].y)/rmp.transform.lossyScale.y;
			f.x = (f.x-v[0].x)/rmp.transform.lossyScale.x;
			f.y = (f.y-v[0].y)/rmp.transform.lossyScale.y;
			float x = m.x - ((m.x - f.x)/2f);
			float y = m.y - ((m.y - f.y)/2f);
			glp.anchoredPosition = new Vector2(x,y);
			x = Mathf.Abs(m.x - f.x);
			y = Mathf.Abs(m.y - f.y);
			glp.sizeDelta = new Vector2(x,y);
			glp.gameObject.SetActive(true);

		}
		if(mesi==4 && spi.Count>0 && !Input.GetMouseButton(0) && Input.GetMouseButton(1)){
    		Vector3 f = Input.mousePosition;
    		Vector3 m = vp;
    		f = f-vp;
    		if(f.x<-19){f.x=-19;};
    		for(int i=0;i<spi.Count;i++){
    			vtc[spi[i]] = spv[i] + spv[spv.Count-1] * (f.x*0.05f);
    		}
			ms.SetVertices(vtc);
		}

    }
    public void cscl(){
    	if(Input.GetMouseButton(1)){
    		cmc.transform.localPosition = new Vector3(cmc.transform.localPosition.x,cmc.transform.localPosition.y,cmc.transform.localPosition.z + Input.mouseScrollDelta.y*10);
	    	if(cmc.transform.localPosition.z>0){cmc.transform.localPosition = new Vector3(cmc.transform.localPosition.x,cmc.transform.localPosition.y,0);}
	    	if(cmc.transform.localPosition.z<-250){cmc.transform.localPosition = new Vector3(cmc.transform.localPosition.x,cmc.transform.localPosition.y,-250);}
	    	if(clgh.enabled==false){clgh.enabled = true;}
    	}else{
    	cmr.transform.position += Input.mouseScrollDelta.y * cmr.transform.forward;
    	}
    }
    public void cide(){
    	if(Input.GetMouseButtonUp(0)){
    		mc.sharedMesh = ms;
    	}
    	if(Input.GetMouseButtonUp(1)||Input.GetMouseButtonUp(2)){
    		if(clgh.enabled==true){clgh.enabled = false;}
    	}
    	if(mesi==2 && Input.GetMouseButtonUp(1)){
    		Vector3 f = Input.mousePosition;
			Vector3[] v = new Vector3[4];
			rmp.GetWorldCorners(v);
			vp.x = (vp.x-v[0].x)/rmp.transform.lossyScale.x;
			vp.y = (vp.y-v[0].y)/rmp.transform.lossyScale.y;
			f.x = (f.x-v[0].x)/rmp.transform.lossyScale.x;
			f.y = (f.y-v[0].y)/rmp.transform.lossyScale.y;
			Vector2 pp = new Vector2((vp.x+f.x)/2f,(vp.y+f.y)/2f);
			float xp = Mathf.Abs(vp.x-f.x)/2f;
			float yp = Mathf.Abs(vp.y-f.y)/2f;
			glp.gameObject.SetActive(false);
			Vector3 vm;
			Vector3[] vw = ms.vertices;
			for(int i=0;i<ms.vertices.Length;i++){
				vm = cmp.WorldToScreenPoint(vw[i])*box.transform.lossyScale.x;
				if(vm.x>pp.x-xp&&vm.x<pp.x+xp){
					if(vm.y>pp.y-yp&&vm.y<pp.y+yp){
						if(!Input.GetKey(KeyCode.LeftControl)){
							bn[i]=true;}else{bn[i]=false;}
					}
				}
			}
			covp();
			mn.Clear();
			mv.Clear();
			coon();
			if(mn.Count>=6){
			sclp.gameObject.SetActive(true);
			}else{
			sclp.gameObject.SetActive(false);
			}
		}
		if(mesi==4 && spi.Count>0 && Input.GetMouseButtonUp(1)){
			covp();
			mc.sharedMesh = ms;
			spv.Clear();
			spi.Clear();
		}
    }
    public void cmsp(float f){
    	csp = f;
    }
    public void mtsl(float f){
    	if(f>=0.5f){
    	mtftr.material = mtar;
    	}else{
    	mtftr.material = mtr;	
    	mtr.SetFloat("_Alpha",f);
    	}
    }
    public void onebox(){
		vtc.Add(new Vector3(-0.5f,0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,0.5f,-0.5f));
		vtc.Add(new Vector3(-0.5f,-0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,-0.5f));

		vtc.Add(new Vector3(0.5f,0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,0.5f));

		vtc.Add(new Vector3(0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(-0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,0.5f));
		vtc.Add(new Vector3(-0.5f,-0.5f,0.5f));

		vtc.Add(new Vector3(-0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(-0.5f,0.5f,-0.5f));
		vtc.Add(new Vector3(-0.5f,-0.5f,0.5f));
		vtc.Add(new Vector3(-0.5f,-0.5f,-0.5f));

		vtc.Add(new Vector3(-0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(0.5f,0.5f,0.5f));
		vtc.Add(new Vector3(-0.5f,0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,0.5f,-0.5f));
		
		vtc.Add(new Vector3(-0.5f,-0.5f,-0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,-0.5f));
		vtc.Add(new Vector3(-0.5f,-0.5f,0.5f));
		vtc.Add(new Vector3(0.5f,-0.5f,0.5f));
		
/*		
		vtn.Add(new Vector3(0,0,-1));
		vtn.Add(new Vector3(0,0,-1));
		vtn.Add(new Vector3(0,0,-1));
		vtn.Add(new Vector3(0,0,-1));

		vtn.Add(new Vector3(1,0,0));
		vtn.Add(new Vector3(1,0,0));
		vtn.Add(new Vector3(1,0,0));
		vtn.Add(new Vector3(1,0,0));
		
		vtn.Add(new Vector3(0,0,1));
		vtn.Add(new Vector3(0,0,1));
		vtn.Add(new Vector3(0,0,1));
		vtn.Add(new Vector3(0,0,1));

		vtn.Add(new Vector3(-1,0,0));
		vtn.Add(new Vector3(-1,0,0));
		vtn.Add(new Vector3(-1,0,0));
		vtn.Add(new Vector3(-1,0,0));

		vtn.Add(new Vector3(0,1,0));
		vtn.Add(new Vector3(0,1,0));
		vtn.Add(new Vector3(0,1,0));
		vtn.Add(new Vector3(0,1,0));

		vtn.Add(new Vector3(0,-1,0));
		vtn.Add(new Vector3(0,-1,0));
		vtn.Add(new Vector3(0,-1,0));
		vtn.Add(new Vector3(0,-1,0));
*/		
/*
		Vector2[] uv = new Vector2[ms.uv.Length + 24];
		for(int k = 0;k<ms.uv.Length;k++){
			uv[k] = ms.normals[k];
		}
		uv[i+0] = new Vector2(0,0);
		uv[i+1] = new Vector2(1,0);
		uv[i+2] = new Vector2(0,1);
		uv[i+3] = new Vector2(1,1);

		uv[i+4] = new Vector2(0,0);
		uv[i+5] = new Vector2(1,0);
		uv[i+6] = new Vector2(0,1);
		uv[i+7] = new Vector2(1,1);

		uv[i+8] = new Vector2(0,0);
		uv[i+9] = new Vector2(1,0);
		uv[i+10] = new Vector2(0,1);
		uv[i+11] = new Vector2(1,1);

		uv[i+12] = new Vector2(0,0);
		uv[i+13] = new Vector2(1,0);
		uv[i+14] = new Vector2(0,1);
		uv[i+15] = new Vector2(1,1);

		uv[i+16] = new Vector2(0,0);
		uv[i+17] = new Vector2(1,0);
		uv[i+18] = new Vector2(0,1);
		uv[i+19] = new Vector2(1,1);

		uv[i+20] = new Vector2(0,0);
		uv[i+21] = new Vector2(1,0);
		uv[i+22] = new Vector2(0,1);
		uv[i+23] = new Vector2(1,1);
*/
		for(int k = 0;k<24;k++){
			vtr.Add(Color.red);
			bn.Add(false);
		}

		trir(ms.vertices.Length);	
		for(int n=0;n<ms.vertices.Length;n++){
			if(bn[n]){
				mn.Add(n);
				mv.Add(ms.vertices[n]);
			}
		}
		for(int k=0;k<mn.Count;k++){
			bn[mn[k]] = true;
		}


		ms.SetVertices(vtc);
//		ms.SetNormals(vtn);
		//ms.uv = uv;
		ms.SetColors(vtr);
		covp();
		ms.SetTriangles(vtt,0);	
		ms.RecalculateNormals();
		Bounds b = ms.bounds;
		b.size = b.size*100;
		ms.bounds = b;
        mc.sharedMesh = ms;
    }
    void trir(int i){
    	vtt.Add(i+0);	vtt.Add(i+1);	vtt.Add(i+2);
		vtt.Add(i+1);	vtt.Add(i+3);	vtt.Add(i+2);

		vtt.Add(i+4);	vtt.Add(i+5);	vtt.Add(i+6);
		vtt.Add(i+5);	vtt.Add(i+7);	vtt.Add(i+6);

		vtt.Add(i+8);	vtt.Add(i+9);	vtt.Add(i+10);
		vtt.Add(i+9);	vtt.Add(i+11);	vtt.Add(i+10);

		vtt.Add(i+12);	vtt.Add(i+13);	vtt.Add(i+14);
		vtt.Add(i+13);	vtt.Add(i+15);	vtt.Add(i+14);

		vtt.Add(i+16);	vtt.Add(i+17);	vtt.Add(i+18);
		vtt.Add(i+17);	vtt.Add(i+19);	vtt.Add(i+18);

		vtt.Add(i+20);	vtt.Add(i+21);	vtt.Add(i+22);
		vtt.Add(i+21);	vtt.Add(i+23);	vtt.Add(i+22);		
		
    }

    public void chsv(int n){
    	sv = n;
		svc.anchoredPosition = Vector2.zero;
    }
    public IEnumerator save(){
    	if(ms.vertices.Length>0){
    	yield return new WaitForSeconds(0);
    	date.ms[sv] = Instantiate(ms);
    	ms.Clear();
    	mn.Clear();
		mv.Clear();
		vtc.Clear();
		vtr.Clear();
		vtt.Clear();
		spv.Clear();
		spi.Clear();
		bn.Clear();
		Sprite sp = Sprite.Create(date.rw,new Rect(0,0,50,50),new Vector2(0.5f,0.5f));
		date.se[sv] = sp;
		date.ts[sv] = new Texture2D(50,50,TextureFormat.RGB24,false);
		date.mt[sv] = null;
		Graphics.CopyTexture(date.rw,date.ts[sv]);
		msim[sv].sprite  = sp;
		sclp.gameObject.SetActive(false);
		Start();
		}
    }
    public void load(){
    	if(date.ms[sv]!=null){
    	   	ms.Clear();
    		mn.Clear();
			mv.Clear();
			vtc.Clear();
			vtr.Clear();
			vtt.Clear();
			spv.Clear();
			spi.Clear();
			bn.Clear();
    		ms = Instantiate(date.ms[sv]);
    		box.GetComponent<MeshFilter>().mesh = ms;
    		mc.sharedMesh = ms;
    		for(int i=0;i<ms.vertices.Length;i++){
    			vtc.Add(ms.vertices[i]);
    			vtr.Add(crd);
    			bn.Add(false);
    		}
    		for(int n=0;n<ms.triangles.Length;n++){
    			vtt.Add(ms.triangles[n]);
    		}
		ms.SetVertices(vtc);
		ms.SetColors(vtr);
		covp();
		ms.SetTriangles(vtt,0);	

    	}
    }
    public void loadpls(){
    	if(date.ms[sv]!=null){

    		Mesh mh = Instantiate(date.ms[sv]);
	   		int k = vtc.Count;
    		for(int i=0;i<mh.vertices.Length;i++){
    			vtc.Add(mh.vertices[i]);
    			vtr.Add(crd);
    			bn.Add(false);
    		}
    		
    		for(int n=0;n<mh.triangles.Length;n++){
    			vtt.Add(k+mh.triangles[n]);
    		}
		ms.SetVertices(vtc);
		ms.SetColors(vtr);
		ms.SetTriangles(vtt,0);
//		covp();	
		allc();
		ms.RecalculateNormals();
		box.GetComponent<MeshFilter>().mesh = ms;
    	mc.sharedMesh = ms;
    	}
    }

    public void delm(){
    	if(date.ms[sv]!=null){
    		date.ms[sv] = null;
    		date.se[sv] = null;
			date.ts[sv] = null;
			msim[sv].sprite  = null;
		}
    }
    public void onsp(){
    	for(int i=0;i<50;i++){
    	if(date.ms[i]!=null){
			msim[i].sprite  = date.se[i];
		}
		}
        box.transform.position = Vector3.zero;
        cmr.transform.position = Vector3.zero;
    }

}