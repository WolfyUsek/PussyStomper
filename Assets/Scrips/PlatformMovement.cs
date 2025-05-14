using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] Transform objectA, objectB,movingPlatform;
    [SerializeField] float speed;
    [SerializeField] Vector3 nextPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextPosition = objectB.position;   
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position,nextPosition,speed*Time.deltaTime);
        if(transform.position == nextPosition)
        {
            nextPosition= (nextPosition== objectA.position) ? objectB.position : objectA.position;
        }
    }
    

}
