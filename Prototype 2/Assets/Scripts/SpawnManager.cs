using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float randomXpos = 14f;
    private float Zpos = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 randomPos = new Vector3(Random.Range(-randomXpos, randomXpos + 1), 0, Zpos);
        Instantiate(animalsPrefabs[animalIndex], randomPos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
