using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public Transform targetPoint;
    public Transform WhiteCar;
    public Transform SecondWhiteCar;
    public Transform ThirdWhiteCar;

    public WhiteCar whiteCar;
    public SecondWhiteCar secondWhiteCar;
    public ThirdWhiteCar thirdWhiteCar;

    public float Speed = 15;
    public float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (whiteCar.Speed > 0)
        {
            StartCoroutine(RotateTowardsTarget(WhiteCar));
        }
        else if (secondWhiteCar.Speed > 0)
        {
            StartCoroutine(RotateTowardsTarget(SecondWhiteCar));
        }
        else if (thirdWhiteCar.Speed > 0)
        {
            StartCoroutine(RotateTowardsTarget(ThirdWhiteCar));
        }

        transform.position = Vector3.MoveTowards(this.transform.position, targetPoint.position, Time.deltaTime * Speed);
    }

    public IEnumerator RotateTowardsTarget(Transform whiteCar)
    {
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.LookRotation(whiteCar.position - transform.position);

        float elapsed = 0f;

        while (elapsed < rotationSpeed)
        {
            elapsed += Time.deltaTime;
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsed / rotationSpeed);
            yield return null;
        }

        transform.rotation = targetRotation;
    }
}
