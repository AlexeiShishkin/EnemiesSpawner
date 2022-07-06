using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawns;

    private float _cooldown = 0;

    private void Start()
    {
        Initialize(_enemyPrefab);
    }

    private void Update()
    {
        _cooldown -= Time.deltaTime;

        if (_cooldown <= 0)
        {
            if (TryGetObject(out Enemy enemy))
            {
                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);

                _cooldown = _timeBetweenSpawns;
            }
        }
    }

    private void SetEnemy(Enemy enemy, Vector3 spawnPoint)
    {
        enemy.transform.position = spawnPoint;
        enemy.Activate();
    }
}
