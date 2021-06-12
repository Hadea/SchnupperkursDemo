using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public void StartTopDownShooter()
    {
        SceneManager.LoadScene("TopDownShooter");
    }

    public void StartSideScroller()
    {
        SceneManager.LoadScene("SideScroller");
    }


}
