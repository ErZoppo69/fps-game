using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class su : MonoBehaviour
{




    // Start is called before the first frame update
		
	public GameObject bullet;
	public Transform bulletpos;

    void Start()
    {
       StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
  
	
	
		
	
	 IEnumerator ExampleCoroutine()
    {
		while(true){
			
			Instantiate(bullet,bulletpos.position, bulletpos.rotation);
			 yield return new WaitForSeconds(10);
				
			
			
		}
 }
}