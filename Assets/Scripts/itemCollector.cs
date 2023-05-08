using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int coins = 0;

    [SerializeField] private TMP_Text coinsText;
    
    [SerializeField] private AudioSource coinSound;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinSound.Play();
            Destroy(other.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
