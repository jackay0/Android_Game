using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    [SerializeField] private Transform star;
    int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Spawn(Vector3 pos)
    {
        Instantiate(star, pos,Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
       
        Spawn(new Vector3(i+(Random.Range(0,5)),(Random.Range(-12,-5)))); 
        Spawn(new Vector3(i+(Random.Range(0,5)),(Random.Range(-3,24)))); 
        Spawn(new Vector3(i+(Random.Range(0,5)),(Random.Range(-12,-5)))); 
        i=i+Random.Range(0,10);
        
        
    }
}
