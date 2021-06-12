using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayControllerSS : MonoBehaviour
{
    [SerializeField] private Canvas PauseMenuCanvas;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuCanvas.gameObject.SetActive(!PauseMenuCanvas.gameObject.activeSelf);
        }
    }
}
