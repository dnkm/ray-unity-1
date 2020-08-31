using UnityEngine;

public class playerControl : MonoBehaviour
{

  public float speed = 5f;
  public float jumpSpeed = 5f;
  private float movement = 0f;
  private bool canJump = true;
  private bool doJump = true;
  private Rigidbody2D rbody;

  /*not used  */
  public Transform groundChecker;
  public float groundCheckRadius;
  public LayerMask groundLayer;
  private bool isTouchingGround;



  // Start is called before the first frame update
  void Start()
  {
    rbody = gameObject.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    // optional
    isTouchingGround = Physics2D.OverlapCircle(groundChecker.position, groundCheckRadius, groundLayer);

    movement = Input.GetAxis("Horizontal");
    if (movement != 0)
      rbody.velocity = new Vector2(movement * speed, rbody.velocity.y);

    if (Input.GetButtonDown("Jump")) doJump = true;

    if (canJump && doJump)
    {
      rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
      canJump = doJump = false;
    }
  }
  void Update_reserve()
  {
    movement = Input.GetAxis("Horizontal");
    if (movement != 0)
      rbody.velocity = new Vector2(movement * speed, rbody.velocity.y);

    if (Input.GetButtonDown("Jump")) doJump = true;

    if (canJump && doJump)
    {
      rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
      canJump = doJump = false;
    }
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "ground") canJump = true;
  }
}
