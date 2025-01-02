using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_35 : GreenPoint_23
{
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(15, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 15;
            GreenMovingPointTarget.MaxSpeed = 20;
        }
    }
}
