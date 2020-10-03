using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison : MonoBehaviour
{
 	  void OnCollisionEnter (Collision target)
	   {
         if( target.gameObject.tag == ("enemy") ){
		   
		   GetComponent<AudioSource>().Play();
		   
          
      }
 	}
}
