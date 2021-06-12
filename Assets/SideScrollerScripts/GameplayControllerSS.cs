using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayControllerSS : MonoBehaviour
{
    private GameObject PauseMenuCanvas;
    private Text UICoinDisplay;
    private Text UITimeDisplay;

    public static GameplayControllerSS controller;
    private int collectedCoins = 0;
    [SerializeField] private float TimeForCompletion;

    private void Awake()
    {
        controller = this;
    }

    private void Start()
    {
        AsyncOperation asyncOp = SceneManager.LoadSceneAsync("SideScrollerUI", LoadSceneMode.Additive);
        asyncOp.completed += (_) =>
        {
            PauseMenuCanvas = GameObject.Find("PauseMenuUI");
            UICoinDisplay = GameObject.Find("CoinDisplay").GetComponent<Text>();
            UITimeDisplay = GameObject.Find("TimerDisplay").GetComponent<Text>();
        };
    }

    public void AddCoin(int CoinsToAdd)
    {
        collectedCoins += CoinsToAdd;
        UICoinDisplay.text = collectedCoins.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuCanvas.gameObject.SetActive(!PauseMenuCanvas.gameObject.activeSelf);
        }

        TimeForCompletion -= Time.deltaTime;
        if (UITimeDisplay != null)
        {
            UITimeDisplay.text = TimeForCompletion.ToString("N"); 
        }
    }
}
