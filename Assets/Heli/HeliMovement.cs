using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMovement : MonoBehaviour
{
    public Vector3[] pointMovement;
    public Vector3 target;
    Helicopter helicopter;
    public int indexCount;
    public float Speed;
    public float accelerationTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        target = pointMovement[0];
        //StartCoroutine(ChangeSpeed(19, helicopter));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * Speed);

        if (transform.position == target)
        {
            if (target != pointMovement[pointMovement.Length - 1])
            {
                target = pointMovement[indexCount++];
            }
        }
    }

    public IEnumerator ChangeSpeed(float targetSpeed, Helicopter helicopter)
    {
        float initialSpeed = helicopter.Speed;
        float elapsedTime = 0f;

        while (elapsedTime < accelerationTime)
        {
            helicopter.Speed = Mathf.Lerp(initialSpeed, targetSpeed, elapsedTime / accelerationTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        helicopter.Speed = targetSpeed;
    }
}
