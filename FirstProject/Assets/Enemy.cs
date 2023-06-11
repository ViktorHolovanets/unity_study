using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {

        if (otherCollider.GetComponent<FrogController>() != null)
        {
            otherCollider.gameObject.GetComponent<HeartsSystem>().DamagePlayer();
        }

        var transformPosition = otherCollider.GetComponent<FrogController>().getPozition();
        otherCollider.transform.position = transformPosition.position;
    }
}
