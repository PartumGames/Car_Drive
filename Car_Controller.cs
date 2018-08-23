using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car_Controller : MonoBehaviour {

    public GameObject cam;
    public Transform seat;
    public Transform getOutPos;
    private GameObject player = null;
    private Car_Move car_Move;


    private void Start()
    {
        car_Move = GetComponent<Car_Move>();
        car_Move.enabled = false;
    }

    public void Get_IN_Car(GameObject _plr)
    {
        player = _plr;
        player.transform.position = seat.position;
        player.transform.SetParent(seat);
        player.SetActive(false);
        car_Move.enabled = true;
        cam.SetActive(true);
    }

    public void Get_Out_Car()
    {
        player.transform.parent = null;
        player.transform.position = getOutPos.position;
        player.SetActive(true);
        car_Move.enabled = false;
        cam.SetActive(false);
    }

}
