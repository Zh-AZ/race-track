using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_32 : GreenPoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(20, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 20;
            GreenMovingPointTarget.MaxSpeed = 25;
        }
    }
}
