using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D coll) 
     {
     Destroy (coll.gameObject);
     }
    // Update is called once per frame
    void Update()
    {
        
        rigidbody2d.velocity = new Vector2(9.8f,0f);
    }

    

}
