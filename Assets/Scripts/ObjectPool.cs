﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private List<Enemy> _pool = new List<Enemy>();

    protected void Initialize(Enemy prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            Enemy spawned = Instantiate(prefab, _container.transform);
            spawned.Deactivate();

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out Enemy result)
    {
        result = _pool.FirstOrDefault(p => p.IsActive == false);

        return result != null;
    }
}
