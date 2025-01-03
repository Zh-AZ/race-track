using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_36 : GreenPoint_23
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position == TargetPoint.position)
        {
            StartCoroutine(ChangeSpeed(25, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 25;
            GreenMovingPointTarget.MaxSpeed = 30;
        }
    }
}
