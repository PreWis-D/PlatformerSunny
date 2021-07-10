using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    private Text _score;

    private void Start()
    {
        _score = GetComponent<Text>();
    }

    private void Update()
    {
        _score.text = "= " + GemCollect.GemCount;
    }
}
