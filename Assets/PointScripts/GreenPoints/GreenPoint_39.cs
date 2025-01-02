using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_39 : GreenPoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(28, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 28;
            GreenMovingPointTarget.MaxSpeed = 28;
        }
    }
}
