using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Mover _prefab;
    [SerializeField] private GameObject _target;

    public void Spawn()
    {
        Mover movement = Instantiate(_prefab,transform.position, Quaternion.identity);
        movement.Initialize(_target);
    }
}
