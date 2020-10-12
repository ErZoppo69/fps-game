using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemylook : MonoBehaviour
{
	private Transform target;
	public Transform target2;
	public int test = 1;
    // Start is called before the first frame update
    void Start()
    {
         target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		if(test==1){
			transform.LookAt(target.position);
			
		}
		else{
			transform.LookAt(target2);
		}
        
    }
}
