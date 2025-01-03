using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_51 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(26, ThirdWhiteCar));

            WhiteMovingPointTarget.Speed = 26;
            WhiteMovingPointTarget.MaxSpeed = 31;
        }
    }
}
