using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private enum state {idle, running }
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    
    private void Update()
    
    {
        float hDirection = Input.GetAxis ("Horizontal");

        if (hDirection < 0)
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            transform.localScale = new Vector2(-1,1);
            anim.SetBool("running", true);
        }
        else if(hDirection > 0)
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            transform.localScale = new Vector2(1,1);
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }

    }





}
