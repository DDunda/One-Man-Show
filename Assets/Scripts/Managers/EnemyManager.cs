using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stores the prefab and its associated parent
[System.Serializable]
public struct EnemyPrefabType
{
    public GameObject prefab;
    public Transform parent;
}

public class EnemyManager : MonoBehaviour
{
    //[SerializeField] List<EnemySpawner> _enemySpawns;

    // Enemy prefabs to pool
    [SerializeField] List<EnemyPrefabType> _enemyPrefabs;

    // Maximum number of enemies per pool
    [SerializeField] uint _maxNumToPool;

    // Enemy pool lists for all prefabs
    List<List<GameObject>> _typeEnemyList;

    private bool _debugTestSpawn = true;

    private void Start()
    {
        _typeEnemyList = new List<List<GameObject>>();
        InitEnemyPools();
    }

    // Create enemy pools
    void InitEnemyPools()
    {
        foreach (EnemyPrefabType ept in _enemyPrefabs)
		{
            _typeEnemyList.Add(ObjectPooler.CreateObjectPool(_maxNumToPool, ept.prefab, ept.parent));
		}
    }

	// TESTING ONLY: DELETE WHEN DONE
	private void Update()
	{
        if (_debugTestSpawn)
        {
            TestSpawn();
            _debugTestSpawn = false;
        }
    }

	// spawn an enemy, just to test that it works
	public void TestSpawn()
    {
        GameObject newEnemy = ObjectPooler.GetPooledObject(_typeEnemyList[0]);
        newEnemy.GetComponent<Enemy>().Initialise(StageDirection.LEFT, 4);
        newEnemy.SetActive(true);
    }
}
