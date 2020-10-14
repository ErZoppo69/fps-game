using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egirlai : MonoBehaviour
{



	public CharacterController egirl;
	public float speed = 10f;
	private GameObject Move;
	private Transform pos;
	public float shootSpeed = 300f;
	public float x = 0.01f;
	public float z = 0.01f;
	public Vector3 move;
	public float gravity = -9.81f;
	public Transform GroundCheck;
	public float groundDistance = 0.0f;
	public LayerMask groundMask;
	bool isGrounded;
	Vector3 velocity;
	public int gravitydivider = 40;
    // Start is called before the first frame update
	
	void Start(){
		Move = GameObject.FindWithTag("spawn");
		pos = Move.GetComponent<Transform>();
		 move = pos.forward;
		StartCoroutine(ExampleCoroutine());
		
	}
    // Update is called once per frame
    void Update()
    {
		isGrounded = Physics.CheckSphere(GroundCheck.position,groundDistance,groundMask );
		
		if(isGrounded && velocity.y <= 0){
			
			move.y = -2f;
			if(speed >0){
			
				speed = -2f;
				
				
				
				
			}
			if(speed == 0){
				
				Destroy(gameObject);
				
			}
			
			
		}
     	
	    
		egirl.Move(move* speed * 3 * Time.deltaTime);
		
		
		
		move.y +=  ((gravity/gravitydivider) * Time.deltaTime);
		
		
    }
		 IEnumerator ExampleCoroutine()
    {
		while(true){
			
			
			 yield return new WaitForSeconds(3);
			  Destroy(gameObject);
			
			
		}
	
	}
	
}
