using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    public Car car;

    private void Awake()
    {
        if(car == null)
            car = GetComponent<Car>();
        Debug.Assert(car);
    }

    private void Update()
    {
        float steer = Input.GetAxisRaw("Horizontal");
        float acceleration = Input.GetAxisRaw("Vertical");

        car.Accelerate(acceleration);
        car.Steer(steer);

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            car.Reset();
        }
    }
}