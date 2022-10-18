using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMenu : MonoBehaviour
{
    public GameObject RestartMenu;
    public GameObject FinishMenu;
    public void ShowRestart()
    {
        RestartMenu.SetActive(true);
    }

    public void ShowFinish()
    {
        FinishMenu.SetActive(true);
    }
}
