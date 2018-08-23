using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Move : MonoBehaviour {

    public KeyCode getOutKey = KeyCode.G;

    public float moveSpeed = 7f;
    public float turnSpeed = 5f;

    private Car_Controller car_Controller;

    private void Start()
    {
        car_Controller = GetComponent<Car_Controller>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotY = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;

        if (vertical > 0f)
        {
            transform.Rotate(new Vector3(0f, rotY, 0f));
        }

        transform.Translate(0f, 0f, vertical);

        //------------------------------Hot Keys--------------------------------
        if (Input.GetKeyDown(getOutKey))
        {
            car_Controller.Get_Out_Car();
        }

    }

}
