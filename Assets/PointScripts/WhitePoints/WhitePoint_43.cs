using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_43 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

            WhiteMovingPointTarget.Speed = 20;
            WhiteMovingPointTarget.MaxSpeed = 25;
        }
    }
}
