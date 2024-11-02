using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    //public Transform point1;
    //public Transform point2;
    public Transform targetPoint;
    public MovingPointTarget MovinPointTarget;
    public float Speed = 1.0f;
    //public bool Go;
    private Vector3 target;

    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RotateTowardsTarget());

        Move();
    }

    //public void Move()
    //{
    //    transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
    //}

    public void Move()
    {

        if (MovinPointTarget.Lap < 5)
        {
            StartCoroutine(RotateTowardsTarget());
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
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
            yield return null; // ќжидаем до следующего кадра
        }

        // ”станавливаем точное целевое вращение в конце
        transform.rotation = targetRotation;
    }
}
