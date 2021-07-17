using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Gem _gem;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            _gem = Instantiate(_gem, new Vector3(_spawnPoints[i].position.x, _spawnPoints[i].position.y), transform.rotation);
        }
    }
}
