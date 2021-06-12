using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayControllerSS : MonoBehaviour
{
    [SerializeField] private Canvas PauseMenuCanvas;
    [SerializeField] private Text UICoinDisplay;

    public static GameplayControllerSS controller;
    private int collectedCoins = 0;

    private void Awake()
    {
        controller = this;
    }

    public void AddCoin(int CoinsToAdd)
    {
        collectedCoins += CoinsToAdd;
        UICoinDisplay.text = collectedCoins.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuCanvas.gameObject.SetActive(!PauseMenuCanvas.gameObject.activeSelf);
        }
    }
}
