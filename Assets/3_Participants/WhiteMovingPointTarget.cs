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
        SlowDown();
    }

    private void SlowDown()
    {
        if (transform.position == pointArray[23].position)
        {
            StartCoroutine(ChangeSpeed(0, WhiteCar));
            StartCoroutine(ChangeSpeed(17, SecondWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[41].position)
        {
            StartCoroutine(ChangeSpeed(0, SecondWhiteCar));
            //StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[42].position)
        {
            //StartCoroutine(ChangeSpeed(0, CarBlack));
            StartCoroutine(ChangeSpeed(18, ThirdWhiteCar));

            Speed = 18;
            MaxSpeed = 23;
        }
        else if (transform.position == pointArray[57].position)
        {
            StartCoroutine(ChangeSpeed(0, ThirdWhiteCar));
        }

        else if (transform.position == pointArray[3].position)
        {
            StartCoroutine(ChangeSpeed(20, WhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[8].position)
        {
            StartCoroutine(ChangeSpeed(15, WhiteCar));

            Speed = 15;
            MaxSpeed = 20;
        }
        else if (transform.position == pointArray[11].position)
        {
            StartCoroutine(ChangeSpeed(20, WhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }

        else if (transform.position == pointArray[27].position)
        {
            StartCoroutine(ChangeSpeed(20, SecondWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[36].position)
        {
            StartCoroutine(ChangeSpeed(19, SecondWhiteCar));

            Speed = 19;
            MaxSpeed = 24;
        }
        else if (transform.position == pointArray[39].position)
        {
            StartCoroutine(ChangeSpeed(33, SecondWhiteCar));

            Speed = 33;
            MaxSpeed = 33;
        }

        else if (transform.position == pointArray[43].position)
        {
            StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        //else if (transform.position == pointArray[46].position)
        //{
        //    StartCoroutine(ChangeSpeed(25, ThirdWhiteCar));

        //    Speed = 25;
        //    MaxSpeed = 30;
        //}
        else if (transform.position == pointArray[48].position)
        {
            StartCoroutine(ChangeSpeed(35, ThirdWhiteCar));

            Speed = 35;
            MaxSpeed = 40;
        }
        else if (transform.position == pointArray[49].position)
        {
            StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[51].position)
        {
            StartCoroutine(ChangeSpeed(26, ThirdWhiteCar));

            Speed = 26;
            MaxSpeed = 31;
        }
        else if (transform.position == pointArray[52].position)
        {
            StartCoroutine(ChangeSpeed(19, ThirdWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[54].position)
        {
            StartCoroutine(ChangeSpeed(30, ThirdWhiteCar));

            Speed = 30;
            MaxSpeed = 35;
        }
        else if (transform.position == pointArray[55].position)
        {
            StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

            Speed = 20;
            MaxSpeed = 25;
        }
    }
}
