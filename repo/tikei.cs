using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tikei : MonoBehaviour {
	//gr[] Vector3;
	public Material mat;
	public grund gd;
	public Image im;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	[ContextMenu ("sm")]

	void sm(){
		GameObject g = new GameObject();
		g.AddComponent<MeshFilter>();
		Mesh ms = new Mesh();
			int xy = 11;
			float f = 20f/(xy-1);
			Vector3[] vec = new Vector3[xy*xy];
			Vector3[] nm = new Vector3[xy*xy];
			Vector2[] uv = new Vector2[xy*xy];
			int t=0;
			int i;
			int j;
				for(i=0;i<xy;i++){
					for(j=0;j<xy;j++){
					vec[t] = new Vector3(j*f,25,i*f);
					vec[t] = vec[t]- new Vector3(10f,0f,10f);
					nm[t] = Vector3.up;
					//uv[t] = new Vector2(0.1f*j,0.1f*i);

					t++;
					}
				}
			int z = (xy-1) * (xy-1) *6;
			int[] zt = new int[z];
			t=0;
			j=0;
			for(i=0;i<z;i+=6){	
				if(j==xy-1){j=0;t++;}
				zt[i] = j+(t*xy);
				zt[i+2] = j+(t*xy)+1;
				zt[i+1] = j+(t*xy)+xy; 

				zt[i+3] = j+(t*xy)+1;
				zt[i+4] = j+(t*xy)+xy;
				zt[i+5] = j+(t*xy)+xy+1;
				j++;
			}

		ms.vertices = vec;
		ms.triangles = zt;
		ms.normals = nm;
		//ms.uv = uv;
		g.GetComponent<MeshFilter>().mesh = ms;

		g.AddComponent<MeshRenderer>();
		g.GetComponent<MeshRenderer>().material =mat;
		//g.AddComponent<Rigidbody>();
		//g.GetComponent<Rigidbody>().useGravity = false;
		//g.GetComponent<Rigidbody>().isKinematic = true;
		//g.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		g.AddComponent<grund>();
		g.AddComponent<MeshCollider>();
		g.GetComponent<MeshCollider>().sharedMesh = ms;
		g.gameObject.tag = ("zimen");
		g.gameObject.layer = 8;


		for(i=0;i<14;i++){
			for(j=0;j<14;j++){
				Instantiate(g,new Vector3(10f+20f*i,0f,10f+20f*j),Quaternion.identity,transform);
			}
		}
		DestroyImmediate(g);
		
	}
	public void stl(){
		gameObject.BroadcastMessage("setl");
	}
	public void dflt(){
		for(int i=0;i<141;i++){
			for(int j=0;j<141;j++){
				date.izm[i,j].x = 25;
				date.izm[i,j].y = 0;
				date.tiz = 11;
			}
		}
		Color[] c = new Color[1024*1024];
		for(int i=0;i <c.Length;i++){
		c[i] = Color.white;
		}
		date.ftx = new Texture2D(1024,1024,TextureFormat.RGBA32,false);
		date.ftx.filterMode = FilterMode.Point;
		date.ftx.SetPixels(c);
		mat.mainTexture = date.ftx;
		date.ftx.Apply();	
		mat.SetColor("_OutlineColor",new Color32(112,93,78,255));
		mat.color = new Color32(255,216,160,255);	
		stl();
		im.color = new Color32(255,216,160,255);
	}
}
