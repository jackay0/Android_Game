using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //private Player_Base playerbase;
    private Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        //playerBase = gameObject.GetComponent<Player_Base>();
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                float jumpVelocity = 4f;
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
            }
            if(touch.phase == TouchPhase.Moved)
            {

            }
        }
    }
}
