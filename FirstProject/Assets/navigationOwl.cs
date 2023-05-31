using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navigationOwl : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //if (horizontalInput == 0f && verticalInput == 0f)
        //{
        //    transform.Rotate(Vector3.up, 50f * Time.deltaTime);
        //}
        //else
        //{
            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
            rigidbody.MovePosition(transform.position + movement);
       // }
    }
}
