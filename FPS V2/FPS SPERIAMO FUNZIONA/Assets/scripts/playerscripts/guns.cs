using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guns : MonoBehaviour
{
    // Start is called before the first frame update



   class Gun{
   	
	int power;
	int range;
	int bulletType;
	GameObject bullet;
	Transform bulletpos;
	
	
	void Shoot(){
		
		
		
		
		Instantiate(bullet,bulletpos.position, bulletpos.rotation);
		
		
		
		
		
		
	} 
	
	
	
	
	
	
	
	
	
   }


}
