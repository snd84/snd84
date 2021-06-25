using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sot : MonoBehaviour {

Mesh ms;
int i;
	// Use this for initialization
	void Start () {
	ms = GetComponent<MeshFilter>().mesh;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	[ContextMenu("maker")]

	void maker(){
	ms = GetComponent<MeshFilter>().sharedMesh;
	int mx = 1122; 
	Vector3[] vec = new Vector3[mx];
	Vector3[] nm = new Vector3[mx];
	Vector2[] uv = new Vector2[mx];
	int j;
	for(i=0;i<140;i++){
 		vec[i*2] = new Vector3(i*2,0,0);
 		vec[(i*2)+1] = new Vector3(i*2,25,0);
 		nm[i*2] = Vector3.back;
 		nm[(i*2)+1] = Vector3.back;
 		uv[i*2].x = (1f/140f)*i;
 		uv[(i*2)+1].x = (1f/140f)*i;
 		uv[i*2].y = 0;
 		uv[(i*2)+1].y = (1f/280f);
	}
	for(i=0;i<140;i++){
 		vec[280+i*2] = new Vector3(280,0,i*2);
 		vec[280+(i*2)+1] = new Vector3(280,25,i*2);
 		nm[280+i*2] = Vector3.right;
 		nm[280+(i*2)+1] = Vector3.right;
		uv[280+(i*2)].x = 1f;
 		uv[280+((i*2)+1)].x = 1f-(1f/280f);
 		uv[280+(i*2)].y = (1f/140f)*i;
 		uv[280+(i*2)+1].y = (1f/140f)*i;
	}
	for(i=0;i<140;i++){
 		vec[560+(i*2)] = new Vector3(280-(i*2),0,280);
 		vec[560+(i*2)+1] = new Vector3(280-(i*2),25,280);
 		nm[560+i*2] = Vector3.left;
 		nm[560+(i*2)+1] = Vector3.left;
 		uv[560+(i*2)].x = 1f-((1f/140f)*i);
 		uv[560+((i*2)+1)].x = 1f-((1f/140f)*i);
 		uv[560+(i*2)].y = 1f;
 		uv[560+(i*2)+1].y = 1f-(1f/280f);
	}
	for(i=0;i<141;i++){
 		vec[840+(i*2)] = new Vector3(0,0,280-(i*2));
 		vec[840+(i*2)+1] = new Vector3(0,25,280-(i*2));
 		nm[840+i*2] = Vector3.forward;
 		nm[840+(i*2)+1] = Vector3.forward;
		uv[840+(i*2)].x = 0f;
 		uv[840+((i*2)+1)].x = (1f/280f);
 		uv[840+(i*2)].y = 1f-((1f/140f)*i);
 		uv[840+(i*2)+1].y = 1f-((1f/140f)*i);
	}
	for(i=0;i<1122;i++){
		vec[i] = transform.InverseTransformPoint(vec[i]);
	}
	int[] t = new int[3366];
	j=0;
	for(i=0;i<560;i++){	
	t[i*6] = j;
	t[i*6+1] = j+1;
	t[i*6+2] = j+2; 

	t[i*6+3] = j+1;
	t[i*6+4] = j+3;
	t[i*6+5] = j+2;
	j+=2;
	}
	
	ms.Clear();
	ms.vertices = vec;
	ms.triangles = t;
	ms.normals = nm;
	ms.uv = uv;
	ms.RecalculateNormals();
	Bounds b = ms.bounds;
	b.size = b.size*2;
	ms.bounds = b;

	}

	public void nm(Vector3 v){
		Invoke("chk",0f);
	}
	public void upck(){
		chk();
	}
	void chk(){
		Vector3[] ves = ms.vertices;
		for(i=0;i<140;i++){
			ves[(i*2)+1].y = date.izm[i,0].x+10;
		}
		for(i=0;i<140;i++){
			ves[280+(i*2)+1].y = date.izm[140,i].x+10;
		}
		for(i=0;i<140;i++){
			ves[560+(i*2)+1].y = date.izm[140-i,140].x+10;
		}
		for(i=0;i<141;i++){
			ves[840+(i*2)+1].y = date.izm[0,140-i].x+10;
		}
		ms.vertices = ves;
	}	
	public void setl(){
		chk();
	}

}
