using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int CoinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            GameplayControllerSS.controller.AddCoin(CoinValue);
            Destroy(gameObject);
        }
    }
}
