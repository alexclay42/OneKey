using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Animator animator;
    Rigidbody2D rigidbody2D;
    Vector2 movedirection = new Vector2(1, 0);

        
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, 0f);
        animator = GetComponent<Animator>();
        Vector2 position = rigidbody2D.position;



        if (!Mathf.Approximately(move.x, 0f))
        {
            movedirection.Set(move.x, 0f);
            animator.SetFloat("MoveX", movedirection.x);

        }
        else
        {
            animator.SetFloat("MoveX", 0f);
        }

        position = position + move * 3f * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }
}
