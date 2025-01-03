using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_54 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(30, ThirdWhiteCar));

            WhiteMovingPointTarget.Speed = 30;
            WhiteMovingPointTarget.MaxSpeed = 35;
        }
    }
}
