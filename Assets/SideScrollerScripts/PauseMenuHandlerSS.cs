using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuHandlerSS : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ReturnToGame()
    {
        gameObject.SetActive(false);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
