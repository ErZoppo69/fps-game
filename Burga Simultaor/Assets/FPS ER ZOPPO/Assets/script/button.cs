using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class button : MonoBehaviour
{
   public void OnButtonPress(){
     SceneManager.LoadScene("mappa");
   }
   
   public void Bruh(){
   	GetComponent<AudioSource>().Play();
	
   }

}
