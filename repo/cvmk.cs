using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class cvmk : MonoBehaviour {

public MeshFilter ms;
public MeshRenderer mr;

[ContextMenu("Start")]
	// Use this for initialization
	void Start () {
		Vector3[] vc = new Vector3[24];
		vc[0] = new Vector3(-0.5f,0.5f,-0.5f);
		vc[1] = new Vector3(0.5f,0.5f,-0.5f);
		vc[2] = new Vector3(-0.5f,-0.5f,-0.5f);
		vc[3] = new Vector3(0.5f,-0.5f,-0.5f);

		vc[4] = new Vector3(0.5f,0.5f,-0.5f);
		vc[5] = new Vector3(0.5f,0.5f,0.5f);
		vc[6] = new Vector3(0.5f,-0.5f,-0.5f);
		vc[7] = new Vector3(0.5f,-0.5f,0.5f);

		vc[8] = new Vector3(0.5f,0.5f,0.5f);
		vc[9] = new Vector3(-0.5f,0.5f,0.5f);
		vc[10] = new Vector3(0.5f,-0.5f,0.5f);
		vc[11] = new Vector3(-0.5f,-0.5f,0.5f);

		vc[12] = new Vector3(-0.5f,0.5f,0.5f);
		vc[13] = new Vector3(-0.5f,0.5f,-0.5f);
		vc[14] = new Vector3(-0.5f,-0.5f,0.5f);
		vc[15] = new Vector3(-0.5f,-0.5f,-0.5f);

		vc[16] = new Vector3(-0.5f,0.5f,0.5f);
		vc[17] = new Vector3(0.5f,0.5f,0.5f);
		vc[18] = new Vector3(-0.5f,0.5f,-0.5f);
		vc[19] = new Vector3(0.5f,0.5f,-0.5f);
		
		vc[20] = new Vector3(-0.5f,-0.5f,-0.5f);
		vc[21] = new Vector3(0.5f,-0.5f,-0.5f);
		vc[22] = new Vector3(-0.5f,-0.5f,0.5f);
		vc[23] = new Vector3(0.5f,-0.5f,0.5f);
		
		Vector3[] nr = new Vector3[24];
		nr[0] = new Vector3(0,0,-1);
		nr[1] = new Vector3(0,0,-1);
		nr[2] = new Vector3(0,0,-1);
		nr[3] = new Vector3(0,0,-1);

		nr[4] = new Vector3(1,0,0);
		nr[5] = new Vector3(1,0,0);
		nr[6] = new Vector3(1,0,0);
		nr[7] = new Vector3(1,0,0);
		
		nr[8] = new Vector3(0,0,1);
		nr[9] = new Vector3(0,0,1);
		nr[10] = new Vector3(0,0,1);
		nr[11] = new Vector3(0,0,1);

		nr[12] = new Vector3(-1,0,0);
		nr[13] = new Vector3(-1,0,0);
		nr[14] = new Vector3(-1,0,0);
		nr[15] = new Vector3(-1,0,0);

		nr[16] = new Vector3(0,1,0);
		nr[17] = new Vector3(0,1,0);
		nr[18] = new Vector3(0,1,0);
		nr[19] = new Vector3(0,1,0);

		nr[20] = new Vector3(0,-1,0);
		nr[21] = new Vector3(0,-1,0);
		nr[22] = new Vector3(0,-1,0);
		nr[23] = new Vector3(0,-1,0);

		Vector2[] uv = new Vector2[24];
		uv[0] = new Vector2(0,0);
		uv[1] = new Vector2(1,0);
		uv[2] = new Vector2(0,1);
		uv[3] = new Vector2(1,1);

		uv[4] = new Vector2(0,0);
		uv[5] = new Vector2(1,0);
		uv[6] = new Vector2(0,1);
		uv[7] = new Vector2(1,1);

		uv[8] = new Vector2(0,0);
		uv[9] = new Vector2(1,0);
		uv[10] = new Vector2(0,1);
		uv[11] = new Vector2(1,1);

		uv[12] = new Vector2(0,0);
		uv[13] = new Vector2(1,0);
		uv[14] = new Vector2(0,1);
		uv[15] = new Vector2(1,1);

		uv[16] = new Vector2(0,0);
		uv[17] = new Vector2(1,0);
		uv[18] = new Vector2(0,1);
		uv[19] = new Vector2(1,1);

		uv[20] = new Vector2(0,0);
		uv[21] = new Vector2(1,0);
		uv[22] = new Vector2(0,1);
		uv[23] = new Vector2(1,1);

		int[] n = new int[36];
		n[0] = 0;	n[1] = 1;	n[2] = 2;
		n[3] = 1;	n[4] = 3;	n[5] = 2;

		n[6] = 4;	n[7] = 5;	n[8] = 6;
		n[9] = 5;	n[10] = 7;	n[11] = 6;

		n[12] = 8;	n[13] = 9;	n[14] = 10;
		n[15] = 9;	n[16] = 11;	n[17] = 10;

		n[18] = 12;	n[19] = 13;	n[20] = 14;
		n[21] = 13;	n[22] = 15;	n[23] = 14;

		n[24] = 16;	n[25] = 17;	n[26] = 18;
		n[27] = 17;	n[28] = 19;	n[29] = 18;

		n[30] = 20;	n[31] = 21;	n[32] = 22;
		n[33] = 21;	n[34] = 23;	n[35] = 22;		


		ms.mesh.vertices = vc;
		ms.mesh.triangles = n;
		ms.mesh.normals = nr;
		ms.mesh.uv = uv;
		Bounds b = ms.mesh.bounds;
		b.size = b.size*100;
		ms.mesh.bounds = b;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
