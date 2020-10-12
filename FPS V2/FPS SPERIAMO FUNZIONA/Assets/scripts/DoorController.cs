using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour{
    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
     if(doorIsOpening==true)
        {
            Door.transform.Translate(Vector3.down * Time.deltaTime * 250);
        }
        if (Door.transform.position.y > -2.5)
        {
            doorIsOpening = false;
        }
    }
    void OnMouseDown()
    {
        doorIsOpening = true;
    }
}
