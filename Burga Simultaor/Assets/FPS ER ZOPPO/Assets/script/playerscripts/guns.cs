using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guns : MonoBehaviour
{
    // Start is called before the first frame update


public GameObject bullet;
public Transform bulletpos;
public int isPhone = 0;
public int gunType;






	void Start(){
		
		StartCoroutine( ExampleCoroutine());
		
		
	}	
		
		
		
IEnumerator ExampleCoroutine(){
        //Print the time of when the function is first called.

        //yield on a new YieldInstruction that waits for 5 seconds.
		
		
		while(true){
			
		if( Input.GetKey(KeyCode.Mouse0) && isPhone== 1){
			
		Instantiate(bullet,bulletpos.position, bulletpos.rotation);
		GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
			
			
		  }
			
			
		}
	
		

        
    }
	
	

	      
	
	
	
	
	
	
	
	
	
}



