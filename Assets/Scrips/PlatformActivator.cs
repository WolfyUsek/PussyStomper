using UnityEngine;

public class PlatformActivator : MonoBehaviour
{
    public GameObject platformObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BoxCollider2D colliderBox = platformObject.GetComponent<BoxCollider2D>();

            colliderBox.enabled = true;

        }
    }
}
