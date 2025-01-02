using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePoint_23 : BaseChangeSpeedCoroutine
{
    [SerializeField] protected WhiteCar WhiteCar;
    [SerializeField] protected SecondWhiteCar SecondWhiteCar;
    [SerializeField] protected ThirdWhiteCar ThirdWhiteCar;
    [SerializeField] protected WhiteMovingPointTarget WhiteMovingPointTarget;

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(0, WhiteCar));
            StartCoroutine(ChangeSpeed(17, SecondWhiteCar));

            WhiteMovingPointTarget.Speed = 20;
            WhiteMovingPointTarget.MaxSpeed = 25;
        }
    }
}
