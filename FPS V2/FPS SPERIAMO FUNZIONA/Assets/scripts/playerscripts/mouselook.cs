using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{

	public float mouseSensitivity = 100f;
	
	public int isPhone = 0;
	float mouseX;
	float mouseY;
	public Joystick joystick;
	public Transform playerBody;
	public Transform gunBody;
	private bool touchStart = false;
	private Vector2 pointa;
	private Vector2 pointb;
	
	float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
	
	
		if(isPhone==0){
			
	     mouseX = joystick.Horizontal *mouseSensitivity * Time.deltaTime;
		 mouseY = joystick.Vertical * mouseSensitivity * Time.deltaTime;
			
			
		}else{
			
			mouseX = Input.GetAxis("Mouse X");
			mouseY = Input.GetAxis("Mouse Y");
			
			
			
		}
      
		
		
		xRotation -=  mouseY;
		xRotation = Mathf.Clamp(xRotation , -90f, 90f);
		
		
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		
		playerBody.Rotate(Vector3.up * mouseX);
		
		
		
    }
}
