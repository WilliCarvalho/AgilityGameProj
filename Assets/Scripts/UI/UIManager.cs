using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI winnerText;
    [SerializeField] private TextMeshProUGUI loserText;

    public static UIManager instance;

    private void Awake()
    {
        if (instance != null) Destroy(this.gameObject);

        instance = this;

        winnerText.gameObject.SetActive(false);
        loserText.gameObject.SetActive(false);
    }

    public void ShowWinnerText()
    {
        loserText.gameObject.SetActive(false);
        winnerText.gameObject.SetActive(true);
    }

    public void ShowLoserText()
    {
        winnerText.gameObject.SetActive(false);
        loserText.gameObject.SetActive(true);
    }
}
