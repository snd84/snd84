using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mcrc : MonoBehaviour
{
public Text mt;
public Text tmt;
public Text[] atx = new Text[50];

public RectTransform cch;
public RawImage ri;
public RawImage rb;
public Image rr;

public AudioSource a;
public RectTransform fw;
public Image son;
public Sprite[] sp;
public GameObject[] pla = new GameObject[2];

public AudioSource[] ae = new AudioSource[50];

int tm = 5;
int ch =0;
float tmr=0;
float cg = 1;
float ecs = 10;
float ecv = 0.5f;
float ppc = 1;
float tmc = 1;
float srt = 0.2f;
public RectTransform ectc;
public RectTransform pitc;
public RectTransform tmtc;
bool rec = false;
int ix;
int mx;
int bf;
int be;
int bm;
Texture2D tb;
Color cb = new Color(0,0,0.5f,0.5f);

    // Start is called before the first frame update
    void Start()
    {
        Color[] c = new Color[700];
        tb = new Texture2D(700,1);
        for(int i=0;i<700;i++){
            c[i] = Color.clear;
        }
        tb.SetPixels(c);
        tb.Apply();
        rb.texture = tb;
    }

    // Update is called once per frame
    void Update()
    {
        if(!rec){
            rr.color = new Color(0.7f,0.7f,0.5f,0.3f);
            if(Microphone.devices.Length>0){
                son.sprite = sp[0];
                foreach(string s in Microphone.devices){
                mt.text = (""+s);
                }
                }else{
                son.sprite = sp[2];
                mt.text = ("");
                }
        }else{
            rr.color = new Color(0,0.5f,0.5f,0.2f);
            float f = tm - (Time.realtimeSinceStartup - tmr);
            f = (Mathf.Round(f*100))*0.01f;
            atx[ch].text =  (""+f);
            son.sprite = sp[1];
            if(f<=0){rec=false;atx[ch].text=(tm+"s");
            atx[51].text = ("●");atx[51].color = Color.red;}
            otpr();
        }
        if(a.isPlaying){
            pla[1].SetActive(true);
            pla[0].SetActive(false);
        }else{
            pla[0].SetActive(true);
            pla[1].SetActive(false);
        }

        
    }

    public void sett(){
    for(int i=0;i<50;i++){
        if(date.ac[i]!=null){
            atx[i].text = ((int)(date.ac[i].samples/44.1f)+"ms");
        }
    }   
    }

    public void tms(float f){
        tm = (int)f;
        tmt.text = (""+tm);
    }

    public void ply(){
        if(!rec && !a.isPlaying){
        a.clip = date.ac[ch];
        a.Play();
        }else if(a.isPlaying){
        a.Stop();   
        }
    }

    public void chs(int n){
        if(!rec){
        cch.localPosition = Vector2.zero;
        ch = n;
        if(date.ac[ch]!=null){
            otpr();
        }else{
            ri.texture = null;
        }
        }
    }

    public void recs(){
        if(!a.isPlaying && !rec && !Microphone.IsRecording(null) && ch !=50){
        date.ac[ch] = Microphone.Start(null, false, tm, 44100);
        tmr = Time.realtimeSinceStartup;
        atx[51].text = ("■");
        atx[51].color = Color.black;
        rec=true;
        return;
        }
        if(rec){
        atx[51].text = ("●");
        atx[51].color = Color.red;
        stop();

        }
    }

    public void rcat(){
        if(date.ac[ch]!=null && ch!=50){
            if(bm>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);
            float[] f = new float[date.ac[ch].samples];
            float[] ft = new float[date.ac[ch].samples-(mm-mn)];
            date.ac[ch].GetData(f,0);
            date.ac[ch] = AudioClip.Create("0",ft.Length,1,44100,false);
            int k=0;
            for(int i=0;i<mn;i++){
                ft[k] = f[i];
                k++;
            }
            for(int i=mm;i<f.Length-1;i++){
                ft[k] = f[i];
                k++;
            }
            date.ac[ch].SetData(ft,0);
            }else{
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            int i=date.ac[ch].samples-1;
            for(;i>0;i--){
                if(f[i]>0.001f||f[i]<-0.001f){break;}
            }
            date.ac[ch] = AudioClip.Create("0",i+1,1,44100,false);
            float[] ft = new float[i];
            for(int k=0;k<i;k++){
                ft[k] = f[k];
            }
            date.ac[ch].SetData(ft,0);
            }
            atx[ch].text = ((int)(date.ac[ch].samples/44.1f)+"ms");
            otpr();
        }
    }

    public void cut(){
        if(date.ac[ch]!=null && bm>0 && ch!=50){
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            int sf = (int)(f.Length/700f);
            float[] cp = new float[sf*bm];
            int k=0;
            for(int i=bf*sf;i<be*sf;i++){
            cp[k] = f[i];
            f[i] = 0;
            k++;
            }
            date.ac[ch].SetData(f,0);
            date.ac[50] = AudioClip.Create("0",cp.Length,1,44100,false);
            date.ac[50].SetData(cp,0);
            atx[50].text = ((int)(cp.Length/44.1f)+"ms");
        otpr();
        }
    }

    public void cpt(){
        if(date.ac[ch]!=null && bm>0 && ch!=50){
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            int sf = (int)(f.Length/700f);
            float[] cp = new float[sf*bm];
            int k=0;
            for(int i=bf*sf;i<be*sf;i++){
            cp[k] = f[i];
            k++;
            }
            date.ac[ch].SetData(f,0);
            date.ac[50] = AudioClip.Create("0",cp.Length,1,44100,false);
            date.ac[50].SetData(cp,0);
            atx[50].text = ((int)(cp.Length/44.1f)+"ms");
        otpr();
        }
    }

    public void pest(){
        if(date.ac[ch]!=null && ch != 50){
            if(date.ac[50].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            float[] cp = new float[date.ac[50].samples];
            date.ac[50].GetData(cp,0);
            int p=0;
            for(int i=mn;i<f.Length;i++){
                if(cp.Length>p){
                    f[i] = cp[p];
                p++;
                }else{break;}
            }
            date.ac[ch].SetData(f,0);
            }else{
                date.ac[ch] = AudioClip.Create(""+ch,date.ac[50].samples,1,44100,false);
                float[] f = new float[date.ac[50].samples];
                date.ac[50].GetData(f,0);
                date.ac[ch].SetData(f,0);
                atx[ch].text = ((int)(date.ac[ch].samples/44.1f)+"ms");
            }
            otpr();
        }
    }
    public void ppest(){
        if(date.ac[ch]!=null && date.ac[50].samples>0 && ch != 50){
            if(date.ac[50].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            float[] cp = new float[date.ac[50].samples];
            date.ac[50].GetData(cp,0);
            int p=0;
            for(int i=mn;i<f.Length;i++){
                if(cp.Length>p){
                    f[i] += cp[p];
                    if(f[i]>1f){f[i]=1;}
                    if(f[i]<-1f){f[i]=-1;}
                p++;
                }else{break;}
            }
            date.ac[ch].SetData(f,0);
            }else{
                date.ac[ch] = AudioClip.Create(""+ch,date.ac[50].samples,1,44100,false);
                float[] f = new float[date.ac[50].samples];
                date.ac[50].GetData(f,0);
                date.ac[ch].SetData(f,0);
                atx[ch].text = ((int)(date.ac[ch].samples/44.1f)+"ms");
            }
            otpr();
        }
    }
    public void vel(float f){
        atx[53].text = ("×"+(f*0.1f));
        cg = f*0.1f;
    }

    public void velc(){
        if(bm>0 && ch != 50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);

            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            for(int i=mn;i<mm;i++){
                    f[i] = f[i] * cg;
                    if(f[i]>1){f[i] = 1;}
                    if(f[i]<-1){f[i] = -1;}
            }
            date.ac[ch].SetData(f,0);
            }
            otpr();
        }
    }
    public void ecsc(float f){
        ecs = f;
        ectc.localPosition = new Vector3(f*0.8f,0,0);
    }
    public void ecvc(float f){
        ecv = f;
        ectc.sizeDelta = new Vector2(50,10 +(30 * f));
    }

    public void ecoo(){
        if(bm>0 && ch != 50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);

            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            int r = (int)(ecs * 1000);
            for(int i=mn;i<mm;i++){
                if(f.Length>i+r){
                f[i + r] += f[i]*ecv;
                if(f[i+r]>1){f[i+r] = 1;}
                if(f[i+r]<-1){f[i+r] = -1;}
                }else{
                break;
                }
            }
            date.ac[ch].SetData(f,0);
            }
            otpr();
        }
    }

    public void tmcs(float f){
        tmc = f;
        tmtc.anchoredPosition = new Vector2(0,f);
        atx[55].text = (""+tmc);
    }
    public void tmch(){
        if(bm>0 && ch !=50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);

            float[] f = new float[date.ac[ch].samples];
            float[] nc = new float[date.ac[ch].samples];
            int c=mn+1;
            date.ac[ch].GetData(f,0);
            for(int i=mn+1;i<mm;i++){
                nc[c] = Mathf.Round(f[i] * 100)/100f;
                c++;
            }
            date.ac[ch].SetData(nc,0);
            }
            otpr();
        }
    }
    public void ppcc(float f){
        ppc = (Mathf.Round(f*100))/100;
        pitc.sizeDelta = new Vector2(40*f,40);
        atx[54].text = ("×"+f);
    }
    public void pich(){
        if(bm>0 && ch !=50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);

            float[] f = new float[date.ac[ch].samples];
            float[] nc = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            for(int i=mn+1;i<mm;i++){
                if(nc.Length>i*ppc){
                nc[(int)(i * ppc)] = f[i];
                f[i] = 0;
                }
            }

            for(int i=1;i <date.ac[ch].samples-1;i++){
                if(nc[i]==0){
                    nc[i] = (nc[i-1] + nc[i+1])/2f;
                }
            }
            for(int i=0;i <date.ac[ch].samples;i++){
                f[i] += nc[i];
                if(f[i]>1){f[i] = 1;}
                if(f[i]<-1){f[i] = -1;}
            }

            date.ac[ch].SetData(f,0);
            }
            otpr();
        }
    }

        public void rstc(float f){
            f = f-0.8f;
            srt = Mathf.Round(f*100)/100f;
            if(srt==0){srt=0.01f;}
            atx[55].text = (""+srt);
        }
        public void tmst(){
        if(bm>0 && ch !=50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);
            float[] f = new float[date.ac[ch].samples];
            float[] m = new float[date.ac[ch].samples];//[(mm-mn)*(1f+(srt/100f))];
            date.ac[ch].GetData(f,0);
            for(int t=0;t<mn-1;t++){
                m[t] = f[t];
            }
            for(int t=mm;t<f.Length;t++){
                m[t] = f[t];
            }
            int b=mn;
            int j=0;
            int c=0;
            int s =  (mm-mn)/21;
            if(s<1000){s=1000;}
            if(s>4410){s=4410;}

            /*
            if(srt>0){
            for(int t=mn;t<mm-1;t++){
                if(b>m.Length-1){break;}  
                m[b] += f[t];     
                b++;
                j++;

                if(j > s){
                if(b+c>m.Length-1){break;}
                float r = (1f/200f);
                float u = 0;
                    b-=200;
                    for(int l=(c/-2);l <(c/2)-200;l++){
                        if(l<0){
                        if(u<=1){
                        m[b] += f[t+l];// * u;
                        u += r;
                        b++;
                        }
                        m[b] += f[t+l];
                        b++;
                        }

                    }
                    for(int l=(c/2)-200;l<c/2;l++){
                        m[b] += f[t+l];// * u;
                        u -= r;
                        b++;
                    }
                    b-=200;
                    j=0;
                }

            }
            }else if(srt<0){
                */
            c = (int)(s * -srt);
            
            for(int t=mn;t<mm;t++){ 
                if(b>m.Length-1){break;}
                if(j<100){m[b] += f[t] * (j * 0.01f);}else{
                    m[b] += f[t];
                }
                b++;
                j++;
                if(j > s){
                    if(c>0){t += (c/2);}else{
                    t += c-100;
                    }
                    j=0;
                    for(int l=-100;l<0;l++){
                        m[b+l] = m[b+l] * (l * -0.01f);
                    }
                }

            //}

            }
            
            for(int t=2;t<m.Length-2;t++){
                f[t] = (m[t-2]+m[t-1]+m[t]+m[t+1]+m[t+2])/5f;
            }
            for(int t=2;t<m.Length-2;t++){
                m[t] = ((m[t]+f[t])/2f);
            }
            date.ac[ch].SetData(m,0);
            }
            otpr();
        }
    }
    public void fedd(){
        if(bm>0 && ch !=50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);
            float sf = 1f;
            float s = (1f / bm);
            int k = (mm - mn) / bm;
            int h = 0;
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            for(int i=mn;i<mm;i++){
                if(f.Length>mm){
                if(h>k){h=0;sf -= s;if(sf<=0.05f){sf=0.05f;}}
                    h++;
                    f[i] = f[i]*sf;
                    if(f[i]>1){f[i] = 1;}
                    if(f[i]<-1){f[i] = -1;}
                }else{
                break;
                }
            }
            date.ac[ch].SetData(f,0);
            }
            otpr();
        }
    }

    public void fedu(){
        if(bm>0 && ch !=50){
            if(date.ac[ch]!=null && date.ac[ch].samples>0){
            int mn = bf * (date.ac[ch].samples/700);
            int mm = be * (date.ac[ch].samples/700);
            float sf = 0.8f;
            float s = (1f / bm);
            int k = (mm - mn) / bm;
            int h = 0;
            float[] f = new float[date.ac[ch].samples];
            date.ac[ch].GetData(f,0);
            for(int i=mn;i<mm;i++){
                if(f.Length>mm){
                if(h>k){h=0;sf += s;}
                    h++;
                    f[i] = f[i]*sf;
                    if(f[i]>1){f[i] = 1;}
                    if(f[i]<-1){f[i] = -1;}
                }else{
                break;
                }
            }
            date.ac[ch].SetData(f,0);
            }
            otpr();
        }
    }

    public void stop(){
    if(rec){
    Microphone.End(null);
    atx[ch].text=(tm+"s");
    rec=false;
    otpr();
    }
    }

    public void del(){
    if(!rec && !a.isPlaying && date.ac[ch]!=null){
    date.ac[ch] = null;
    atx[ch].text = null;
    ri.texture = null;
    }
    }

    public void otpr(){
    Color[] c = new Color[700*150];
    float[] f = new float[date.ac[ch].samples];
    date.ac[ch].GetData(f,0);
    int sf = (int)(f.Length/700f);
    int ct = 0;
    for(int i = 0; i < 700;i++){
        for(int n=0;n<sf;n++){
            //c[(i+(125*700))+(int)((Mathf.Sin(n)*50f)*700)] = Color.black;
            c[(i+(75*700))+((int)(f[ct]*74f)*700)] = Color.black;
            ct++;
        }
    }
    Texture2D tx = new Texture2D(700,150);
    tx.SetPixels(c); 
    tx.Apply();
    ri.texture = tx;

    }

    public void inbl(){
        Color[] c = new Color[700];
        if(mx>ix){          
            for(int i=ix;i<mx;i++){
                c[i] = cb;
            }
            bf = ix;
            be = mx;
            bm = be-bf;
        }
        if(mx<ix){
            for(int i=ix;i>mx;i--){
                c[i] = cb;
            }
            bf = mx;
            be = ix;
            bm = be-bf;
        }
        tb.SetPixels(c);
        tb.Apply();
    }

    public void inm(){
        if(Input.GetMouseButton(0)){
        Color[] c = new Color[700];
        for(int i=0;i<700;i++){
            c[i] = Color.clear;
        }
        tb.SetPixels(c);
        tb.Apply();
        bf = 0;
        be = 0;
        bm = 0;
        }

        Vector3[] v = new Vector3[4];
        fw.GetWorldCorners(v);
        ix = (int)((Input.mousePosition.x-v[0].x)*(1280f/Screen.width));

    }
    public void ino(){
        Vector3[] v = new Vector3[4];
        fw.GetWorldCorners(v);
        mx = (int)((Input.mousePosition.x-v[0].x)*(1280f/Screen.width));
        if(mx<0){mx=0;}
        if(mx>700){mx=700;}
        if(Input.GetMouseButton(0)){
        inbl();
        }

    }
}

