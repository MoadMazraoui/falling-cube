using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float boundY = 7f;

    [SerializeField] bool isPlatform, isSpike;

    private void Update() {
        Move();
    }

    private void Move()
    {
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= boundY)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D target) {

        if(target.tag == "Player") { 

            if(isSpike) {

                target.transform.position = new Vector2(1000f, 1000f);
                SoundManager.instance.GameOverSound();
                GameManager.instance.ShowGameOverPanel();

            }

        }

    }
    void OnCollisionEnter2D(Collision2D target) {

        if(target.gameObject.tag == "Player") { 

            if(isPlatform) {
                SoundManager.instance.LandSound();
            }
        }

    }

}
