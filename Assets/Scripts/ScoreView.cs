using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    private Text _score;

    public static ScoreView Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        _score = GetComponent<Text>();
    }

    public void ShowInfo()
    {
        _score.text = "= " + GemCollect.GemCount.ToString();
    }
}
