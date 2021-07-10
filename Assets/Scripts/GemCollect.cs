using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{
    public static int GemCount { get; private set; } = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMovement player))
        {
            GemCount++;
            Destroy(gameObject);
        }
    }
}
