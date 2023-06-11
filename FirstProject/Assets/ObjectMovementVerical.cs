using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementVerical : MonoBehaviour
{
    public float speed = 5f; // Швидкість руху
    public float distance = 2f; // Відстань руху

    private Vector3 initialPosition;
    private float minY;
    private float maxY;
    private bool movingUp = true;

    private void Start()
    {
        initialPosition = transform.position;
        minY = initialPosition.y - distance;
        maxY = initialPosition.y + distance;
    }

    private void Update()
    {
        if (movingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            if (transform.position.y >= maxY)
                movingUp = false;
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            if (transform.position.y <= minY)
                movingUp = true;
        }
    }
}
