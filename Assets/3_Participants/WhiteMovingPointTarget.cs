using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class WhiteMovingPointTarget : MonoBehaviour
{
    public Transform[] pointArray = new Transform[57];
    public WhiteCar WhiteCar;
    public SecondWhiteCar SecondWhiteCar;
    public ThirdWhiteCar ThirdWhiteCar;


    public Transform transformMoving;

    //public Transform redFrontLeftWheel;
    //public Transform redFrontRightWheel;

    //public Transform blackFrontLeftWheel;
    //public Transform blackFrontRightWheel;

    //public Transform blueFrontLeftWheel;
    //public Transform blueFrontRightWheel;

    private Camera redCarCamera;
    private Camera blackCarCamera;
    private Camera blueCarCamera;

    public float Speed;
    public float MaxSpeed;
    private bool Go = true;
    private Vector3 target;
    public bool IsAchieve = false;
    public int Lap = 5; //5
    public int LapCount = 0;

    public float minDistance;
    public float maxDistance;

    Random Random = new Random();
    public int RandomSpeed;

    private int indexCount;

    public float accelerationTime = 1f;

    public float angleWheel;


    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(17, WhiteCar));
    }


    // Update is called once per frame
    void Update()
    {
        //ChangeCamera();

        if (Go)
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);

        if (transform.position == target)
        {
            if (target != pointArray[pointArray.Length - 1].position)
            {
                target = pointArray[indexCount++].position;

                if (transform.position == pointArray[23].position)
                {
                    Lap = 5;
                }
                else if (transform.position == pointArray[42].position)
                {
                    Lap = 10;
                }
            }
        }

        ChangeDistance();
        SlowDown();

    }


    //1 4 6 9 12 15 18

    private void ChangeDistance()
    {
        float distanceToCar = Vector3.Distance(transform.position, transformMoving.position);

        if (distanceToCar < minDistance)
        {
            Speed = Mathf.Lerp(Speed, MaxSpeed, (minDistance - distanceToCar) / minDistance);
        }
        else if (distanceToCar > maxDistance)
        {
            Speed = Mathf.Lerp(Speed, MaxSpeed, (distanceToCar - maxDistance) / maxDistance);
        }
    }

    IEnumerator ChangeSpeed(float targetSpeed, Moving car)
    {
        float initialSpeed = car.Speed;
        float elapsedTime = 0f;

        while (elapsedTime < accelerationTime)
        {
            car.Speed = Mathf.Lerp(initialSpeed, targetSpeed, elapsedTime / accelerationTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        car.Speed = targetSpeed;
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
        //
        //else if (transform.position == pointArray[48].position)
        //{
        //    StartCoroutine(ChangeSpeed(30, ThirdWhiteCar));

        //    Speed = 30;
        //    MaxSpeed = 35;
        //}
        //else if (transform.position == pointArray[49].position)
        //{
        //    StartCoroutine(ChangeSpeed(20, ThirdWhiteCar));

        //    Speed = 20;
        //    MaxSpeed = 25;
        //}

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
        //else if (transform.position == pointArray[38].position)
        //{
        //    //StartCoroutine(ChangeSpeed(40, SecondGreenContinuation));

        //    Speed = 40;
        //    MaxSpeed = 40;
        //}
        //else if (transform.position == pointArray[51].position)
        //{
        //    //StartCoroutine(ChangeSpeed(40, ThirdGreenContinuation));

        //    Speed = 40;
        //    MaxSpeed = 40;
        //}
        //else if (transform.position == pointArray[52].position)
        //{
        //    //StartCoroutine(ChangeSpeed(20, ThirdGreenContinuation));

        //    Speed = 20;
        //    MaxSpeed = 25;
        //}
        //else if (transform.position == pointArray[48].position)
        //{
        //    //StartCoroutine(ChangeSpeed(30, ThirdGreenContinuation));

        //    Speed = 30;
        //    MaxSpeed = 30;
        //}
        //else if (transform.position == pointArray[49].position)
        //{
        //    //StartCoroutine(ChangeSpeed(20, ThirdGreenContinuation));

        //    Speed = 20;
        //    MaxSpeed = 25;
        //}
        //else if (transform.position == pointArray[54].position)
        //{
        //    //StartCoroutine(ChangeSpeed(30, ThirdGreenContinuation));

        //    Speed = 30;
        //    MaxSpeed = 30;
        //}
        //else if (transform.position == pointArray[55].position)
        //{
        //    //StartCoroutine(ChangeSpeed(20, ThirdGreenContinuation));

        //    Speed = 20;
        //    MaxSpeed = 25;
        //}
        //else if (transform.position == pointArray[44].position)
        //{
        //    //StartCoroutine(ChangeSpeed(20, ThirdGreenContinuation));

        //    Speed = 20;
        //    MaxSpeed = 25;
        //}
    }

    private void ChangeCamera()
    {
        if (transform.position == pointArray[23].position)
        {
            blackCarCamera.depth = 2;
        }
        else if (transform.position == pointArray[42].position)
        {
            blueCarCamera.depth = 3;
        }
    }

    IEnumerator ChangeTarget()
    {
        if (transform.position == target)
        {
            for (int i = 0; i < pointArray.Length; i++)
            {
                if (target == pointArray[pointArray.Length - 1].position)
                {
                    target = pointArray[0].position;
                }
                else
                {
                    target = pointArray[i + 1].position;
                }

                yield return null;
            }
        }
    }
}
