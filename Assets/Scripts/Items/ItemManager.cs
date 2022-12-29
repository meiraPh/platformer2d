using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Company.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public int coins;
    public TextMeshProUGUI uiTextCoins;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins = 0;
    }

    public void AddCoins(int amount = 1)
    {
        coins += amount;
        UpdateUi();
    }

    private void UpdateUi()
    {
        uiTextCoins.text = coins.ToString();
    }

}
