using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGenerator : MonoBehaviour
{

    [SerializeField] private Transform stars;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    private void Spawn(Vector3 pos)
    {
        Instantiate(stars, pos,Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
      //  var playerObject = GameObject.Find("Player");
       // Vector3 playerPos = playerObject.transform.position;
        //Spawn(playerPos);
        //Debug.Log(GameObject.FindGameObjectsWithTag("Player")[0].transform.position);
    }
}
