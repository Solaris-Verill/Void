using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    static public int coins;
    public Health health;
    public TextMeshProUGUI coinText;

    private void Start()
    {
        coins = 0;
        coinText.text = coins.ToString();
    }

    private void Update()
    {
        if (coins == 4)
        {
            Win();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 10)
        {
            ++coins;
            coinText.text = coins.ToString();
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    public void saveCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }

    void Win()
    {
        health.saveHP();
        saveCoins();
        SceneManager.LoadScene("MainMenu");
    }
}
