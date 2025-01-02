using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_36 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(19, SecondWhiteCar));

            WhiteMovingPointTarget.Speed = 19;
            WhiteMovingPointTarget.MaxSpeed = 24;
        }
    }
}
