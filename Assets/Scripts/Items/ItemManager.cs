using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Company.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    public TextMeshProUGUI uiTextCoins;

    public SOInt trophy;
    public TextMeshProUGUI uiTextTrophy;

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        trophy.value = 0;
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUi();
    }

    public void AddTrophy(int amount = 1)
    {
        trophy.value += amount;
        UpdateUi();
    }

    private void UpdateUi()
    {
        //uiTextCoins.text = coins.ToString();
        //UIInGameManager.UpdateTextCoins(coins.value.ToString());
    }

}
