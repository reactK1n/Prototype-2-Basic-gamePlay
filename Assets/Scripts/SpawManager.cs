using UnityEngine;

public class SpawManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	public float spawRangeX = 20.0f;
	public float spawPositionZ = 0.0f;
	public float startDelay = 2;
	public float spawnInterval = 1.5f;
	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void SpawnRandomAnimal()
	{
		Vector3 spawPos = new Vector3(Random.Range(-spawRangeX, spawRangeX), 0, spawPositionZ);
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Instantiate(animalPrefabs[animalIndex], spawPos, animalPrefabs[animalIndex].transform.rotation);
	}
}
