using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{



	public int isPhone = 0;
	public CharacterController controller;
	public float speed = 100f;
	public string gunType;
	
	public GameObject bullet;
	public Transform bulletpos;
	
	public Joystick joystick;
	
	
	public float gravity = -9.81f;
	public float jumpHeight = 4f;
	float x;
	float z;
	
	public Transform GroundCheck;
	
	public float groundDistance = 0.0f;
	
	public LayerMask groundMask;
	
	bool isGrounded;
    // Start is called before the first frame update
	
	
	
public void shoot(){
			
			
			Instantiate(bullet,bulletpos.position, bulletpos.rotation);
			GetComponent<AudioSource>().Play();
			
			
}

public void jump(){
	
	if( isGrounded){
			
			
			velocity.y = Mathf.Sqrt(jumpHeight* -2f * gravity);
			
			
			
}
	
	
}
	
		

		
	Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
		//gravità
		
		
		
		
			if( isGrounded && Input.GetKey("space")&& isPhone== 1){
			
			
			velocity.y = Mathf.Sqrt(jumpHeight* -2f * gravity);
			
			
			
		}
		
		

			
			
			
		isGrounded = Physics.CheckSphere(GroundCheck.position,groundDistance,groundMask );
		
		if(isGrounded && velocity.y <= 0){
			
			velocity.y = -2f;
			
			
		}
		
		
		//salto && isGrounded
	
		
		
		
		
		if(isPhone==0){
			
		 x = joystick.Horizontal;
		 z = joystick.Vertical;
			
			
		}else{
			
			
			 x= Input.GetAxis("Horizontal");
			 z = Input.GetAxis("Vertical");
			
			
		}
     
		
		
		
		
		Vector3 move = transform.right*x + transform.forward * z;
		
		controller.Move(move*speed*Time.deltaTime);
		
		velocity.y += gravity* Time.deltaTime;
		
		controller.Move(velocity * Time.deltaTime);
		
		
		
    }
}
