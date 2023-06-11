using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
  Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Frog").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = transform.position;
        tmp.y = player.position.y;
        tmp.x = player.position.x;
        transform.position = tmp;
    }
}
