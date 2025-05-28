using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] Transform objectA, objectB, movingPlatform;
    [SerializeField] float speed;
    [SerializeField] Vector3 nextPosition;

    void Start()
    {
        nextPosition = objectB.localPosition;
    }

    void Update()
    {
        nextPosition.y = transform.localPosition.y; // mantener altura actual
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPosition, speed * Time.deltaTime);

        if (transform.localPosition == nextPosition)
        {
            nextPosition = (nextPosition == objectA.localPosition) ? objectB.localPosition : objectA.localPosition;
        }
    }
}

