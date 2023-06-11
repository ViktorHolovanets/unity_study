using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CoinTouch : MonoBehaviour
{
    public  int coin;
    public Text text;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coin++;
            Destroy(other.gameObject);
            text.text=coin.ToString();
        }
    }
}
