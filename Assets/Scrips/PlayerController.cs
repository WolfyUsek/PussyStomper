using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;

    private Rigidbody2D rb;
    private bool canJump = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Detecta toque en pantalla
        if (IsTouchingScreen() && canJump)
        {
            Jump();
        }
    }

    bool IsTouchingScreen()
    {
        // Funciona tanto en m�vil como en editor
#if UNITY_EDITOR
        return Input.GetMouseButtonDown(0);
#else
        return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
#endif
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(0, jumpForce);
        canJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Floor") && rb.linearVelocity.y <= 0)
        {
            Jump(); // rebote autom�tico
        }
    }
}

