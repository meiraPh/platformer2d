using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Company.Core.Singleton;

public class UIInGameManager : Singleton<UIInGameManager>
{
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextTrophy;

    public static void UpdateTextCoins(string s)
    {
        Instance.uiTextCoins.text = s;
    }

    public static void UpdateTextTrophy(string s)
    {
        Instance.uiTextCoins.text = s;
    }

}
