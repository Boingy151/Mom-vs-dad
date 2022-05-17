using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{

    float xCord;
    float zCord;
    public Vector2 xRange;
    public Vector2 zRange;
    float SpawnDelay;
    public GameObject Grass;

    public static float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
        SpawnDelay = 1;
        InvokeRepeating("SpawnGrass", SpawnDelay, SpawnDelay);
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        
    }

    void SpawnGrass()
    {
        xCord = Random.Range(xRange.x, xRange.y);
        zCord = Random.Range(zRange.x, zRange.y);
        SpawnDelay = Random.Range(0.5f, 2f);
        
      

        Instantiate(Grass, new Vector3(xCord, 0.3f, zCord), new Quaternion(0, 0, 0, 0));
    }
}
