using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 input;
    private bool isfacingRight = true;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        processInput();
        Flip();
        animator.SetFloat("speed", input.magnitude);
    }

    void processInput()
    {
        float xinput = Input.GetAxisRaw("Horizontal");
        float yinput = Input.GetAxisRaw("Vertical");
        input = new Vector2(xinput, yinput).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
    }

    void Flip()
    {
        if (isfacingRight && input.x < 0 || !isfacingRight && input.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            isfacingRight = !isfacingRight;
        }
    }
}
