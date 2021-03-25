using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading; 

public class PlatformGenerator : MonoBehaviour
{
    int i = 20;
    int j = 0;
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
    
    private void DestroyPlatform()
    {
        

    }

    void Update()
    {
        j++;
        if(j%90==0)
        {
            Spawn(new Vector3(i,1)); 
            i=i+10;
        }
        
       

    }
}
