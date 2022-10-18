using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartLevel()
   {
        SceneManager.LoadScene("SampleScene");
   }

    public void Show()
    {
        Debug.Log("Shoooow");
        gameObject.SetActive(true);
    }
}
