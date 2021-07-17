using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class ScoreView : MonoBehaviour
{
    [SerializeField] private PlayerBag _playerBag;
    private TMP_Text _score;

    private void Start()
    {
        _score = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _playerBag.GemCollected += OnGameScoreChanged;
    }

    private void OnDisable()
    {
        _playerBag.GemCollected -= OnGameScoreChanged;
    }

    private void OnGameScoreChanged(int gemCount)
    {
        _score.text = "= " + gemCount.ToString();
    }
}
