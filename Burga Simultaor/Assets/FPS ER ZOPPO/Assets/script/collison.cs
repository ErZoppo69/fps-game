using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison : MonoBehaviour
{
public int life = 30;



 	  void OnCollisionEnter (Collision target)
	   {
         if( target.gameObject.tag == ("enemy") ){
		   life -= 5;
		   
		   
          
      }
 	}
	void Update(){
		if(life <= 0){
		
		//SceneManager.LoadScene("death");
		
	}
		
		
	}

}
