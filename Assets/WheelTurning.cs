using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTurning : MonoBehaviour
{
    //public float rotationSpeed = 1f;
    public Transform targetPoint;

    //public Transform redFrontLeftWheel;
    //public Transform redFrontRightWheel;

    //public Transform blackFrontLeftWheel;
    //public Transform blackFrontRightWheel;

    //public Transform blueFrontLeftWheel;
    //public Transform blueFrontRightWheel;


    private float currentSteerAngle = 0f;
    public float turnSpeed = 0.5f;


    public float rotationAngle = 0f; 
    public float rotationSpeed = 5f; 

    //private bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TurnWheels();
        //StartCoroutine(RotateLeftCoroutine(rotationAngle));

        //if (transform.rotation.y > -106.877)   // -106.877
        //{
        //    transform.rotation = Quaternion.Euler(0, -90 - 1, 0);
        //}
    }

    public void TurnWheels()
    {

    }

    public IEnumerator RotateFromMinus90ToMinus160(float duration, float endAngle)
    {
        float startAngle = -90f;  
        //float endAngle = -116f;  
        float elapsedTime = 0f;  

        Vector3 startRotation = transform.eulerAngles;

        while (elapsedTime < duration)
        {
            float yAngle = Mathf.LerpAngle(startAngle, endAngle, elapsedTime / duration);
            transform.eulerAngles = new Vector3(startRotation.x, yAngle, startRotation.z);

            elapsedTime += Time.deltaTime; 
            yield return null; 
        }

        transform.eulerAngles = new Vector3(startRotation.x, endAngle, startRotation.z);
    }

    public void SteerWheels(int leftOrRight)
    {
        float targetSteerAngle = 0f; 
            

        if (leftOrRight == 1) 
            targetSteerAngle = -30f;
        else if (leftOrRight == 2) 
            targetSteerAngle = 30f;

        currentSteerAngle = Mathf.Lerp(currentSteerAngle, targetSteerAngle, Time.deltaTime * turnSpeed);

        transform.localRotation = Quaternion.Euler(0, -90 + currentSteerAngle, 0);
    }

    public IEnumerator RotateYValue(float speed, float targetAngle, Transform transform)
    {
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + targetAngle, transform.eulerAngles.z);

        float elapsedTime = 0f;
        
        while (elapsedTime < speed)
        {
            float currentZRotation = transform.eulerAngles.z;

            transform.rotation = Quaternion.Slerp(startRotation, endRotation, elapsedTime / speed);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentZRotation); 

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        float finalZRotation = transform.eulerAngles.z;
        transform.rotation = endRotation;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, finalZRotation);

        //transform.rotation = endRotation;

        //elapsedTime = 0f;

        //while (elapsedTime < speed)
        //{
        //    transform.rotation = Quaternion.Slerp(endRotation, startRotation, elapsedTime / speed);
        //    //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentZRotation); 

        //    elapsedTime += Time.deltaTime;
        //    yield return null;
        //}



    }

    public IEnumerator RotateWithAngle(float angle)
    {
        float targetAngle = transform.eulerAngles.y - angle;
        float currentAngle = transform.eulerAngles.y;

        while (Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngle)) > 0.1f)
        {
            currentAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * rotationSpeed);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, currentAngle, transform.eulerAngles.z);
            yield return null;
        }

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, targetAngle, transform.eulerAngles.z);
    }

    //private void TurnWheels()
    //{
    //    if (targetPoint.position == pointArray[1].position || targetPoint.position == pointArray[4].position || targetPoint.position == pointArray[7].position ||
    //        targetPoint.position == pointArray[14].position || targetPoint.position == pointArray[16].position || targetPoint.position == pointArray[18].position)
    //    {
    //        StartCoroutine(RotateLeftCoroutine(20));
    //    }
    //    else if (targetPoint.position == pointArray[10].position || targetPoint.position == pointArray[12].position)
    //    {
    //        StartCoroutine(RotateLeftCoroutine(-20));
    //    }
    //    else
    //    {
    //        StartCoroutine(RotateLeftCoroutine(0));
    //    }
    //}


    //public IEnumerator RotateTowardsTarget()
    //{
    //    Quaternion startRotation = transform.rotation;
    //    //Quaternion targetRotation = Quaternion.LookRotation(targetPoint.position - transform.position);

    //    float elapsed = 0f;

    //    while (elapsed < rotationSpeed)
    //    {
    //        elapsed += Time.deltaTime;
    //        transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsed / rotationSpeed);
    //        yield return null; 
    //    }

    //    //transform.rotation = targetRotation;

    //    transform.rotation = Quaternion.Slerp(startRotation, , 90);
    //}
}
