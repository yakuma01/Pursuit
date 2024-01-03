using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleVehicleMove : MonoBehaviour
{
    Vehicle vehicle;
    public Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        vehicle = GetComponent<Vehicle>();
        
     }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        vehicle.velocity = direction.normalized * vehicle.maxSpeed;
        vehicle.MoveVehicle();
    }
}
