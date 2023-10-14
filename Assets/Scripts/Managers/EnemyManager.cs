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
	// Enemy prefabs to pool
	[SerializeField] List<EnemyPrefabType> _enemyPrefabs;

	// Maximum number of enemies per pool
	[SerializeField] uint _maxNumToPool;

	// Enemy pool lists for all prefabs
	List<List<GameObject>> _typeEnemyList;

	public Dictionary<StageDirection, uint> _awaitingInput = new Dictionary<StageDirection, uint>();

	// List of spawn locations
	public Vector3 leftStartPosition;
	public Vector3 leftEndPosition;
	public Vector3 forwardStartPosition;
	public Vector3 forwardEndPosition;
	public Vector3 rightStartPosition;
	public Vector3 rightEndPosition;

	// Track current beat number
	private float _currentBeat;

	// If true, spawn all enemies in tutorial mode
	[SerializeField] private bool _tutorialMode = false;

	private void Awake()
	{
		_awaitingInput[StageDirection.LEFT   ] = 0;
		_awaitingInput[StageDirection.RIGHT  ] = 0;
		_awaitingInput[StageDirection.FORWARD] = 0;
	}

	private void OnEnable()
	{
		EventManager.EventSubscribe(EventType.BEAT, BeatHandler);
		EventManager.EventSubscribe(EventType.SPAWN, SpawnHandler);
		EventManager.EventSubscribe(EventType.PARRY_INPUT, ParryHandler);
	}

	private void OnDisable()
	{
		EventManager.EventUnsubscribe(EventType.BEAT, BeatHandler);
		EventManager.EventUnsubscribe(EventType.SPAWN, SpawnHandler);
		EventManager.EventUnsubscribe(EventType.PARRY_INPUT, ParryHandler);
	}

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
			List<GameObject> enemies = ObjectPooler.CreateObjectPool(_maxNumToPool, ept.prefab, ept.parent);

			foreach (GameObject enemy in enemies)
			{
				enemy.GetComponent<Enemy>().manager = this;
			}

			_typeEnemyList.Add(enemies);
		}
	}

	// Update current beat
	public void BeatHandler(object data)
	{
		_currentBeat = (float)data;
	}

	public void ParryHandler(object data)
	{
		if (data == null) return;

		StageDirection dir = (StageDirection)data;

		if (_awaitingInput[dir] == 0)
		{
			EventManager.EventTrigger(EventType.PARRY_MISS, data);
		}
		else
		{
			_awaitingInput[dir]--;
		}
	}

	// Spawns an enemy from a type index and direction
	public void SpawnHandler(object data)
	{
		SpawnData spawnData = (SpawnData)data;

		if (spawnData == null)
		{
			Debug.Log($"Attempted to spawn null data!");
			return;
		}

		// Invalid type ID
		if ((int)spawnData.Type < 0 || (int)spawnData.Type >= _typeEnemyList.Count)
		{
			Debug.Log($"Attempted to spawn enemy with invalid ID! ({spawnData.Type})");
			return;
		}

		GameObject newEnemy = ObjectPooler.GetPooledObject(_typeEnemyList[(int)spawnData.Type]);

		// No more enemies in pool
		if (newEnemy == null)
		{
			Debug.Log($"Attempted to spawn enemy but pool was empty! ({spawnData.Type})");
			return;
		}

		Vector3 start = Vector3.zero;
		Vector3 end = Vector3.zero;

		switch (spawnData.Direction)
		{
			case StageDirection.LEFT:
				start = leftStartPosition;
				end = leftEndPosition;
				break;
			case StageDirection.FORWARD:
				start = forwardStartPosition;
				end = forwardEndPosition;
				break;
			case StageDirection.RIGHT:
				start = rightStartPosition;
				end = rightEndPosition;
				break;
		}

		newEnemy.GetComponent<Enemy>().Initialise(spawnData.Direction, spawnData.Beat, start, end, _tutorialMode);

		Debug.Log($"Spawned enemy {spawnData.Type} starting beat {spawnData.Beat} on beat {Conductor.RawSongBeat} from {spawnData.Direction}");
	}
}
