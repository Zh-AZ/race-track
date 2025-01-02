using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_10 : GreenPoint_23
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(15, CarGreen));

            GreenMovingPointTarget.Speed = 15;
            GreenMovingPointTarget.MaxSpeed = 20;
        }
    }
}
