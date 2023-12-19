using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Drawing;

public class TemporaryCoinText : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private void Update()
    {
        DataManager.instance.LoadPlayerData();
        coinText.text = "Coin : " + DataManager.instance.player.Coin;
    }
}
