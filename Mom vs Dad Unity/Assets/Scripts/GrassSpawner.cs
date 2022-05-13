using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{

    float xCord;
    float zCord;
    public Vector2 xRange;
    public Vector2 zRange;
    public float SpawnDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGrass", SpawnDelay, SpawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGrass()
    {
        xCord = Random.Range(xRange.x, xRange.y);
        zCord = Random.Range(zRange.x, zRange.y);
        Debug.Log(xCord);
        Debug.Log(zCord);
    }
}
