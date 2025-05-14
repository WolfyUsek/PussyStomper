using TMPro;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    [SerializeField] public int point;
  
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            point=1;
            GetPoints me  = gameObject.GetComponent<GetPoints>();
            me.enabled = false;
        }
    }
}
