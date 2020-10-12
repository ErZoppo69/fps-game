using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour
{

public int life = 30;


    // Start is called before the first frame update
void OnCollisionEnter (Collision target)
	   {
         if( target.gameObject.tag == ("enemy") ){
		   
		  life -=  5;
		   
          
      }
 	}
	
	void Update(){
		
	if(life <=  0){
		
		SceneManager.LoadScene("death");
		
	}
		
		
	}

}
