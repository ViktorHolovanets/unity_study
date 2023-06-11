using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<FrogController>() != null)
        {
            otherCollider.gameObject.GetComponent<FrogController>().poz=this.transform;
        }
    }
}
