using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform platformParent; 
    public int poolSize = 10;
    private Queue<GameObject> platformPool = new Queue<GameObject>();

    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(platformPrefab, platformParent); // asignar como hijo
            obj.SetActive(false);
            platformPool.Enqueue(obj);
        }
    }

    public GameObject GetPlatform()
    {
        if (platformPool.Count > 0)
        {
            
            GameObject obj = platformPool.Dequeue();
            obj.SetActive(true);
           
            
            return obj;
        }

   
        return null;
    }

    public void ReturnPlatform(GameObject platform)
    {
        platform.SetActive(false);
        
        platform.transform.SetParent(platformParent); // asegurar jerarquía
        platformPool.Enqueue(platform);
    }
}

