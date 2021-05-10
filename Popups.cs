using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{
    public Sprite[] array;
     void Start () 
     {
        GetComponent<SpriteRenderer>().sprite = array[2];
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
