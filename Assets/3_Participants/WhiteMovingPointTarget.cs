using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WhiteMovingPointTarget : MovingPointTarget
{
    public WhiteCar WhiteCar;
    public SecondWhiteCar SecondWhiteCar;
    public ThirdWhiteCar ThirdWhiteCar;

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(17, WhiteCar));
    }


    // Update is called once per frame
    void Update()
    {
        if (Go)
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);

        if (transform.position == target)
        {
            if (target != pointArray[pointArray.Length - 1].position)
            {
                target = pointArray[indexCount++].position;
            }
        }

        ChangeDistance();
    }
}
