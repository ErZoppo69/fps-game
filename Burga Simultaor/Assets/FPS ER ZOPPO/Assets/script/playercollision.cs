using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour
{
    // Start is called before the first frame update
void OnCollisionEnter (Collision target)
	   {
         if( target.gameObject.tag == ("enemy") ){
		   
		   SceneManager.LoadScene("death");
          
      }
 	}
}
