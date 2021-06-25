using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grund : MonoBehaviour {
Mesh ms;
//MeshRenderer mr;
MeshCollider mc;
public Material mt;
Vector3 ct;
	// Use this for initialization
	void Start () {
	ms = GetComponent<MeshFilter>().mesh;
	mc = GetComponent<MeshCollider>();
	//mr = GetComponent<MeshRenderer>();
	Bounds b = ms.bounds;
	b.Expand(25f);
	ms.bounds = b;
	mc.sharedMesh = ms;
	Vector2[] uv = new Vector2[ms.vertexCount];
	float u = 1f/280f;
	float x = ((int)transform.position.x-10)*u;
	float z = ((int)transform.position.z-10)*u;
	int c = 0;
	for(int i=0;i<21;i+=2){
		for(int j=0;j<21;j+=2){
		uv[c].x = x+(u*j);
		uv[c].y = z+(u*i);
		c++;
		}
	}
	ms.uv = uv;
	}
	
	// Update is called once per frame

	void maker(int xy){
	int mx = xy*xy; 
	Vector3[] vec = new Vector3[mx];
	float s;
	int f = 0;
	s = 20f/(xy-1);
	Vector3 c;
	c = transform.position; 

	int i;
	int j;
	for(i=0;i<xy;i++){
		for(j=0;j<xy;j++){
 		vec[f] = c+new Vector3(j*s,25,i*s);
		vec[f] = transform.InverseTransformPoint(vec[f]);
		f++;
		}
	}

	int z = (xy-1)*(xy-1)*6;
	int[] t = new int[z];
	f=0;
	j=0;
	for(i=0;i<z;i+=6){	
		if(j==xy-1){j=0;f++;}
	t[i] = j+(f*xy);
	t[i+2] = j+(f*xy)+1;
	t[i+1] = j+(f*xy)+xy; 

	t[i+3] = j+(f*xy)+1;
	t[i+4] = j+(f*xy)+xy;
	t[i+5] = j+(f*xy)+xy+1;
	j++;
	}
	
	ms = GetComponent<MeshFilter>().mesh;
	ms.Clear();
	ms.vertices = vec;
	ms.triangles = t;
	Bounds b = ms.bounds;
	b.size = b.size*2;
	ms.bounds = b;
	mc.sharedMesh = ms;
	}

	public void nm(Vector3 v){
	ct = v;
	int l;
	int jx;
	int jz;
	Vector3[] ves = ms.vertices;

	switch (date.hol){
		case 0 :
 			for(l=0;l<ms.vertexCount;l++)
 			{
	 			ves[l] = transform.TransformPoint(ves[l]);
	 			if(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))<(date.hpw*date.hpw))
	 			{
	 					ves[l].y += (date.hsz)/100;
	 			}

	 			 //	ves[l].y = ves[l].y * 100;
		 		//	ves[l].y = Mathf.Round(ves[l].y);
		 		//	ves[l].y = ves[l].y/100;
		 		
	 			if(ves[l].y<0){ves[l].y=0;}
	 			if(ves[l].y>100){ves[l].y=100;}										
				jx = (int)(ves[l].x/2);
		 		jz = (int)(ves[l].z/2);
			 	date.izm[jx,jz].x = ves[l].y;
			 	date.tiz=15;
	 			ves[l] = transform.InverseTransformPoint(ves[l]);
	 		}
	 		break;

	 	case 1 :
	 			for(l=0;l<ms.vertexCount;l++)
 			{
 				ves[l] = transform.TransformPoint(ves[l]);
	 			if(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))<(date.hpw*date.hpw))
	 			{
	 				ves[l].y += (((date.hpw*date.hpw)-
	 				(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))))/(date.hpw*date.hpw))
	 				*(date.hsz)/100;
	 			}

	 			if(ves[l].y<0){ves[l].y=0;}
	 			if(ves[l].y>100){ves[l].y=100;}	
				jx = (int)(ves[l].x/2);
		 		jz = (int)(ves[l].z/2);
			 	date.izm[jx,jz].x = ves[l].y;
			 	date.tiz=15;
	 			ves[l] = transform.InverseTransformPoint(ves[l]);
	 		}
	 		break;
	 	
	 	case 2 :
	 		 	for(l=0;l<ms.vertexCount;l++)
 			{ 	
 				ves[l] = transform.TransformPoint(ves[l]);
	 			if(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))<(date.hpw*date.hpw))
	 			{
	 					ves[l].y +=  ((date.hsz+50)-ves[l].y)/100;
	 			}
	 			ves[l].y = ves[l].y * 100;
		 		ves[l].y = Mathf.Round(ves[l].y);
		 		ves[l].y = ves[l].y/100;

	 			if(ves[l].y<0){ves[l].y=0;}
	 			if(ves[l].y>100){ves[l].y=100;}
				jx = (int)(ves[l].x/2);
		 		jz = (int)(ves[l].z/2);
			 	date.izm[jx,jz].x = ves[l].y;
			 	date.tiz=15;
	 			ves[l] = transform.InverseTransformPoint(ves[l]);
	 		}
			break;
	 	case 3 :
			 	for(l=0;l<ms.vertexCount;l++)
 			{ 	
 				ves[l] = transform.TransformPoint(ves[l]);
	 			if(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))<(date.hpw*date.hpw))
	 			{
	 					ves[l].y += (((date.hpw*date.hpw)-
	 							(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))))/(date.hpw*date.hpw))
	 							* ((ct.y)-ves[l].y)*(0.001f*date.hsz);
	 			}
	 			ves[l].y = ves[l].y * 100;
		 		ves[l].y = Mathf.Round(ves[l].y);
		 		ves[l].y = ves[l].y/100;

	 			if(ves[l].y<0){ves[l].y=0;}
	 			if(ves[l].y>100){ves[l].y=100;}
				jx = (int)(ves[l].x/2);
		 		jz = (int)(ves[l].z/2);
			 	date.izm[jx,jz].x = ves[l].y;
			 	date.tiz=15;
	 			ves[l] = transform.InverseTransformPoint(ves[l]);
			}
			break;
	}
	 			//if(co.tag == "moru"){ves[l].y += main.mhl;}
	 			//	if(ves[l].y>100){ves[l].y=100;}
	int[] tr = ms.triangles;
	int i=0;
	for(int n=0;n<10;n++){
		for(int r=0;r<10;r++){
			if(ves[(n*11) + r].y+ves[(n*11) + r+12].y > ves[(n*11) + r+1].y+ves[(n*11) + r+11].y){
				tr[i] = r+(n*11);
				tr[i+1] = r+(n*11)+11; 
				tr[i+2] = r+(n*11)+1;				
				tr[i+3] = r+(n*11)+11;
				tr[i+4] = r+(n*11)+12;
				tr[i+5] = r+(n*11)+1;
				}else{
				tr[i] = r+(n*11);
				tr[i+1] = r+(n*11)+11; 
				tr[i+2] = r+(n*11)+12;
				tr[i+3] = r+(n*11);
				tr[i+4] = r+(n*11)+12;
				tr[i+5] = r+(n*11)+1;				
				}
			i+=6;
		}
	}
	ms.triangles = tr;
	ms.vertices = ves;		
	mc.sharedMesh = ms;
	
}

