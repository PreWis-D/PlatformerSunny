using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _patrolPoints;

    private int _currentPoint;

    private void Update()
    {
        Transform target = _patrolPoints[_currentPoint];

        transform.position = CalculateCurrentPosition(target);

        if (transform.position == target.position)
        {
            _currentPoint++;
            Flip();

            if (_currentPoint >= _patrolPoints.Length)
            {
                _currentPoint = 0;
            }
        }
    }

    private Vector3 CalculateCurrentPosition(Transform target)
    {
        return Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    private void Flip()
    {
        Vector3 tempValue = transform.localScale;
        tempValue.x *= -1;
        transform.localScale = tempValue;
    }
}
