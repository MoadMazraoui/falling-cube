using System;
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
        if(Input.GetAxisRaw("Horizontal") > 0f) {
            mb.velocity = new Vector2(moveSpeed, mb.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") < 0f) {
            mb.velocity = new Vector2(-moveSpeed, mb.velocity.y);
        }
    }

    public void PlatformMove(float x) {
        mb.velocity = new Vector2(x, mb.velocity.y);
    }
}
