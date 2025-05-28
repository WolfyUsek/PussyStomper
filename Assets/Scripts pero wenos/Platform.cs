using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
    private float stompDistance = 4.1f;
    public Transform worldContainer;
    public float moveSpeed = 2f;
    
    [SerializeField] bool hasGivenPoint = false;
   
    void OnEnable()
    {
        BoxCollider2D colliderBox = gameObject.GetComponent<BoxCollider2D>();
        colliderBox.enabled = false;
        hasGivenPoint = false; 
       
    }
  

    IEnumerator MoveWorldDown()
    {
        float duration = 0.2f;
        float elapsed = 0f;
        Vector3 start = worldContainer.position;
        Vector3 end = start - new Vector3(0f, stompDistance, 0f);

        while (elapsed < duration)
        {
            worldContainer.position = Vector3.Lerp(start, end, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        worldContainer.position = end;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasGivenPoint)
        {
            
            
                hasGivenPoint = true;
                ScoreManager.Instance.AddPoint();
                StartCoroutine(MoveWorldDown());
            
        }
    }
}
