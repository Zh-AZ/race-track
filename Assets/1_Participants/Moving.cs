using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class Moving : MonoBehaviour
{
    public Transform targetPoint;

    public float Speed;
    public bool Go;
    private Vector3 target;

    public float rotationSpeed = 1f;

    public float fiveSecond;
    Random Random = new Random();
    public int RandomSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //AddRandomSpeed();
    }

    public void Move()
    {
        if (Speed > 0)
        {
            StartCoroutine(RotateTowardsTarget());
        }
        
        transform.position = Vector3.MoveTowards(this.transform.position, targetPoint.position, Time.deltaTime * Speed);
    }

    public void AddRandomSpeed()
    {
        fiveSecond += Time.deltaTime;

        if (fiveSecond >= 1 && Speed > 0)
        {
            fiveSecond = 0;

            if (Random.Next(2) == 0 && Speed > 18)
            {
                Speed -= Random.Next(1, 2);
            }
            else if (Random.Next(2) == 1 && Speed < 20)
            {
                Speed += Random.Next(1, 2);
            }
        }
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
