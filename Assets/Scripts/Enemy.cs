using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _direction;

    private void OnEnable()
    {
        _direction = Random.insideUnitCircle.normalized;
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * _direction);
    }
}
