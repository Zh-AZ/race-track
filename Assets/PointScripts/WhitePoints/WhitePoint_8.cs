using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_8 : WhitePoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(15, WhiteCar));

            WhiteMovingPointTarget.Speed = 15;
            WhiteMovingPointTarget.MaxSpeed = 20;
        }
    }
}
