using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontro : MonoBehaviour
{



    public float moveSpeed;
    public float jumpHeight;
    private KeyCode lastHitKey;
	public float gravity = 9.81f;
	public bool box = false;

    void Start()
    {
    }

    void Update()
	
	
	
    {

	
        
	
        if(Input.GetKey (KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0,jumpHeight, 0) * Time.deltaTime;
        }
		  if(Input.GetKey (KeyCode.S))
        {
            transform.position = transform.position - new Vector3(0,jumpHeight, 0) * Time.deltaTime;
        }


        if(Input.GetKey (KeyCode.D))
        {
            if(lastHitKey == KeyCode.D)
            {

            }else
            {
                 transform.position = transform.position + new Vector3(moveSpeed,0, 0) * Time.deltaTime;
            }
        }


        if(Input.GetKey (KeyCode.A))
        {
            if(lastHitKey == KeyCode.A)
            {

            }else
            {
               transform.position =  transform.position - new Vector3(moveSpeed,0, 0) * Time.deltaTime;
            }
        }
		if(Input.GetKey (KeyCode.F)){
			
			GetComponent<AudioSource>().Play();
			
			
			
		}
    }
	
	
	
	 void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            box = true;
        }
    }
}
