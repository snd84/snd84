using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scsho : MonoBehaviour {

bool s;
public int xs=512;
public int ys=512;


public void ss(){
	s=true;
}

public void OnPostRender(){
	if(s){
		int i = xs;
		int j = ys;
		int x = (int)(i/50);
		int y = (int)(j/50);
		Texture2D tr = new Texture2D(i,j,TextureFormat.RGB24,false);
		tr.ReadPixels(new Rect(0,0, i ,j),0,0,false);
//		tr.Apply();
		Texture2D te = new Texture2D(50,50,TextureFormat.RGB24,false);
		for(i=0;i<50;i++){
			for(j=0;j<50;j++){
				
				te.SetPixel(i,j,tr.GetPixel(i*x,j*y));

			}
		}
		te.Apply(true,true);
		date.rw= te;
		s=false;
	}

}
}
