using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Transform targetPoint;
    public float Speed = 1.0f;
    public bool Go;
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

        if (Go)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, Time.deltaTime * Speed);
        }
    }

    IEnumerator RollPlane(float targetAngle)
    {
        float duration = 1f; // Продолжительность разворота в секундах
        float startRotationZ = transform.eulerAngles.z; // Начальный угол по оси Z
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            if (transform.eulerAngles.z <= targetAngle)
            {
                timeElapsed += Time.deltaTime;
                float angleToRotate = Mathf.Lerp(0, targetAngle, timeElapsed / duration);
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, startRotationZ + angleToRotate);
            }
            yield return null;
        }
    }

    IEnumerator RotateTowardsTarget()
    {
        Quaternion startRotation = transform.rotation;
        Quaternion targetRotation = Quaternion.LookRotation(targetPoint.position - transform.position);

        float elapsed = 0f;

        while (elapsed < rotationSpeed)
        {
            elapsed += Time.deltaTime;
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsed / rotationSpeed);
            yield return null; // Ожидаем до следующего кадра
        }

        // Устанавливаем точное целевое вращение в конце
        transform.rotation = targetRotation;
    }
}
