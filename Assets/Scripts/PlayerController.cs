using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D rb;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private bool isGrounded;
    private Animator animator;
    // private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XulyDichuyen();
        XulyNhay();
        UpdateAnimation();
    }
    private void XulyDichuyen()
    { float diChuyen=Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(diChuyen * moveSpeed, rb.linearVelocity.y);
        if (diChuyen>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (diChuyen < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void XulyNhay()
    { if(Input.GetButtonDown("Jump")&&isGrounded)
        {
           rb.linearVelocity=new Vector2(rb.linearVelocity.x,jumpForce);
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }
    private void UpdateAnimation()
    {
        bool isRunning=Mathf.Abs(rb.linearVelocity.x) > 0.1f;
        bool isJumping = !isGrounded;   
        animator.SetBool("isRunning", isRunning);   
        animator.SetBool("isJumping", isJumping);
    }


}
