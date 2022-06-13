using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{

    float xCord;
    float zCord;
    public Vector2 xRange;
    public Vector2 zRange;
    public float SpawnDelayMin;
    public float SpawnDelayMax;
    float SpawnDelay;
    public GameObject Grass;
    public bool debug = false;

    public static float time;
    
    // Start is called before the first frame update
    void Start()
    {
        
        SpawnDelay = 1;
        Invoke("SpawnGrass", SpawnDelay);
        
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
        SpawnDelay = Random.Range(SpawnDelayMin, SpawnDelayMax);
        if (debug)
        {
            Debug.Log(SpawnDelay);
        }
        
      

        Instantiate(Grass, new Vector3(xCord, 0.3f, zCord), new Quaternion(0, 180, 0, 0));
        spawn();
    }
    void spawn()
    {
        Invoke("SpawnGrass", SpawnDelay);
    }

}
