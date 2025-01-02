using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_39 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(33, SecondWhiteCar));

            WhiteMovingPointTarget.Speed = 33;
            WhiteMovingPointTarget.MaxSpeed = 33;
        }
    }
}
