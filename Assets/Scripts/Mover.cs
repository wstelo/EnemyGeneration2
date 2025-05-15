using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 10;
    private GameObject _target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position ,_target.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(GameObject target)
    {
        _target = target;
    }
}
