using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint_23 : BaseChangeSpeedCoroutine
{
    [SerializeField] protected GreenCar CarGreen;
    [SerializeField] protected SecondGreenContinuation SecondGreenContinuation;
    [SerializeField] protected GreenMovingPointTarget GreenMovingPointTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == TransformPoint.position)
        {
            StartCoroutine(ChangeSpeed(0, CarGreen));
            StartCoroutine(ChangeSpeed(20, SecondGreenContinuation));

            GreenMovingPointTarget.Speed = 20;
            GreenMovingPointTarget.MaxSpeed = 25;
        }
    }
}
