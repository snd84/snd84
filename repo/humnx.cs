using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class humnx : MonoBehaviour {

public Slider[] sl = new Slider[12];
public Slider[] sfd = new Slider[6];
public RectTransform flc;
public Toggle tgl;
public RectTransform[] sfp = new RectTransform[3];
public Text[] tx = new Text[16];
public Image[] imn1 = new Image[7];
public Image[] imn2 = new Image[7];
public Image[] imn3 = new Image[7];
public Image[] imn4 = new Image[7];
public Image[] imn5 = new Image[7];
public Image[] imn6 = new Image[7];
public Image[] im = new Image[11];
public Sprite[] igm = new Sprite[3];
public RectTransform[] gl = new RectTransform[4];

float[,] fgt = new float[7,6];
int[] prm = new int[100];
public Image[] tji = new Image[24];

//float[] ft = new float[9];

int fc = 0;
int i;
int gc;

	// Use this for initialization
public void init(){
	Start();
	}
	void Start () {
		prm[0]=200;prm[1]=500;prm[2]=200;prm[3]=500;prm[4]=200;prm[5]=500;
		prm[19] = 0;prm[20] = 2;prm[21] = 2;prm[22] = 2;
		prm[23] = 1;prm[24] = 1;prm[25] = 1;
		prm[26] = 0;prm[27] = 0;prm[28] = 0;

		prm[29] = 100;prm[30] = 0;prm[31] = 100;
		prm[32] = 0;prm[33] = 100;prm[34] = 0;

		prm[35] = 0;prm[36] = 0;prm[37] = 0;
		prm[38] = 0;prm[39] = 0;prm[40] = 0;

		prm[41] = 20;prm[42] = 10;prm[43] = 80;
		prm[44] = 25;prm[45] = 55;
		prm[46] = 20;prm[47] = 0;prm[48] = 0;
		prm[49] = 0;prm[50] = 0;prm[51] = 0;

		for(int i=0;i<24;i++){
			prm[50+i]=0;
			tji[i].color = new Color(0.5f,0.55f,1f,0.55f);
			}
		for(int i=0;i<7;i++){
		fgt[i,0] = 0;fgt[i,1] = 0;fgt[i,2] = 0;
		fgt[i,3] = 1;fgt[i,4] = 1;fgt[i,5] = 1;		
		}

		sl[0].value = prm[0];sl[1].value = prm[1];
		sl[2].maxValue = prm[1];sl[3].maxValue = prm[1];
		sl[2].value = prm[29];sl[3].value = prm[30];

		sl[4].value = prm[2];sl[5].value = prm[3];
		sl[4].maxValue = prm[3];sl[5].maxValue = prm[3];
		sl[6].value = prm[31];sl[7].value = prm[32];

		sl[8].value = prm[4];sl[9].value = prm[5];
		sl[8].maxValue = prm[5];sl[9].maxValue = prm[5];
		sl[10].value = prm[33];sl[11].value = prm[34];
		
		sl[10].value = prm[33];sl[11].value = prm[34];


		gl[4].SetParent(gl[5]);
		gl[4].localPosition = Vector3.zero;
		cosf(0);
		snts();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void spre(){
		for(i=0;i<10;i++){
			if(date.rb[i]!=null){
				im[i].sprite = date.rbsp[i];
			}
		}
	}

	public void apsd(float f){
		prm[0] = (int)f;
		if(sl[0].value>sl[1].value){
			sl[0].value = sl[1].value;
			prm[0] = (int)sl[0].value;
		}
		tx[9].text = (sl[0].value+"/"+sl[1].value);

	}
	public void ampsd(float f){
		prm[1] = (int)f;
		if(sl[0].value>sl[1].value){
			sl[1].value = sl[0].value;
			prm[1] = (int)sl[1].value;
		}
		sl[2].maxValue = sl[1].value;
		sl[3].maxValue = sl[1].value;

		tx[9].text = (sl[0].value+"/"+sl[1].value);
		tx[10].text = (sl[2].value+"/"+sl[1].value);
		tx[11].text = (sl[3].value+"/"+sl[1].value);
	}
	public void bpsd(float f){
		prm[2] = (int)f;
		if(sl[4].value>sl[5].value){
			sl[5].value = sl[4].value;
			prm[4] = (int)sl[4].value;
		}
		tx[13].text = (sl[4].value+"/"+sl[5].value);
	}
	public void bmpsd(float f){
		prm[3] = (int)f;
		if(sl[4].value>sl[5].value){
			sl[5].value = sl[4].value;
			prm[3] = (int)sl[5].value;
		}
		sl[6].maxValue = sl[5].value;
		sl[7].maxValue = sl[5].value;

		tx[13].text = (sl[4].value+"/"+sl[5].value);
		tx[14].text = (sl[6].value+"/"+sl[5].value);
		tx[15].text = (sl[7].value+"/"+sl[5].value);
	}

	public void cpsd(float f){
		prm[4] = (int)f;
		if(sl[8].value>sl[9].value){
			sl[9].value = sl[8].value;
			prm[4] = (int)sl[8].value;
		}
		tx[16].text = (sl[8].value+"/"+sl[9].value);
	}
	public void cmpsd(float f){
		prm[5] = (int)f;
		if(sl[8].value>sl[9].value){
			sl[9].value = sl[8].value;
			prm[5] = (int)sl[9].value;
		}
		sl[10].maxValue = sl[9].value;
		sl[11].maxValue = sl[9].value;

		tx[16].text = (sl[8].value+"/"+sl[9].value);
		tx[17].text = (sl[10].value+"/"+sl[9].value);
		tx[18].text = (sl[11].value+"/"+sl[9].value);
	}


	public void glit(int n){
		prm[19+n]++;
		if(prm[19+n]>2){prm[19+n]=0;}
		im[n+10].sprite = igm[prm[19+n]];
	}
	public void glc(int n){
		prm[19] = n;
		gl[3].SetParent(gl[n]);
		gl[3].localPosition = Vector3.zero;
	}

	public void fg0f(float f){
		prm[29] = (int)f;
		tx[10].text = (prm[29]+"/"+sl[1].value);
	}
	public void fg1f(float f){
		prm[30] = (int)f;
		tx[11].text = (f+"/"+sl[1].value);
	}
	public void fg2f(float f){
		prm[31] = (int)f;
		tx[14].text = (f+"/"+sl[5].value);
	}
	public void fg3f(float f){
		prm[32] = (int)f;
		tx[15].text = (f+"/"+sl[5].value);
	}
	public void fg4f(float f){
		prm[33] = (int)f;
		tx[17].text = (f+"/"+sl[9].value);
	}
	public void fg5f(float f){
		prm[34] = (int)f;
		tx[18].text = (f+"/"+sl[9].value);
	}
	public void fg0n(int n){
		imn1[prm[35]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn1[n].color = new Color(1,1,1,1);
		prm[35] = n;
	}
	public void fg1n(int n){
		imn2[prm[36]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn2[n].color = new Color(1,1,1,1);
		prm[36] = n;
	}
	public void fg2n(int n){
		imn3[prm[37]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn3[n].color = new Color(1,1,1,1);
		prm[37] = n;
	}
	public void fg3n(int n){
		imn4[prm[38]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn4[n].color = new Color(1,1,1,1);
		prm[38] = n;
	}
	public void fg4n(int n){
		imn5[prm[39]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn5[n].color = new Color(1,1,1,1);
		prm[39] = n;
	}
	public void fg5n(int n){
		imn6[prm[40]].color = new Color(0.5f,0.5f,0.5f,1f);
		imn6[n].color = new Color(1,1,1,1);
		prm[40] = n;
	}
	public void snts(){
		sl[12].value = prm[41];
		tx[0].text = (""+prm[41]);
		sl[13].value = prm[42];
		tx[1].text = (""+prm[42]);
		sl[14].value = prm[43];
		tx[2].text = (""+prm[43]);
		sl[15].value = prm[44];
		tx[3].text = (""+prm[44]);
		sl[16].value = prm[45];
		tx[4].text = (""+prm[45]);
		sl[17].value = prm[46];
		tx[5].text = (""+prm[46]);
		sl[18].value = prm[47];
		tx[6].text = (""+prm[47]);
		sl[19].value = prm[48];
		tx[7].text = (""+prm[48]);
		sl[20].value = prm[49];
		tx[8].text = (""+prm[49]);
		im[11].sprite = igm[prm[20]];
		im[12].sprite = igm[prm[21]];
		im[13].sprite = igm[prm[22]];
		im[14].sprite = igm[prm[23]];
		im[15].sprite = igm[prm[24]];
		im[16].sprite = igm[prm[25]];
		im[17].sprite = igm[prm[26]];
		im[18].sprite = igm[prm[27]];
		im[19].sprite = igm[prm[28]];

		sl[0].value = prm[0];
		sl[1].value = prm[1];
		sl[4].value = prm[2];
		sl[5].value = prm[3];
		sl[8].value = prm[4];
		sl[9].value = prm[5];
		sl[2].maxValue = prm[1];
		sl[2].value = prm[29];
		sl[3].maxValue = prm[1];
		sl[3].value = prm[30];
		sl[6].maxValue = prm[3];
		sl[6].value = prm[31];
		sl[7].maxValue = prm[3];
		sl[7].value = prm[32];
		sl[10].maxValue = prm[5];
		sl[10].value = prm[33];
		sl[11].maxValue = prm[5];
		sl[11].value = prm[34];

		for(int i=0;i<7;i++){
		imn1[i].color = new Color(0.5f,0.5f,0.5f,1f);
		imn2[i].color = new Color(0.5f,0.5f,0.5f,1f);
		imn3[i].color = new Color(0.5f,0.5f,0.5f,1f);
		imn4[i].color = new Color(0.5f,0.5f,0.5f,1f);
		imn5[i].color = new Color(0.5f,0.5f,0.5f,1f);
		imn6[i].color = new Color(0.5f,0.5f,0.5f,1f);
		}
		imn1[prm[35]].color = new Color(1,1,1,1);
		imn2[prm[36]].color = new Color(1,1,1,1);
		imn3[prm[37]].color = new Color(1,1,1,1);
		imn4[prm[38]].color = new Color(1,1,1,1);
		imn5[prm[39]].color = new Color(1,1,1,1);
		imn6[prm[40]].color = new Color(1,1,1,1);	
		sl[12].value = prm[41];
		tx[0].text = (""+prm[41]);
		sl[13].value = prm[42];
		tx[1].text = (""+prm[42]);
		sl[14].value = prm[43];
		tx[2].text = (""+prm[43]);
		sl[15].value = prm[44];
		tx[3].text = (""+prm[44]);
		sl[16].value = prm[45];
		tx[4].text = (""+prm[45]);
		sl[17].value = prm[46];
		tx[5].text = (""+prm[46]);
		sl[18].value = prm[49];
		tx[6].text = (""+prm[49]);
		sl[19].value = prm[50];
		tx[7].text = (""+prm[50]);
		sl[20].value = prm[51];
		tx[8].text = (""+prm[51]);
		sl[21].value = prm[47];
		tx[24].text = (""+prm[47]);
		sl[22].value = prm[48];
		tx[25].text = (""+prm[48]);

	}
	public void ft0(float f){
		tx[0].text = (""+f);
		prm[41] = (int)f;
	}
	public void ft1(float f){
		tx[1].text = (""+f);
		prm[42] = (int)f;
	}
	public void ft2(float f){
		tx[2].text = (""+f);
		prm[43] = (int)f;
	}
	public void ft3(float f){
		tx[3].text = (""+f);
		prm[44] = (int)f;
	}
	public void ft4(float f){
		tx[4].text = (""+f);
		prm[45] = (int)f;
	}
	public void ft5(float f){
		tx[5].text = (""+f);
		prm[46] = (int)f;
	}
	public void ft6(float f){
		tx[24].text = (""+f);
		prm[47] = (int)f;
	}
	public void ft7(float f){
		tx[25].text = (""+f);
		prm[48] = (int)f;
	}
	public void ft8(float f){
		tx[6].text = ("-"+f);
		prm[49] = (int)f;
	}
	public void ft9(float f){
		tx[7].text = ("-"+f);
		prm[50] = (int)f;
	}
	public void ft10(float f){
		tx[12].text = ("-"+f);
		prm[51] = (int)f;
	}

	public void cosf(int n){
		fc = n;
		flc.transform.localPosition = Vector3.zero;
		sfd[0].value = fgt[fc,0];
		sfd[1].value = fgt[fc,1];
		sfd[2].value = fgt[fc,2];
		sfd[3].value = fgt[fc,3];
		sfd[4].value = fgt[fc,4];
		if(fgt[fc,5]==1){tgl.isOn =true;}else{tgl.isOn=false;}
		//if(fgt[fc,6]==1){tgl.isOn=true;}else{tgl.isOn=false;}
		//sfp[0].localScale = new Vector3(0.5f,0.5f,0.5f);
		//sfp[1].localScale = new Vector3(0.5f,0.5f,0.5f);
		//sfp[2].localScale = new Vector3(0.5f,0.5f,0.5f);
		//sfp[fs[fc]].localScale = Vector3.one;


	}



	public void fgt0(float f){
		fgt[fc,0] = f;
		tx[19].text = (""+f);
	}
	public void fgt1(float f){
		fgt[fc,1] = f;
		tx[20].text = (""+f);
	}
	public void fgt2(float f){
		fgt[fc,2] = f;
		tx[21].text = (""+f);
	}
	public void fgt3(float f){
		fgt[fc,3] = f;
		tx[22].text = (""+f);
	}
	public void fgt4(float f){
		fgt[fc,4] = f;
		tx[23].text = (""+f);
	}
	public void fgt5(bool b){
		if(b){fgt[fc,5] = 1;
			}else{fgt[fc,5] = 0;}
	}


	public void skjl(int n){
		if(Input.GetMouseButton(0)){
		prm[50+n]++;
		if(prm[50+n]>1){
			prm[50+n]=0;
		}
		switch(prm[50+n]){
			case 0:
			tji[n].color = new Color(0.5f,0.55f,1f,0.55f);
			break;
			case 1:
			//tji[n].color = new Color(1,0.5f,0.5f,0.55f);
			//break;
			//case 2:
			tji[n].color = new Color(1f,0.95f,0.5f,0.55f);
			break;
			}
		}
	}

}
