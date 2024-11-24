using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = System.Random;

public class MovingPointTarget : MonoBehaviour
{
    public Transform[] pointArray = new Transform[57];
    public Moving CarRed;
    public SecondObject CarBlack;
    public ThirdObject CarBlue;

    public WheelTurning wheelTurning;

    public Transform transformMoving;

    public Transform redFrontLeftWheel;
    public Transform redFrontRightWheel;

    public Transform blackFrontLeftWheel;
    public Transform blackFrontRightWheel;

    public Transform blueFrontLeftWheel;
    public Transform blueFrontRightWheel;

    public Camera redCarCamera;
    public Camera blackCarCamera;
    public Camera blueCarCamera;

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

    //public bool IsMove;


    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(20, CarRed));
    }
        
    

    // Update is called once per frame
    void Update()
    {
        //AddRandomSpeed(CarRed);
        //AddRandomSpeed(CarBlue);
        //AddRandomSpeed(CarBlack);
        ChangeCamera();

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
                //else if (transform.position == pointArray[15].position)
                //{
                //    Lap = 15;
                //}
            }
            //else
            //{
            //    target = pointArray[0].position;
            //    indexCount = 0;
            //    Lap = 0;
            //    LapCount = 0;
            //}
        }

        ChangeDistance();

        //StartCoroutine(ChangeSpeed(10));
        SlowDown();

        TurnWheels();

        //StartCoroutine(ChangeTarget());
        
        //ChangeDistance();

        //if (transform.position == target)
        //{
        //    if (target != pointArray[pointArray.Length - 1].position)
        //    {
        //        target = pointArray[indexCount++].position;

        //        if (transform.position == pointArray[5].position)
        //        {
        //            Lap = 5;
        //        }
        //        else if (transform.position == pointArray[10].position)
        //        {
        //            Lap = 10;
        //        }
        //        else if (transform.position == pointArray[15].position)
        //        {
        //            Lap = 15;
        //        }
        //    }
        //    else
        //    {
        //        target = pointArray[0].position;
        //        indexCount = 0;
        //        Lap = 0;
        //        LapCount = 0;
        //    }
        //}
    }

    

    //1 4 6 9 12 15 18

    private void ChangeDistance()
    {
        float distanceToCar = Vector3.Distance(transform.position, transformMoving.position);
        //float speed = baseSpeed;

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

    private void TurnWheels()
    {

        //if (transform.position == pointArray[2].position)
        //{
        //    StartCoroutine(wheelTurning.RotateLeftCoroutine(90));
        //}
        //else if (transform.position == pointArray[4].position)
        //{
        //    StartCoroutine(wheelTurning.RotateLeftCoroutine(-90));
        //}
        //else if (transform.position == pointArray[5].position)
        //{
        //    StartCoroutine(wheelTurning.RotateLeftCoroutine(90));
        //}




        //if (transform.position == pointArray[2].position || transform.position == pointArray[4].position || transform.position == pointArray[7].position ||
        //    transform.position == pointArray[14].position || transform.position == pointArray[16].position || transform.position == pointArray[18].position)

        if (transform.position == pointArray[2].position || transform.position == pointArray[4].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -45, redFrontLeftWheel));
        }
        //else if (transform.position == pointArray[3].position || transform.position == pointArray[5].position || transform.position == pointArray[8].position ||
        //    transform.position == pointArray[15].position || transform.position == pointArray[17].position || transform.position == pointArray[19].position)

        else if (transform.position == pointArray[3].position || transform.position == pointArray[5].position) 
        {
            //StartCoroutine(wheelTurning.RotateFromMinus90ToMinus160(0.5f, -90));

            StartCoroutine(wheelTurning.RotateYValue(0.5f, 17, redFrontLeftWheel));

            //StartCoroutine(wheelTurning.RotateWithQuaternion(0.5f, -90));
        }
        else if (transform.position == pointArray[21].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, 45, redFrontLeftWheel));
        }
        else if (transform.position == pointArray[22].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -17, redFrontLeftWheel));
        }

        else if (transform.position == pointArray[27].position || transform.position == pointArray[37].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, -45, blackFrontLeftWheel));
        }
        else if (transform.position == pointArray[28].position || transform.position == pointArray[38].position)
        {
            StartCoroutine(wheelTurning.RotateYValue(0.5f, 17, blackFrontLeftWheel));
        }

        //else if (transform.position == pointArray[50].position)
        //{
        //    StartCoroutine(wheelTurning.RotateYValue(0.5f, 45, blueFrontLeftWheel));
        //}
        //else if (transform.position == pointArray[51].position)
        //{
        //    StartCoroutine(wheelTurning.RotateYValue(0.5f, -25, blueFrontLeftWheel));
        //}
        //else if (transform.position == pointArray[52].position)
        //{
        //    StartCoroutine(wheelTurning.RotateYValue(0.5f, 45, blueFrontLeftWheel));
        //}
        //else if (transform.position == pointArray[53].position)
        //{
        //    //StartCoroutine(wheelTurning.RotateYValue(0.5f, -10, blueFrontLeftWheel));
        //}
    }

    private void SlowDown()
    {
        if (transform.position == pointArray[23].position)
        {
            StartCoroutine(ChangeSpeed(0, CarRed));
            StartCoroutine(ChangeSpeed(20, CarBlack));
        }
        else if (transform.position == pointArray[42].position)
        {
            StartCoroutine(ChangeSpeed(0, CarBlack));
            StartCoroutine(ChangeSpeed(20, CarBlue));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[57].position)
        {
            StartCoroutine(ChangeSpeed(0, CarBlue));
        }

        else if (transform.position == pointArray[38].position)
        {
            StartCoroutine(ChangeSpeed(40, CarBlack));

            Speed = 40;
            MaxSpeed = 40;
        }
        else if (transform.position == pointArray[51].position)
        {
            StartCoroutine(ChangeSpeed(40, CarBlue));

            Speed = 40;
            MaxSpeed = 40;
        }
        else if (transform.position == pointArray[52].position)
        {
            StartCoroutine (ChangeSpeed(20, CarBlue));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[48].position)
        {
            StartCoroutine(ChangeSpeed(30, CarBlue));

            Speed = 30;
            MaxSpeed = 30;
        }
        else if (transform.position == pointArray[49].position)
        {
            StartCoroutine(ChangeSpeed(20, CarBlue));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[54].position)
        {
            StartCoroutine(ChangeSpeed(30, CarBlue));

            Speed = 30;
            MaxSpeed = 30;
        }
        else if (transform.position == pointArray[55].position)
        {
            StartCoroutine(ChangeSpeed(20, CarBlue));

            Speed = 20;
            MaxSpeed = 25;
        }
        else if (transform.position == pointArray[44].position)
        {
            StartCoroutine(ChangeSpeed(20, CarBlue));

            Speed = 20;
            MaxSpeed = 25;
        }



        //else if (transform.position == pointArray[23].position)
        //{
        //     StartCoroutine(ChangeSpeed(0));
        //}

        //if (transform.position == pointArray[1].position || transform.position == pointArray[4].position || transform.position == pointArray[6].position
        //    || transform.position == pointArray[12].position || transform.position == pointArray[15].position || transform.position == pointArray[18].position)
        //{
        //    StartCoroutine(ChangeSpeed(18));
        //}
        //else if (transform.position == pointArray[3].position)
        //{
        //    StartCoroutine(ChangeSpeed(20));
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
