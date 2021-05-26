using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject leftTile,forwardTile;
    public GameObject currentTile;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTile()
    {

       currentTile=(GameObject) Instantiate(forwardTile, currentTile.transform.GetChild(0).position, Quaternion.identity);
    }
}
