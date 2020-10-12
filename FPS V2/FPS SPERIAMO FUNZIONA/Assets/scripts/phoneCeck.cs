using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phoneCeck : MonoBehaviour
{
    // Start is called before the first frame update
   	public int IsPhone = 0;
   
    // Update is called once per frame
    void Update()
    {
        if(IsPhone==1){
			Destroy(gameObject);
			
			
		}
 }
}