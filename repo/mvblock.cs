using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvblock : MonoBehaviour
{
Vector3[] mv = new Vector3[1];
Vector3[] rt = new Vector3[1];
int ct=0;
Vector3 size;
public Rigidbody rb;
public Collider co;
int tm=0;
Quaternion qu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tm<=ct){
            if(mv[tm]!=null && rt[tm]!=null)
        	rb.MovePosition(mv[tm]);
        	rb.MoveRotation(Quaternion.Euler(rt[tm].x,rt[tm].y,rt[tm].z));
        }else{
        	tm=0;
        }
    }
    public void vrin(int i,Vector3[] m,Vector3[] r){
    	ct=i;
    	m.CopyTo(mv,0);
		r.CopyTo(rt,0);
    }
}
