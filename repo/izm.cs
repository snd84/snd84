using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izm : MonoBehaviour {

public Mesh ms;
public MeshCollider mc;
int t;
int i;
int j;
int n;
int e;
bool  b;
static public int q=1;
//bool  c;

//float[141 i,141];
int[] m = new int[119286];
Vector3[] vc= new Vector3[19881];

public static Vector4[,] sgp = new Vector4[141,141];
void  Start (){
	maker();
	for(t=0;t<141;t++){
		for(j=0;j<141;j++){
			date.izm[t,j].x =25;
			date.izm[t,j].y =0;
			sgp[t,j]=Vector3.zero;
		}
	}
	Bounds b = ms.bounds;
	b.size = b.size*2;
}

void  Update (){
	if(date.tiz>0){
		if(date.vl>0 && date.tiz==15){stay();}
	//	if(date.tiz==12){tkiset();}
		if(date.tiz==10){st2();}
		if(date.tiz==9){st2j();up();}
		if(date.tiz==8){sgre();}
		if(date.tiz==8){nams();}
		if(date.tiz==6){wav();}
		//if(date.tiz==1){tktn();}
		//if(date.tiz==48){stay();}
		//if(date.tiz==1){ses();}
		date.tiz--;
	}
}
void sgre(){
	for(i=0;i<141;i++){
		for(j=0;j<141;j++){
			sgp[i,j].y=0;
			if((int)sgp[i,j].w==-q){
			sgp[i,j].x=0;
			sgp[i,j].z=0;
			sgp[i,j].w=0;
			}else if(sgp[i,j].z<0.1f){
			sgp[i,j].x=0;
			sgp[i,j].z=0;
			sgp[i,j].w=0;
			}
		}
	}
}


void tktn(){
	for(int i=0;i<140;i++){
		for(int j=0;j<140;j++){
			date.map[i,j].x = date.izm[i,j].x - date.izm[i+1,j].x;
		}
	}
	for(int i=0;i<140;i++){
		for(int j=0;j<140;j++){
			date.map[i,j].y = date.izm[i,j].x - date.izm[i,j+1].x;
		}
	}

}

void  stay (){
	date.vl = 0;
	//int k;
	for(t=0;t<141;t++){
			for(j=0;j<141;j++){
				if(date.izm[j,t].y<0.05f){date.izm[j,t].y=0;}
					date.izm[j,t].z = date.izm[j,t].x+date.izm[j,t].y;
				if(date.izm[j,t].y>0){
					date.vl += date.izm[j,t].y;
					vc[j+(141*t)].y = date.izm[j,t].z;
					if(date.izm[j,t].x<date.umi){date.izm[j,t].y = 0;}
				}else{
					vc[j+(141*t)].y = date.izm[j,t].z-0.5f;
				}

		}
	}
	ms.vertices = vc;
}

void  st2 (){

	date.vl = 0;
	for(t=0;t<141;t++){
		for(j=0;j<141;j++){
			if(date.izm[j,t].y<0.05f){date.izm[j,t].y=0;}
			date.izm[j,t].z = date.izm[j,t].x+date.izm[j,t].y;
			if(date.izm[j,t].y>0){
				date.vl += date.izm[j,t].y;
				vc[j+(141*t)].y = date.izm[j,t].z + sgp[j,t].z;
				if(date.izm[j,t].x<date.umi){date.izm[j,t].y = 0;}
			}else{
				vc[j+(141*t)].y = date.izm[j,t].z-0.1f;
				}
		}
	}
}
void st2j(){
	float f;
	for(t=1;t<140;t++){
			for(j=1;j<140;j++){
				if(date.izm[j,t].y<0.1f){
				f=0;
				n=0;

				if(date.izm[j,t+1].y>0){f+=date.izm[j,t+1].z;n++;}
				if(date.izm[j+1,t+1].y>0){f+=date.izm[j+1,t+1].z;n++;}
				if(date.izm[j+1,t].y>0){f+=date.izm[j+1,t].z;n++;}
				if(date.izm[j+1,t-1].y>0){f+=date.izm[j+1,t-1].z;n++;}
				if(date.izm[j,t-1].y>0){f+=date.izm[j,t-1].z;n++;}
				if(date.izm[j-1,t-1].y>0){f+=date.izm[j-1,t-1].z;n++;}
				if(date.izm[j-1,t].y>0){f+=date.izm[j-1,t].z;n++;}
				if(date.izm[j-1,t+1].y>0){f+=date.izm[j-1,t+1].z;n++;}
				if(f/(float)n <=date.izm[j,t].z){
				vc[j+(141*t)].y = (f/(float)n)-0.1f;
				}else{
				vc[j+(141*t)].y = date.izm[j,t].z-0.5f;
				}
			}

		}
	}
	ms.vertices = vc;
}

void nams(){
	for(t=1;t<139;t++){
		for(j=1;j<139;j++){
			if(sgp[t,j].x>0 && (int)sgp[t,j].w == q && date.izm[t,j].y>0.05f){
				e=1;
			switch((int)sgp[t,j].x){
				case 9:
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 1;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
				
				sgp[t+1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j+1].x = 2;
				sgp[t+1,j+1].y = sgp[t+1,j+1].z;
				sgp[t+1,j+1].w = -q;
			
				sgp[t+1,j].z = sgp[t,j].z*0.85f;
				sgp[t+1,j].x = 3;
				sgp[t+1,j].y = sgp[t+1,j].z;
				sgp[t+1,j].w = -q;

				sgp[t+1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j-1].x = 4;
				sgp[t+1,j-1].y = sgp[t+1,j-1].z;
				sgp[t+1,j-1].w = -q;

				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 5;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;

				sgp[t-1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j-1].x = 6;
				sgp[t-1,j-1].y = sgp[t-1,j-1].z;
				sgp[t-1,j-1].w = -q;

				sgp[t-1,j].z = sgp[t,j].z*0.85f;
				sgp[t-1,j].x = 7;
				sgp[t-1,j].y = sgp[t-1,j].z;
				sgp[t-1,j].w = -q;

				sgp[t-1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j+1].x = 8;
				sgp[t-1,j+1].y = sgp[t-1,j+1].z;
				sgp[t-1,j+1].w = -q;

				break;
				
				case 1:
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 2;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
		//		sgp[t+1,j].z += sgp[t,j].z*0.85f;
		//		sgp[t+1,j].x = 2;
		//		sgp[t+1,j].y = -sgp[t+1,j].z;
		//		sgp[t+1,j].w = -q;
		//		sgp[t-1,j].z += sgp[t,j].z*0.85f;
		//		sgp[t-1,j].x = 8;
		//		sgp[t-1,j].y = -sgp[t-1,j].z;
		//		sgp[t-1,j].w = -q;
				break;
				case 2:
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 1;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
				sgp[t+1,j].z = sgp[t,j].z*0.85f;
				sgp[t+1,j].x = 2;
				sgp[t+1,j].y = sgp[t+1,j].z;
				sgp[t+1,j].w = -q;

				break;
				case 3:
		//		sgp[t,j+1].z += sgp[t,j].z*0.85f;
		//		sgp[t,j+1].x = 2;
		//		sgp[t,j+1].y = -sgp[t,j+1].z;
		//		sgp[t,j+1].w = -q;					
				sgp[t+1,j].z = sgp[t,j].z*0.85f;
				sgp[t+1,j].x = 3;
				sgp[t+1,j].y = sgp[t+1,j].z;
				sgp[t+1,j].w = -q;
				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 4;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;
				break;
				case 4:
				sgp[t+1,j].z = sgp[t,j].z*0.85f;
				sgp[t+1,j].x = 3;
				sgp[t+1,j].y = sgp[t+1,j].z;
				sgp[t+1,j].w = -q;
				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 4;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;
				sgp[t+1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j-1].y = sgp[t,j-1].z;
				sgp[t+1,j-1].w = -q;
				break;
				case 5:
		//		sgp[t+1,j].z += sgp[t,j].z*0.85f;
		//		sgp[t+1,j].x = 4;
		//		sgp[t+1,j].y = -sgp[t+1,j].z;	
		//		sgp[t+1,j].w = -q;	
				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 6;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;
		//		sgp[t-1,j].z += sgp[t,j].z*0.85f;
		//		sgp[t-1,j].x = 6;
		//		sgp[t-1,j].y = -sgp[t-1,j].z;
		//		sgp[t-1,j].w = -q;
				break;
				case 6:
				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 5;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;
				sgp[t-1,j].z = sgp[t,j].z*0.85f;
				sgp[t-1,j].x = 6;
				sgp[t-1,j].y = sgp[t-1,j].z;
				sgp[t-1,j].w = -q;
				break;
				
				case 7:
		//		sgp[t,j-1].z += sgp[t,j].z*0.14f;
		//		sgp[t,j-1].x = 6;
		//		sgp[t,j-1].y = -sgp[t,j-1].z;
		//		sgp[t,j-1].w = -q;				
				sgp[t-1,j].z = sgp[t,j].z*0.85f;
				sgp[t-1,j].x = 7;
				sgp[t-1,j].y = sgp[t-1,j].z;
				sgp[t-1,j].w = -q;
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 8;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
				sgp[t-1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j+1].y = sgp[t,j].z;
				sgp[t-1,j+1].w = -q;

				break;
				case 8:
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 8;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
				sgp[t-1,j].z = sgp[t,j].z*0.85f;
				sgp[t-1,j].x = 7;
				sgp[t-1,j].y = sgp[t-1,j].z;
				sgp[t-1,j].w = -q;

				break;
				case 11:
				sgp[t,j].y = sgp[t,j].z;
				sgp[t,j+1].z = sgp[t,j].z*0.85f;
				sgp[t,j+1].x = 11;
				sgp[t,j+1].y = sgp[t,j+1].z;
				sgp[t,j+1].w = -q;
				sgp[t-1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j+1].x = 8;
				sgp[t-1,j+1].y = sgp[t-1,j+1].z;
				sgp[t-1,j+1].w = -q;
				sgp[t+1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j+1].x = 2;
				sgp[t+1,j+1].y = sgp[t+1,j+1].z;
				sgp[t+1,j+1].w = -q;
				break;
				case 13:
				sgp[t,j].y = sgp[t,j].z;
				sgp[t+1,j].z = sgp[t,j].z*0.85f;
				sgp[t+1,j].x = 13;
				sgp[t+1,j].y = sgp[t+1,j].z;
				sgp[t+1,j].w = -q;
				sgp[t+1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j+1].x = 2;
				sgp[t+1,j+1].y = sgp[t+1,j+1].z;
				sgp[t+1,j+1].w = -q;
				sgp[t+1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j-1].x = 4;
				sgp[t+1,j-1].y = sgp[t+1,j-1].z;
				sgp[t+1,j-1].w = -q;
				break;
				case 15:
				sgp[t,j].y = sgp[t,j].z;
				sgp[t,j-1].z = sgp[t,j].z*0.85f;
				sgp[t,j-1].x = 15;
				sgp[t,j-1].y = sgp[t,j-1].z;
				sgp[t,j-1].w = -q;
				sgp[t-1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j-1].x = 6;
				sgp[t-1,j-1].y = sgp[t-1,j-1].z;
				sgp[t-1,j-1].w = -q;
				sgp[t+1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t+1,j-1].x = 4;
				sgp[t+1,j-1].y = sgp[t+1,j-1].z;
				sgp[t+1,j-1].w = -q;
				break;
				case 17:
				sgp[t,j].y = sgp[t,j].z;
				sgp[t-1,j].z = sgp[t,j].z*0.85f;
				sgp[t-1,j].x = 17;
				sgp[t-1,j].y = sgp[t-1,j].z;
				sgp[t-1,j].w = -q;
				sgp[t-1,j-1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j-1].x = 6;
				sgp[t-1,j-1].y = sgp[t-1,j-1].z;
				sgp[t-1,j-1].w = -q;
				sgp[t-1,j+1].z = sgp[t,j].z*0.85f;
				sgp[t-1,j+1].x = 8;
				sgp[t-1,j+1].y = sgp[t-1,j+1].z;
				sgp[t-1,j+1].w = -q;
				break;
			
			}
			sgp[t,j].x=0;
			sgp[t,j].z=0;
			//sgp[t,j].w=0;
		}

		}
	}
	q = -q; 
}

void  up (){
	t = 0;
	j = 0;
	//int k;
	int n = 0;


		for(t=0;t<140;t++){
			for(j=0;j<140;j++){
				if(date.izm[j,t].y>0 || date.izm[j,t+1].y>0 || date.izm[j+1,t].y>0 || date.izm[j+1,t+1].y>0){
					//k = (t*141) + j;

					m[n]=j+(t*141);
					n++;
					m[n]=j+((t+1)*141);
					n++;
					m[n]=1+j+(t*141);
					n++;
					m[n]=1+j+(t*141);
					n++;
					m[n]=j+((1+t)*141);
					n++;
					m[n]=j+((1+t)*141)+1;
					n++;
				}
			}
		}

		
		
	int[] mm = new int[n];
	for(int a=0;a<n;a++){
		mm[a]=m[a];
	}
//	ms.Clear();
//	ms.vertices = i;
	ms.triangles = mm;
	//mc.sharedMesh = ms;
}
void  wav (){
if(b){
	wx(1);
	wz(1);
	we();
	}else{
	wz(0);
	wx(0);	
	we();
	}
if(b){b=false;}else{b=true;}
if(e>=1){date.tiz=11;e=0;}

}

void  wx (int n){
	int k;
	int p;
		for(p=1+n;p<140;p+=2){
			for(k=0;k<140;k++){
				if(date.izm[k,p].y>=0.05f){		
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y)>0.1f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k,p-1].y += 0.05f;
					e=1;
					if(date.izm[k,p].y>0.5f){
						if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y)>0.5f){
							date.izm[k,p].y -= 0.1f;
							date.izm[k,p-1].y += 0.1f;
							if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y)>0.5f){
							if(date.izm[k,p].y>0.8f){
							date.izm[k,p].y -= 0.1f;
							date.izm[k,p-1].y += 0.1f;
							}
							}
						}
					}
				}
			}
			if(date.izm[k,p].y>=0.05f){	
				if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y)>0.1f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k,p+1].y += 0.05f;
					e=1;
					if(date.izm[k,p].y>0.5f){
						if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y)>0.5f){						
							date.izm[k,p].y -= 0.1f;
							date.izm[k,p+1].y += 0.1f;
							if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y)>0.5f){
							if(date.izm[k,p].y>0.8f){					
							date.izm[k,p].y -= 0.1f;
							date.izm[k,p+1].y += 0.1f;
							}
							}
						}
					}
				}
			}
				if(date.izm[k,p-1].y>=0.05f){
					if((date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.1f){
					date.izm[k,p].y += 0.05f;
					date.izm[k,p-1].y -= 0.05f;
					if((date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
					if(date.izm[k,p-1].y>0.5f){
						date.izm[k,p].y += 0.1f;
						date.izm[k,p-1].y -= 0.1f;
							if((date.izm[k,p-1].x+date.izm[k,p-1].y+sgp[k,p-1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
							if(date.izm[k,p-1].y>0.8f){
							date.izm[k,p].y += 0.1f;
							date.izm[k,p-1].y -= 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
				if(date.izm[k,p+1].y>=0.05f){
					if((date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.1f){	
					date.izm[k,p].y += 0.05f;
					date.izm[k,p+1].y -= 0.05f;
					if((date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){	
						if(date.izm[k,p+1].y>0.5f){	
						date.izm[k,p].y += 0.1f;
						date.izm[k,p+1].y -= 0.1f;
							if((date.izm[k,p+1].x+date.izm[k,p+1].y+sgp[k,p+1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){	
							if(date.izm[k,p+1].y>0.8f){	
							date.izm[k,p].y += 0.1f;
							date.izm[k,p+1].y -= 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
			}
		}
			
		for(p=1+n;p<140;p+=2){
			for(k=1;k<140;k++){
				if(date.izm[k,p].y>=0.05f){
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k-1,p-1].x+date.izm[k-1,p-1].y+sgp[k-1,p-1].y)>0.2f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k-1,p-1].y += 0.05f;
					e=1;
					}
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k+1,p-1].x+date.izm[k+1,p-1].y+sgp[k+1,p-1].y)>0.2f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k+1,p-1].y += 0.05f;
					e=1;
					}
				}
				if(date.izm[k-1,p-1].y>=0.05f){
					if((date.izm[k-1,p-1].x+date.izm[k-1,p-1].y+sgp[k-1,p-1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.2f){
					date.izm[k,p].y += 0.05f;
					date.izm[k-1,p-1].y -= 0.05f;
					e=1;
					}
				}
				if(date.izm[k+1,p-1].y>=0.05f){
					if((date.izm[k+1,p-1].x+date.izm[k+1,p-1].y+sgp[k+1,p-1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.2f){
					date.izm[k,p].y += 0.05f;
					date.izm[k+1,p-1].y -= 0.05f;
					e=1;
					}

			}

			}
		}


}
void  wz (int n){
	int k;
	int p;
		for(k=1+n;k<140;k+=2){
			for(p=0;p<140;p++){
				if(date.izm[k,p].y>=0.05f){
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y)>0.1f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k-1,p].y += 0.05f;
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y)>0.5f){
						if(date.izm[k,p].y>0.5f){
						date.izm[k,p].y -= 0.1f;
						date.izm[k-1,p].y += 0.1f;
							if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y)>0.5f){
							if(date.izm[k,p].y>0.8f){
							date.izm[k,p].y -= 0.1f;
							date.izm[k-1,p].y += 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
				if(date.izm[k,p].y>=0.05f){
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y)>0.1f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k+1,p].y += 0.05f;
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y)>0.5f){
						if(date.izm[k,p].y>0.5f){
						date.izm[k,p].y -= 0.1f;
						date.izm[k+1,p].y += 0.1f;
							if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y)>0.5f){
							if(date.izm[k,p].y>0.8f){
							date.izm[k,p].y -= 0.1f;
							date.izm[k+1,p].y += 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
				if(date.izm[k-1,p].y>=0.05f){
					if((date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.1f){
					date.izm[k,p].y += 0.05f;
					date.izm[k-1,p].y -= 0.05f;
					if((date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
						if(date.izm[k-1,p].y>=0.5f){
						date.izm[k,p].y += 0.1f;
						date.izm[k-1,p].y -= 0.1f;
							if((date.izm[k-1,p].x+date.izm[k-1,p].y+sgp[k-1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
							if(date.izm[k-1,p].y>=0.8f){
							date.izm[k,p].y += 0.1f;
							date.izm[k-1,p].y -= 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
				if(date.izm[k+1,p].y>=0.05f){
					if((date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.1f){
					date.izm[k,p].y += 0.05f;
					date.izm[k+1,p].y -= 0.05f;
					if((date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
						if(date.izm[k+1,p].y>0.5f){
						date.izm[k,p].y += 0.1f;
						date.izm[k+1,p].y -= 0.1f;
							if((date.izm[k+1,p].x+date.izm[k+1,p].y+sgp[k+1,p].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.5f){
							if(date.izm[k+1,p].y>0.8f){
							date.izm[k,p].y += 0.1f;
							date.izm[k+1,p].y -= 0.1f;
							}
							}
						}
					}
					e=1;
					}
				}
			}
		}
		for(k=1+n;k<140;k+=2){
			for(p=1;p<140;p++){
				if(date.izm[k,p].y>=0.05f){
					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k-1,p+1].x+date.izm[k-1,p+1].y+sgp[k-1,p+1].y)>0.2f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k-1,p+1].y += 0.05f;
					e=1;
					}

					if((date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y) - (date.izm[k+1,p+1].x+date.izm[k+1,p+1].y+sgp[k+1,p+1].y)>0.2f){
					date.izm[k,p].y -= 0.05f;
					date.izm[k+1,p+1].y += 0.05f;
					e=1;
					}
				}
				if(date.izm[k-1,p+1].y>=0.05f){
					if((date.izm[k-1,p+1].x+date.izm[k-1,p+1].y+sgp[k-1,p+1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.2f){
					date.izm[k,p].y += 0.05f;
					date.izm[k-1,p+1].y -= 0.05f;
					e=1;
					}
				}
				if(date.izm[k+1,p+1].y>=0.05f){
					if((date.izm[k+1,p+1].x+date.izm[k+1,p+1].y+sgp[k+1,p+1].y) - (date.izm[k,p].x+date.izm[k,p].y+sgp[k,p].y)>0.2f){
					date.izm[k,p].y += 0.05f;
					date.izm[k+1,p+1].y -= 0.05f;
					e=1;
					}
				}

			}
		}
		
}
void we (){
	int k;
	int p;
	if(b){p=0;}else{p=1;}
		for(k=p;k<141;k+=2){
			if(date.izm[k,0].y>=0.05f){
				if((date.izm[k,0].x+date.izm[k,0].y) - (date.izm[k,1].x+date.izm[k,1].y)>0.1f){
				date.izm[k,0].y -= 0.05f;
				date.izm[k,1].y += 0.05f;/*
					if(date.izm[k,0].y>0.5f){
					date.izm[k,0].y -= 0.1f;
					date.izm[k,1].y += 0.1f;
					}
				}*/
				e=1;			
				}
			}

			if(date.izm[k,140].y>=0.05f){
				if((date.izm[k,140].x+date.izm[k,140].y) - (date.izm[k,139].x+date.izm[k,139].y)>0.1f){
				date.izm[k,140].y -= 0.05f;
				date.izm[k,139].y += 0.05f;/*
					if(date.izm[k,140].y>0.5f){
					date.izm[k,140].y -= 0.1f;
					date.izm[k,139].y += 0.1f;
					}*/
				e=1;
				}
			}

			if(date.izm[0,k].y>=0.05f){
				if((date.izm[0,k].x+date.izm[0,k].y) - (date.izm[1,k].x+date.izm[1,k].y)>0.1f){
				date.izm[0,k].y -= 0.05f;
				date.izm[1,k].y += 0.05f;/*
					if(date.izm[0,k].y>0.5f){
					date.izm[0,k].y -= 0.1f;
					date.izm[1,k].y += 0.1f;
					}*/
					e=1;
				}
			}


			if(date.izm[140,k].y>=0.05f){
				if((date.izm[140,k].x+date.izm[140,k].y)-(date.izm[139,k].x+date.izm[139,k].y)>0.1f){
				date.izm[140,k].y -= 0.05f;
				date.izm[139,k].y += 0.05f;/*
					if(date.izm[140,k].y>0.5f){
					date.izm[140,k].y -= 0.1f;
					date.izm[139,k].y += 0.1f;
					}*/
					e=1;
				}
			}

	}
}



void  maker (){
float s = 2f;
int f=0;


for(t=0;t<141;t++){
	for(j=0;j<141;j++){
 	vc[f] =new Vector3(j*s,25,t*s);
	//vec[f] = transform.InverseTransformPoint(vec[f]);
	f++;
	}
}

ms = GetComponent<MeshFilter>().mesh;
ms.Clear();
ms.vertices = vc;
//c = true;
//ms.triangles = t;
//mc.sharedMesh = ms;
}


}