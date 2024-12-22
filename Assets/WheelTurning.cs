using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTurning : MonoBehaviour
{
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
    }
}
