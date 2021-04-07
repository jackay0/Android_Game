using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    
    //Transform transform = Camera.main.transform;
    
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public float xPos;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator anim;

    private int i;

    [SerializeField] private Transform stars;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        xPos = rigidbody2d.position.x;
    }

    private void Spawn(Vector3 pos)
    {
        Instantiate(stars, pos,Quaternion.identity);
    }
   
    // Update is called once per frame
    void Update()
    {
        i++;
        float jumpVelocity = 0f;
        rigidbody2d.velocity = new Vector2(9.7f,rigidbody2d.velocity.y);
        
        if(i%30==0){
        Spawn(rigidbody2d.position);
        }
        
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, groundLayer);
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            
            if(raycastHit2d && (touch.phase == TouchPhase.Began))
            {
                
                
                
                LayerMask x = LayerMask.GetMask("green");
                LayerMask y = LayerMask.GetMask("yellow");
                LayerMask z = LayerMask.GetMask("red");


                

                if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, x)){
                    ScoreScript.scoreValue += 1;
                    GetComponent<AudioSource>().Play();
                    jumpVelocity = 50f;
                    anim.SetBool("isJumping",true);
                }
                else if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, y)){
                    ScoreScript.scoreValue += 1;
                    GetComponent<AudioSource>().Play();
                    jumpVelocity = 25f;
                    anim.SetBool("isJumping",true);
                }
                else if(Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, z)){
                    ScoreScript.scoreValue += 1;
                    GetComponent<AudioSource>().Play();
                    jumpVelocity = 11f;
                    anim.SetBool("isJumping",true);
                }
                 
                
                
                rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x,jumpVelocity);
                
            
            }
            
               
                
            
        }
        else{

            anim.SetBool("isJumping",false);
        }

        if(rigidbody2d.position.y<-4.5f)
        {
            RestartGame();
        }
    }
    
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }


    

   
}
