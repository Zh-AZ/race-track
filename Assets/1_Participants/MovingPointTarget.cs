using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = System.Random;

public class MovingPointTarget : BaseChangeSpeedCoroutine
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

    // Start is called before the first frame update
    void Start()
    {
        target = pointArray[0].position;
        StartCoroutine(ChangeSpeed(19, RedCar));
    }

    // Update is called once per frame
    void Update()
    {
        GoTarget();
        ChangeDistance();
        TurnWheels();
    }

    /// <summary>
    /// Смена цели и движение
    /// </summary>
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

    /// <summary>
    /// Менять скорость в зависимости от расстояния машины к цели
    /// </summary>
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

    /// <summary>
    /// Поворот колеса в нужных точках
    /// </summary>
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
}
