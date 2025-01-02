using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_52 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(19, ThirdWhiteCar));

            WhiteMovingPointTarget.Speed = 20;
            WhiteMovingPointTarget.MaxSpeed = 25;
        }
    }
}
