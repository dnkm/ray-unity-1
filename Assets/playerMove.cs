using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
  private Rigidbody2D rbody;
  public float speed = 5f;
  public float jumpSpeed = 5f;
  public LayerMask collisionLayer;

  // Start is called before the first frame update
  void Start()
  {
    rbody = gameObject.GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    bool touchingGround = Physics2D.OverlapCircle(transform.position, 1f, collisionLayer);
    Debug.Log(touchingGround);

    /* x-direction */
    float h = Input.GetAxis("Horizontal");      // -1 ~ 1
    if (h != 0)
      rbody.velocity = new Vector2(h * speed, rbody.velocity.y);

    /* y- direc */
    if (Input.GetButtonDown("Jump") && touchingGround)
    {
      rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
    }
  }

}
