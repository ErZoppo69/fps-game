using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guns : MonoBehaviour
{
    // Start is called before the first frame update


	
public GameObject bullet;
public Transform bulletpos;
public int isPhone = 1;
float timer = 0.0f;


	

void Update(){
	
	timer += Time.deltaTime;
	
    if(Input.GetKey(KeyCode.Mouse0)&& isPhone== 1)
    {
			if(timer > 0.5f){
				
			Instantiate(bullet,bulletpos.position, bulletpos.rotation);
			GetComponent<AudioSource>().Play();
			timer = 0;
				
			}
		     
			 

		}
		
    }
}	
	



	

		
		
		
		
		
		
		
		
		
	
	
	
	
	
	
	
	
	



