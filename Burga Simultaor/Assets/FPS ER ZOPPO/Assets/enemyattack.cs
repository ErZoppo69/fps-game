using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{

public int davide = 1;
public GameObject bullet;
public Transform bulletpos;


	void Start(){
		StartCoroutine(ExampleCoroutine());
		
		
	}
	

  
    // Start is called before the first frame update


    // Update is called once per frame
	 IEnumerator ExampleCoroutine()
    {
		while(true){
			
			Instantiate(bullet,bulletpos.position, bulletpos.rotation);
			 yield return new WaitForSeconds(0.5f);
		
			
			
		}
     	
 }
}
