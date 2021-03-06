using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GemCollector : MonoBehaviour
{
    public event UnityAction<int> Collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Gem gem))
        {
            Collected?.Invoke(gem.Count);
            Destroy(gem.gameObject);
        }
    }
}
