using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementHorizontal : MonoBehaviour
{
    public float speed = 5f; // Швидкість руху
    public float distance = 2f; // Відстань руху

    private Vector3 initialPosition;
    private float minX;
    private float maxX;
    private bool movingRight = true;

    private void Start()
    {
        initialPosition = transform.position;
        minX = initialPosition.x - distance;
        maxX = initialPosition.x + distance;
    }

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (transform.position.x >= maxX)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x <= minX)
                movingRight = true;
        }
    }
}
