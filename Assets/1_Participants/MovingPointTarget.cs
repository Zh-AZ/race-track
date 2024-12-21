using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = System.Random;

public class MovingPointTarget : MonoBehaviour
{
    public Transform[] pointArray = new Transform[57];
    public Moving RedCar;
    public CarBlack BlackCar;
    public CarBlue BlueCar;
    public WheelTurning wheelTurning;

    public Transform transformMoving;
    public Transform redFrontLeftWheel;
    public Transform blackFrontLeftWheel;

    public Camera redCarCamera;
    public Camera blackCarCamera;
    public Camera blueCarCamera;

    public float Speed;
    public float MaxSpeed;
    public bool Go = true;
    public Vector3 target;
    public int indexCount;
    public float MinDistance = 1;       
    public float MaxDistance = 2;
    public float accelerationTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(19, RedCar));
    }

    // Update is called once per frame
    void Update()
    {
        //if (Go)
        //    transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);

        //if (transform.position == target)
        //{
        //    if (target != pointArray[pointArray.Length - 1].position)
        //    {
        //        target = pointArray[indexCount++].position;
        //    }
        //}
        GoTarget();

        ChangeDistance();
        SlowDown();
        TurnWheels();
    }

    public void GoTarget()
    {
        if (Go)
            this.transform.position = Vector3.MoveTowards(this.transform.position, this.target, Time.deltaTime * this.Speed);

        if (this.transform.position == this.target)
        {
            if (this.target != this.pointArray[pointArray.Length - 1].position)
            {
                this.target = this.pointArray[indexCount++].position;
            }
        }
    }

    public void ChangeDistance()
    {
        float distanceToCar = Vector3.Distance(transform.position, transformMoving.position);

        if (distanceToCar < MinDistance)
        {
            Speed = Mathf.Lerp(Speed, MaxSpeed, (MinDistance - distanceToCar) / MinDistance);
        }
        else if (distanceToCar > MaxDistance)
        {
            Speed = Mathf.Lerp(Speed, MaxSpeed, (distanceToCar - MaxDistance) / MaxDistance);
        }
    }

    public IEnumerator ChangeSpeed(float targetSpeed, Moving car)
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

    private void TurnWheels()
    {
        if (transform.position == pointArray[2].position || transform.position == pointArray[4].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -45, redFrontLeftWheel));
        }

        else if (transform.position == pointArray[3].position || transform.position == pointArray[5].position) 
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, 30, redFrontLeftWheel));
        }
        else if (transform.position == pointArray[21].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, 45, redFrontLeftWheel));
        }
        else if (transform.position == pointArray[22].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -45, redFrontLeftWheel));
        }

        else if (transform.position == pointArray[27].position || transform.position == pointArray[37].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -45, blackFrontLeftWheel));
        }
        else if (transform.position == pointArray[28].position || transform.position == pointArray[38].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, 17, blackFrontLeftWheel));
        }
    }

    private void SlowDown()
    {
        if (transform.position == pointArray[23].position)
        {
            StartCoroutine(ChangeSpeed(0, RedCar));
            StartCoroutine(ChangeSpeed(20, BlackCar));
        }
        else if (transform.position == pointArray[41].position)
        {
            StartCoroutine(ChangeSpeed(0, BlackCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[42].position)
        {
            StartCoroutine(ChangeSpeed(20, BlueCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[57].position)
        {
            StartCoroutine(ChangeSpeed(0, BlueCar));
        }

        else if (transform.position == pointArray[3].position)
        {
            StartCoroutine(ChangeSpeed(15, RedCar));

            Speed = 15;
            MaxSpeed = 20;
        }
        else if (transform.position == pointArray[4].position)
        {
            StartCoroutine(ChangeSpeed(20, RedCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[14].position)
        {
            StartCoroutine(ChangeSpeed(18, RedCar));

            Speed = 20;
            MaxSpeed = 25;
        }

        else if (transform.position == pointArray[25].position)
        {
            StartCoroutine(ChangeSpeed(18, BlackCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[39].position)
        {
            StartCoroutine(ChangeSpeed(30, BlackCar));

            Speed = 30;
            MaxSpeed = 30;
        }

        else if (transform.position == pointArray[48].position)
        {
            StartCoroutine(ChangeSpeed(20, BlueCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[49].position)
        {
            StartCoroutine(ChangeSpeed(20, BlueCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[51].position)
        {
            StartCoroutine(ChangeSpeed(33, BlueCar));

            Speed = 33;
            MaxSpeed = 38;
        }
        else if (transform.position == pointArray[52].position)
        {
            StartCoroutine(ChangeSpeed(20.50f, BlueCar));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[54].position)
        {
            StartCoroutine(ChangeSpeed(30, BlueCar));

            Speed = 30;
            MaxSpeed = 35;
        }
        else if (transform.position == pointArray[55].position)
        {
            StartCoroutine(ChangeSpeed(21, BlueCar));

            Speed = 21;
            MaxSpeed = 26;
        }
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

    public IEnumerator ChangeTarget()
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
