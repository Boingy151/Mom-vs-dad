using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour
{

    Rigidbody rb;
    public float speed;
    float currentSpeed;

    

    public float IncreaseLevel;
    

    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }
    // Update is called once per frame
    void Update()
    {
        currentSpeed = (1 + (GrassSpawner.time*IncreaseLevel)) * speed;
        Debug.Log(currentSpeed);
        rb.velocity = new Vector3(0, 0, -1 * currentSpeed * Time.deltaTime);

        //removes the grass
        if(transform.position.z < -1f)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //detects grass touching the player
        if (other.gameObject.tag == "Player")
        {
            //grabs the player gameobject
            GameObject playerB = GameObject.Find("Player");
            //gets the component from the player
            Movement movRefScrpt = playerB.GetComponent<Movement>();
            movRefScrpt.TouchedGrass();
            //destroys the grass after collision
            Destroy(gameObject);
        }
    }
}
