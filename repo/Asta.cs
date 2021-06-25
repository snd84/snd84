using System.Collections;
using System.Collections.Generic;
using UnityEngine;
　
public class Asta : MonoBehaviour
{

Vector3[,] tnsk;
int[,] bm;
int[] xy = new int[4];
List<int> cnt;
public int slb=0;
int pk=0;

Mesh ms;
public Vector3 on;
public Vector3 ut;

    // Start is called before the first frame update
    void Start()
    {
   	int xy = 141;
	int mx = xy*xy; 
	Vector3[] vec = new Vector3[mx];
	float s;
	int f = 0;
	s = 2f;
	Vector3 c;
	c = transform.position; 

	int i;
	int j;
	for(i=0;i<xy;i++){
		for(j=0;j<xy;j++){
 		vec[f] = c+new Vector3(i*s,25,j*s);
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
    }

    // Update is called once per frame
    void Update()
    {
    	if(slb==0){
    		on = new Vector3(5,0,5);//UnityEngine.Random.Range(0,140),0,UnityEngine.Random.Range(0,140));
    		ut = new Vector3(240,0,240);//UnityEngine.Random.Range(0,140),0,UnityEngine.Random.Range(0,140));
    		tbit(on,ut);
    	}
    	if(slb>0){
    		slb--;
    		if(slb==1){
    		slb=3;
    		tbox();
    		ms = GetComponent<MeshFilter>().mesh;
   			Vector3[] vec = ms.vertices;
   			for(int i=0;i<141;i++){
   				for(int j=0;j<141;j++){
   				vec[(i*141) + j].y = 0+(tnsk[(int)(i/2),(int)(j/2)].y/2f);
   				//if(bm[i,j]==2){vec[(i*141) + j].y = 5;}
   				//if(bm[i,j]==1){vec[(i*141) + j].y = 0+(tnsk[(int)(i/3),(int)(j/3)].y/2f);}
   				//if(bm[i,j]==0){vec[(i*141) + j].y = -5;}
   				}
   			}
    		ms.vertices = vec;
    		}
    		if(slb==-2){
    		ms = GetComponent<MeshFilter>().mesh;
   			Vector3[] vec = ms.vertices;
   			for(int i=0;i<141;i++){
   			for(int j=0;j<141;j++){
   		//	vec[(i*141) + j].y = (tnsk[(int)(i/2),(int)(j/2)].y + tnsk[(int)(i/2),(int)(j/2)].z)/10f;

   			if(bm[(int)(i/2),(int)(j/2)]==3){vec[(i*141) + j].y = tnsk[(int)(i/2),(int)(j/2)].y;}
   			if(bm[(int)(i/2),(int)(j/2)]==2){vec[(i*141) + j].y = 25;}
 			if(bm[(int)(i/2),(int)(j/2)]==1){vec[(i*141) + j].y = 5;}
  			if(bm[(int)(i/2),(int)(j/2)]==0){vec[(i*141) + j].y = 0;}
   			}
   			}
   			ms.vertices = vec;
   			slb=-5;

    		}
    	}
        
    }
	void tbit(Vector3 ip,Vector3 op){
		xy[0] = (int)(ip.x/4);
		xy[1] = (int)(ip.z/4);
		xy[2] = (int)(op.x/4);
		xy[3] = (int)(op.z/4);
		tnsk = new Vector3[71,71];
		bm = new int[71,71];
		for(int i=0;i<70;i++){
			for(int j=0;j<70;j++){
				tnsk[i,j].z =  (Mathf.Abs(xy[2]-i) + Mathf.Abs(xy[3] - j))*2;
				tnsk[i,j].x = 
				(date.izm[1+(i*2),1+(j*2)].x+date.izm[1+(i*2),j*2].x+
				date.izm[i*2,1+(j*2)].x+date.izm[(i*2),(j*2)].x)/4f;
				tnsk[i,j].y = 0;
			}
		}
		for(int i=0;i<70;i++){
			tnsk[i,70].z =  (Mathf.Abs(xy[2]-i) + Mathf.Abs(xy[3] - 70))*2;
			tnsk[i,70].x = 
				(date.izm[(i*2),140].x+date.izm[(i*2)+1,140].x)/2f;
			tnsk[i,70].y = 0;
			tnsk[70,i].z =  (Mathf.Abs(xy[2]-70) + Mathf.Abs(xy[3] - i))*2;
			tnsk[70,i].x = 
				(date.izm[140,i*2].x+date.izm[140,(i*2)+1].x)/2f;
			tnsk[70,i].y = 0;
		}
		bm[xy[0],xy[1]] = 1;		
		tnsk[xy[0],xy[1]].y = 0;
		cnt = new List<int>();
		cnt.Add(xy[0]);
		cnt.Add(xy[1]);
		slb=10;
		pk=0;
	}
    void tbox(){

		int i=0;
		int j=0;
		int ii=0;
		int jj=0;
		for(int inf=0;inf<2;inf++){
		ii = cnt[pk];
		jj = cnt[pk+1];
		cnt.RemoveAt(pk+1);
		cnt.RemoveAt(pk);
		for(i = -1+ii; i < 2+ii; i++){
			for(j = -1+jj; j < 2+jj; j++){
			if(i>=0 && i <71 && j>=0 && j <71 && bm[i,j] == 0){ 
				if(tnsk[i,j].x < tnsk[ii,jj].x + 1f)
				{
				tnsk[i,j].y = tnsk[ii,jj].y+1f;
				//tnsk[i,j].x = tnsk[i,j].z + tnsk[i,j].y;
				bm[i,j] = 1;
				cnt.Add(i);
				cnt.Add(j);print(cnt.Count);
				if(i==xy[2]&&j==xy[3]){bm[ii,jj]=2;chbk();slb=-2;return;}
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
		}else{slb=-2;return;}
		}
//		end:
	}
	void chbk(){
		int i=0;
		int j=0;
		int ii=xy[2];
		int jj=xy[3];
		for(int inf=0;inf<1000;inf++){

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
	[ContextMenu ("set")]
	void set(){
		tbit(on,ut);
	}

}
