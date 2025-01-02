using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseChangeSpeedCoroutine : MonoBehaviour
{
    [SerializeField] protected Transform TransformPoint;
    public float accelerationTime = 1f;

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
}
