using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Variables")]
    [SerializeField] private float maxTimeBeforeSpawn = 1.5f;
    [SerializeField] private float currentTimeBeforeSpawn = 0;
    [SerializeField] private float timeBeforeDestroying = 5f;
    [SerializeField] private float pipeHeight = 1.0f;
    [Header("Game Object")]
    public GameObject dripstonePrefab;

    private void FixedUpdate()
    {
        SpawnDripstone();
    }

    private void SpawnDripstone()
    {
        if (currentTimeBeforeSpawn > maxTimeBeforeSpawn)
        {
            GameObject newDripstonePrefab = Instantiate(dripstonePrefab);
            newDripstonePrefab.transform.position = transform.position + new Vector3(0, Random.Range(-pipeHeight, pipeHeight), 0);
            Destroy(newDripstonePrefab, timeBeforeDestroying);
            currentTimeBeforeSpawn = 0;
        }
        currentTimeBeforeSpawn += Time.deltaTime;
    }
}