using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Moving : MonoBehaviour
{
    public Transform targetPoint;
    public float Speed;
    public float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (Speed > 0)
        {
            StartCoroutine(RotateTowardsTarget());
        }
        
        transform.position = Vector3.MoveTowards(this.transform.position, targetPoint.position, Time.deltaTime * Speed);
    }

    public IEnumerator RotateTowardsTarget()
    {
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.LookRotation(targetPoint.position - transform.position);

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
