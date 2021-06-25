using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scndcam : MonoBehaviour {

bool s;

public void ss(){
	s=true;
}

public void OnPostRender(){
	if(s){
		int i = 256;//(int)(Screen.width);
		int j = 256;//(int)(Screen.height);
		float x = (i/70f);
		float y = (j/70f);
		Texture2D tr = new Texture2D(256,256,TextureFormat.RGB24,false);
		tr.ReadPixels(new Rect(0,0, 256 ,256),0,0,true);
//		tr.Apply();
		Texture2D te = new Texture2D(70,70,TextureFormat.RGB24,false);
		for(i=0;i<70;i++){
			for(j=0;j<70;j++){
				
				te.SetPixel(i,j,tr.GetPixel((int)(i*x),(int)(j*y)));

			}
		}
		te.Apply(true,true);
		date.rw= te;
		s=false;
	}

}
}
