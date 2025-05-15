using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private List<Transform> _targets = new List<Transform>();

    private Transform _currentTarget;
    private int _minTargetIndex = 0;
    private int _currentTargetIndex = 0;
    private float _minDistanceToPoint = 1f;

    private void Awake()
    {
        _currentTarget = GetTarget(_currentTargetIndex);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position,_currentTarget.position) < _minDistanceToPoint)
        {
            _currentTargetIndex++;
            _currentTarget = GetTarget(_currentTargetIndex);
        }

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget.position, _speed * Time.deltaTime);
    }

    private Transform GetTarget(int targetIndex)
    {
        if(targetIndex >= _targets.Count)
        {
            _currentTargetIndex = _minTargetIndex;
        }

        return _targets[_currentTargetIndex];
    }
}
