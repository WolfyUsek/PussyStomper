using UnityEditor.EditorTools;
using UnityEngine;

public class PooletObject : MonoBehaviour
{
    private PoolManager poolManager;
    void Start()
    {
        poolManager = FindObjectOfType<PoolManager>();

    }

    void Update()
    {

        if (transform.position.y < -10f) // fuera de c�mara
        {
            poolManager.ReturnPlatform(this.gameObject);
        }
    }
}
