using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class GreenMovingPointTarget : MovingPointTarget
{
    public GreenCar CarGreen;
    public SecondGreenContinuation SecondGreenContinuation;

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(20, CarGreen));
    }

    //Update is called once per frame
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

    //1 4 6 9 12 15 18

    /// <summary>
    /// «амедление и ускорение в нужных точках
    /// </summary>
    private void SlowDown()
    {
        if (transform.position == pointArray[23].position)
        {
            StartCoroutine(ChangeSpeed(0, CarGreen));
            StartCoroutine(ChangeSpeed(20, SecondGreenContinuation));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[41].position)
        {
            StartCoroutine(ChangeSpeed(0, SecondGreenContinuation));

            Speed = 20;
            MaxSpeed = 25;
        }

        else if (transform.position == pointArray[10].position)
        {
            StartCoroutine(ChangeSpeed(15, CarGreen));

            Speed = 15;
            MaxSpeed = 20;
        }

        else if (transform.position == pointArray[31].position)
        {
            StartCoroutine(ChangeSpeed(15, SecondGreenContinuation));

            Speed = 15;
            MaxSpeed = 20;
        }
        else if (transform.position == pointArray[32].position)
        {
            StartCoroutine(ChangeSpeed(20, SecondGreenContinuation));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[35].position)
        {
            StartCoroutine(ChangeSpeed(15, SecondGreenContinuation));

            Speed = 15;
            MaxSpeed = 20;
        }
        else if (transform.position == pointArray[36].position)
        {
            StartCoroutine(ChangeSpeed(25, SecondGreenContinuation));

            Speed = 25;
            MaxSpeed = 30;
        }
        else if (transform.position == pointArray[39].position)
        {
            StartCoroutine(ChangeSpeed(28, SecondGreenContinuation));

            Speed = 28;
            MaxSpeed = 28;
        }
    }
}
