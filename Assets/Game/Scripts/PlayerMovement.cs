using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D mb;
    public float moveSpeed = 2f;

    private void Awake() {
        mb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2) {
                horizontalInput = -1f;
            } else if (touch.position.x > Screen.width / 2) {
                horizontalInput = 1f;
            }
        }

        mb.velocity = new Vector2(horizontalInput * moveSpeed, mb.velocity.y);
    }

    public void PlatformMove(float x) {
        mb.velocity = new Vector2(x, mb.velocity.y);
    }
}
