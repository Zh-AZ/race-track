using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_48 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(35, ThirdWhiteCar));

            WhiteMovingPointTarget.Speed = 35;
            WhiteMovingPointTarget.MaxSpeed = 40;
        }
    }
}
