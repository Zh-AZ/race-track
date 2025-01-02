using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_41 : GreenPoint_23
{
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(0, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 20;
            GreenMovingPointTarget.MaxSpeed = 25;
        }
    }
}
