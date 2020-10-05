using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class button : MonoBehaviour
{
   public void OnButtonPress(){
     SceneManager.LoadScene("map3");
   }
   
   public void Bruh(){
   	GetComponent<AudioSource>().Play();
	
   }
   
      public void OnButtonPress2(){
     SceneManager.LoadScene("MAP");
   }
   
     public void OnButtonPress3(){
     SceneManager.LoadScene("menu");
   }

}
