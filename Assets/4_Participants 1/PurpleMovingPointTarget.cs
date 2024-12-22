using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PurpleMovingPointTarget : MovingPointTarget
{
    public PurpleCar PurpleCar;

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(17, PurpleCar));
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
        SlowDown();
    }

    /// <summary>
    /// «амедление и ускорение в нужных точках
    /// </summary>
    private void SlowDown()
    {
        if (transform.position == pointArray[23].position)
        {
            StartCoroutine(ChangeSpeed(0, PurpleCar));

            Speed = 0;
            MaxSpeed = 0;
        }
        else if (transform.position == pointArray[20].position)
        {
            StartCoroutine(ChangeSpeed(15, PurpleCar));

            Speed = 15;
            MaxSpeed = 20;
        }
    }
}
