using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{



	public CharacterController controller;
	public float speed = 100f;
	public string gunType;
	
	public GameObject bullet;
	public Transform bulletpos;
	
	public Joystick joystick;
	
	
	public float gravity = -9.81f;
	public float jumpHeight = 4f;
	
	
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
		isGrounded = Physics.CheckSphere(GroundCheck.position,groundDistance,groundMask );
		
		if(isGrounded && velocity.y <= 0){
			
			velocity.y = -2f;
			
			
		}
		
		
		//salto && isGrounded
	
		
		
		
		
		
        float x = joystick.Horizontal;
		float z = joystick.Vertical;
		
		
		
		
		Vector3 move = transform.right*x + transform.forward * z;
		
		controller.Move(move*speed*Time.deltaTime);
		
		velocity.y += gravity* Time.deltaTime;
		
		controller.Move(velocity * Time.deltaTime);
		
		
		
    }
}
