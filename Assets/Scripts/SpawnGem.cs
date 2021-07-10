using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGem : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _gem;

    private void Start()
    {
        Create();
    }

    public void Create()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_gem, new Vector3(_spawnPoints[i].position.x, _spawnPoints[i].position.y), transform.rotation);
        }
    }
}
