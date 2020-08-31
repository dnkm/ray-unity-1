using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
  public float speed;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void FixedUpdate()
  {
    // float x = 0, y = 0;

    // if (Input.GetKey(KeyCode.LeftArrow)) x = -1;
    // if (Input.GetKey(KeyCode.RightArrow)) x = 1;
    // if (Input.GetKey(KeyCode.UpArrow)) y = 1;
    // if (Input.GetKey(KeyCode.DownArrow)) y = -1;

    // var pos = this.transform.position;
    // pos.x += speed * Time.deltaTime * x;
    // pos.y += speed * Time.deltaTime * y;
    // this.transform.position = pos;
  }

  private void OnCollisionEnter2D(Collision2D other) {
      // Debug.Log(other.gameObject.tag);
  }
}
