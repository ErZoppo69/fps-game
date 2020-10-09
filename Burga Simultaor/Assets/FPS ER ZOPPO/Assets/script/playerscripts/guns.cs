using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update



   class Gun{
   	
	int power, range, bulletType
	GameObject bullet;
	Transform bulletpos;
	
	void Shoot(){
		
		
		
		
		Instantiate(bullet,bulletpos.position, bulletpos.rotation);
		GetComponent<AudioSource>().Play();
		
		
		
		
		
	} 
	
	
	
	
	
	
	
	
	
   }


}
