using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonblullet : MonoBehaviour
{
    // Start is called before the first frame update
  void OnCollisionEnter (Collision target)
	   {
        while(true){
			
			if( target.gameObject.tag == ("ground") ){
		    Destroy(gameObject);
		   
          
         }
			
			
			
		}
         
	  	
		  
		
	  
		   
		   
          
      }
}
