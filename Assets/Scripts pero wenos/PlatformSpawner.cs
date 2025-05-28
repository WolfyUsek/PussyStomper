using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public PoolManager poolManager;
    public float spawnInterval = 1.5f;
    public float verticalSpacing = 3f;
    public float minX = -2f, maxX = 2f;

    public float nextY = 0f;

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 0f, spawnInterval);
    }

    void SpawnPlatform()
    {
        GameObject platform = poolManager.GetPlatform();
        if (platform == null) return; // Nada disponible, no hacer nada

        float randomX = Random.Range(minX, maxX);
        platform.transform.localPosition = new Vector3(randomX, nextY, 0f);
        nextY += verticalSpacing;
    }

}

