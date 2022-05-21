using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerBug : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float currentSpeed;

    public Transform[] barrel;
    public GameObject Bullet;
    public float ShootDelay;
    bool canShoot = true;



    public float IncreaseLevel;


    private void Start()
    {

        rb = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        currentSpeed = (1 + (GrassSpawner.time * IncreaseLevel)) * speed;
        //Debug.Log(currentSpeed);
        rb.velocity = new Vector3(0, 0, -1 * currentSpeed * Time.deltaTime);

        //removes the grass
        if (transform.position.z < -5f)
        {
            Destroy(gameObject);
           
        }

        if (canShoot)
        {
            canShoot = false;
            StartCoroutine(Shoot());

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //detects grass touching the player
        if (other.gameObject.tag == "Player")
        {
            //grabs the player gameobject
            GameObject playerB = other.gameObject;
            //gets the component from the player
            Movement movRefScrpt = playerB.GetComponent<Movement>();
            movRefScrpt.TouchedBug();
            //destroys the grass after collision
            Destroy(gameObject);

        }
    }

    public IEnumerator Shoot()
    {
        Instantiate(Bullet, barrel[0].position, barrel[0].rotation);
        Instantiate(Bullet, barrel[1].position, barrel[1].rotation);
        Debug.Log("Done");
        yield return new WaitForSeconds(ShootDelay);
        canShoot = true;

       
    }
}
