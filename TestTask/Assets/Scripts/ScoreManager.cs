using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    public GameObject FinishMenu;
    public int FinalScore = 7;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;
        score = 0;
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "x " + score.ToString();
        if (score == FinalScore)
        {
            LevelComplete();
        }
    }

    private void LevelComplete()
    {
        FinishMenu.SetActive(true);
    }
}
