using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _direction;

    private void OnEnable()
    {
        _direction = Random.insideUnitCircle.normalized;
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _direction);
    }
}
