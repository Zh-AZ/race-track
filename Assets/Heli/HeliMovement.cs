using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliMovement : MonoBehaviour
{
    public Vector3[] pointMovement;
    public Vector3 target;
    public int indexCount;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        target = pointMovement[0];
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
}
