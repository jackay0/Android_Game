using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    
    //Transform transform = Camera.main.transform;
    
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float jumpVelocity = 0f;
        rigidbody2d.velocity = new Vector2(10.0f,rigidbody2d.velocity.y);

        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, groundLayer);
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            
            if(raycastHit2d && touch.phase == TouchPhase.Began)
            {
                
                
                
                LayerMask x = LayerMask.GetMask("green");
                LayerMask y = LayerMask.GetMask("yellow");
                LayerMask z = LayerMask.GetMask("red");


                

                if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, x)){
                    jumpVelocity = 20f;
                    anim.SetBool("isJumping",true);
                }
                else if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, y)){
                    jumpVelocity = 15f;
                    anim.SetBool("isJumping",true);
                }
                else if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, z)){
                    jumpVelocity = 10f;
                    anim.SetBool("isJumping",true);
                }
                 
                
                
                rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x,jumpVelocity);
                
            
            }
            
               
                
            
        }
        else{

            anim.SetBool("isJumping",false);
        }
    
    }
    
    

   
}
