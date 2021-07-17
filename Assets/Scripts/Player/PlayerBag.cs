using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(GemCollector))]
public class PlayerBag : MonoBehaviour
{
    [SerializeField] private GemCollector _gemCollector;

    private int _gemCount;

    public event UnityAction<int> GemCollected;

    private void OnEnable()
    {
        _gemCollector.Reached += AddGemCount;
    }

    private void OnDisable()
    {
        _gemCollector.Reached -= AddGemCount;
    }

    public void AddGemCount(int count)
    {
        _gemCount += count;
        GemCollected?.Invoke(_gemCount);
    }
}
