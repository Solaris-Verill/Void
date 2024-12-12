using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int hp = 10;
    public Coin c;
    public TextMeshProUGUI hpText;

    private void Start()
    {
        hp = 10;
        hpText.text = hp.ToString();
    }

    void Update()
    {
        if (hp <= 0)
        {
            GameOver();
        }
    }

    public void TakeDamage()
    {
        --hp;
        hpText.text = hp.ToString();
    }

    public void saveHP()
    {
        PlayerPrefs.SetInt("HP", hp);
    }

    void GameOver()
    {
        saveHP();
        c.saveCoins();
        SceneManager.LoadScene("MainMenu");
    }
}
