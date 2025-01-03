using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint_23 : BaseChangeSpeedCoroutine
{
    [SerializeField] protected Moving RedCar;
    [SerializeField] protected CarBlack BlackCar;
    [SerializeField] protected CarBlue BlueCar;
    [SerializeField] protected MovingPointTarget MovingPointTarget;

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(0, RedCar));
            StartCoroutine(ChangeSpeed(20, BlackCar));
        }
    }
}
