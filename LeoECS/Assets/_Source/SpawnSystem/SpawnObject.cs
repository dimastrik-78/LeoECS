using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Source.SpawnSystem
{
    public class SpawnObject : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private int spawnCount;
        
        void Awake()
        {
            for (int i = 0; i < spawnCount; i++)
            {
                Instantiate(prefab,
                    new Vector3(Random.Range(-20, 20), Random.Range(-10, 10), Random.Range(-5, 5)),
                    Quaternion.Euler(0, 60, 0));
            }
        }
    }
}
