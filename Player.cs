using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Camera cam;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DoRay();
        }
    }


    private void DoRay()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 15f))
        {
            if(hit.collider.tag == "Car")
            {
                hit.collider.GetComponent<Car_Controller>().Get_IN_Car(this.gameObject);
            }
        }
    }

}
