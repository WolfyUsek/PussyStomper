using UnityEngine;

public class PlatformActivator : MonoBehaviour
{
    public GameObject platformObject, left, right;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BoxCollider2D colliderBox = platformObject.GetComponent<BoxCollider2D>();
            BoxCollider2D leftBox = left.GetComponent<BoxCollider2D>();
            BoxCollider2D rightBox = right.GetComponent<BoxCollider2D>();

            colliderBox.enabled = true;
            leftBox.enabled = true;
            rightBox.enabled = true;
            
        }
    }
}
