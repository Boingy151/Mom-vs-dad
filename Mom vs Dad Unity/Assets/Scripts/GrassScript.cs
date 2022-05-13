using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour
{

    Rigidbody rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    { 
        rb.velocity = new Vector3(0, 0, -1 * speed * Time.deltaTime);

        //remove
        if(transform.position.z < -1f)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //when the grass 
        if (other.gameObject.tag == "Grass")
        {
            GameObject playerB = GameObject.Find("Player");
            Movement movRefScrpt = playerB.GetComponent<Movement>();
            movRefScrpt.TouchedGrass();
        }
    }
}
