using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private PlayerManager playerManager;

    //Instance.PlayerManager.

    private void Update()
    {
        coinsText.text = $"Points: {playerManager.Points}";

    }
}
