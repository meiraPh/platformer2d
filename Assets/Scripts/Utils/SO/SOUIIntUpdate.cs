using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUIIntUpdate : MonoBehaviour
{
    public SOInt soIntCoin;
    public SOInt soIntTrophy;

    public TextMeshProUGUI uiTextCoinValue;
    public TextMeshProUGUI uiTextTrophyValue;
    // Start is called before the first frame update
    void Start()
    {
        uiTextCoinValue.text = soIntCoin.value.ToString();
        uiTextTrophyValue.text = soIntTrophy.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        uiTextCoinValue.text = soIntCoin.value.ToString();
        uiTextTrophyValue.text = soIntTrophy.value.ToString();
    }
}
