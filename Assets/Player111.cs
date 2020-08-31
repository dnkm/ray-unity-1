using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player111 : MonoBehaviour
{
    private int pt = 0;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "item") {
            Destroy(other.gameObject);
            pt++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "enemy")
            pt--;
    }
}
