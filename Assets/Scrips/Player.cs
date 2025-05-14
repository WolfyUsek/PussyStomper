using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jump,jumpForce;
    [SerializeField] public GetPoints getPoints;
    [SerializeField] public bool isGrounded, isLeft, isRight, isPushing;

    [SerializeField] float baseGravity = 2f,  maxFallSpeed =20f, fallSpeedMultiplier = 2f;

    private Vector3 lastPlatformPosition;
    private Transform currentPlatform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (currentPlatform != null)
        {
            Vector3 delta = currentPlatform.position - lastPlatformPosition;
            transform.position += delta;
            lastPlatformPosition = currentPlatform.position;
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true && isLeft == true && isRight == false )
        {
            
            rb.AddForce(new Vector2(-jump,jump)*jumpForce, ForceMode2D.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.W) && isGrounded == true && isRight == true && isLeft == false)
        {
           
            rb.AddForce(new Vector2(jump, jump) * jumpForce, ForceMode2D.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.W) && isGrounded == true && isRight == true && isLeft == true)
        {
            
            rb.AddForce(Vector3.up * jump, ForceMode2D.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.W) && isGrounded == false && isRight == false && isLeft == false)
        {
            rb.AddForce(Vector3.down * jump*2, ForceMode2D.Impulse);
        }



        if (Input.touchCount > 0 && isGrounded == true)
        {
            rb.AddForce(Vector3.up * jump,ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        if (currentPlatform != null)
        {
            Vector3 delta = currentPlatform.position - lastPlatformPosition;
            transform.position += delta;
            lastPlatformPosition = currentPlatform.position;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
           
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
           getPoints = collision.gameObject.GetComponent<GetPoints>();
            isGrounded = true;

           

            currentPlatform = collision.transform;
            lastPlatformPosition = currentPlatform.position;
        }
      
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            
            isGrounded = false;
        }
        if (collision.transform == currentPlatform)
        {
            currentPlatform = null;
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Left"))
        {
            isLeft = true;
        }
        if (collision.gameObject.CompareTag("RIght"))
        {
            isRight = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Left"))
        {
            isLeft = false;
        }
        if (collision.gameObject.CompareTag("RIght"))
        {
            isRight = false;
        }
    }
}
