using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyapi : MonoBehaviour
{



	
	 public int life = 20;
    // Start is called before the first frame update
	
	
	  void OnCollisionEnter (Collision target)
	   {
	   
         if( target.gameObject.tag == ("bullet") ){
		
		   life = life -2;
		   
		   
		   if(life<=0){
		   		Destroy(gameObject);
			
			
		   }
           
      }
 	}
	
    
}
