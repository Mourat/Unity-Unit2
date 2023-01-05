using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var animalIndex = Random.Range(0, animalPrefabs.Length);
            var spawnPos = new Vector3(Random.Range(-12, 13), 0, 20);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