public void upck(){
	Vector3[] ves = ms.vertices;
	for(int n=0;n<ms.vertexCount;n++){
	ves[n] = transform.TransformPoint(ves[n]);
	ves[n].y = date.izm[(int)(ves[n].x/2f),(int)(ves[n].z/2f)].x;
	ves[n] = transform.InverseTransformPoint(ves[n]);
	}

	int[] tr = ms.triangles;
	int i=0;
	for(int n=0;n<10;n++){
		for(int r=0;r<10;r++){
			if(ves[(n*11) + r].y+ves[(n*11) + r+12].y > ves[(n*11) + r+1].y+ves[(n*11) + r+11].y){
				tr[i] = r+(n*11);
				tr[i+1] = r+(n*11)+11; 
				tr[i+2] = r+(n*11)+1;				
				tr[i+3] = r+(n*11)+11;
				tr[i+4] = r+(n*11)+12;
				tr[i+5] = r+(n*11)+1;
				}else{
				tr[i] = r+(n*11);
				tr[i+1] = r+(n*11)+11; 
				tr[i+2] = r+(n*11)+12;
				tr[i+3] = r+(n*11);
				tr[i+4] = r+(n*11)+12;
				tr[i+5] = r+(n*11)+1;				
				}
			i+=6;
		}
	}
	ms.triangles = tr;
	ms.vertices = ves;		
	mc.sharedMesh = ms;
}

public void bk(Vector3 v,int k,int n){
	ct = v;
	int l;
	int jx;
	int jz;
	Vector3[] ves = ms.vertices;

 	for(l=0;l<ms.vertexCount;l++)
 		{
	 		ves[l] = transform.TransformPoint(ves[l]);
	 		if(((ct.x-ves[l].x) * (ct.x-ves[l].x))+((ct.z-ves[l].z) * (ct.z-ves[l].z))<(n*n))
	 		{
	 			 	ves[l].y += (((n*n) - (((ct.x-ves[l].x) * (ct.x-ves[l].x)) + ((ct.z-ves[l].z) * (ct.z-ves[l].z))))/(n*n))
	 				* ((float)k/10f);
	 		}
	 			 //	ves[l].y = ves[l].y * 100;
		 		//	ves[l].y = Mathf.Round(ves[l].y);
		 		//	ves[l].y = ves[l].y/100;
		 		
	 		if(ves[l].y<0){ves[l].y=0;}
	 		if(ves[l].y>100){ves[l].y=100;}										
			jx = (int)(ves[l].x/2);
		 	jz = (int)(ves[l].z/2);
			date.izm[jx,jz].x = ves[l].y;
			date.tiz=11;
	 		ves[l] = transform.InverseTransformPoint(ves[l]);
	 }

	ms.vertices = ves;		
	mc.sharedMesh = ms;
	
}

public  void setl(){
Vector3[] ves = ms.vertices;
	for(int i=0;i<ms.vertexCount;i++){
	 	ves[i] = transform.TransformPoint(ves[i]);
		ves[i].y = date.izm[(int)(ves[i].x/2f),(int)(ves[i].z/2f)].x;
		ves[i] =transform.InverseTransformPoint(ves[i]);
		}
	ms.vertices = ves;		
	mc.sharedMesh = ms;	
}

}
