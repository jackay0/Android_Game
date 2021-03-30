using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformGenerator : MonoBehaviour
{
    int i = 20;
    int j = 0;
    //static System.Random r = new System.Random();
    //int space = r.Next(1,3);
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
        if(j%60==0)
        {
            Spawn(new Vector3(i+(Random.Range(0,2)*10),1)); 
            i=i+10;
        }
        
       

    }
}
