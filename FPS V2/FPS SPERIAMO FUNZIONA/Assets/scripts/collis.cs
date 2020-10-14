using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collis : MonoBehaviour
{





	  void OnCollisionEnter(Collision collision)
    {
       Destroy(gameObject);
    }








}
