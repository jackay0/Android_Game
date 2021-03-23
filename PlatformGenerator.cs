using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading; 

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private Transform Platforms_too;
    // Start is called before the first frame update
    void Start()
    {
        Spawn(new Vector3(0,1));
        Spawn(new Vector3(10,1));
        
    }

    private void Spawn(Vector3 pos)
    {
        Instantiate(Platforms_too, pos,Quaternion.identity);
    }
    
    void Update()
    {
        for(int i = 20;i<100;i=i+10)
        {
           Spawn(new Vector3(i,1)); 
           Thread.Sleep(10000);
        }


    }
}
