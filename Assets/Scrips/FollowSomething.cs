using UnityEngine;

public class FollowSomething : MonoBehaviour
{
 
    [SerializeField] public Transform player;
    [SerializeField] public Player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        if (playerScript.isGrounded == true)
        {
        transform.position = new Vector2(0,player.transform.position.y+1);

        }
    }
}
