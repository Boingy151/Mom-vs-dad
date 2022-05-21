using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    GameObject Player;
    Rigidbody rb;
    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody>();
        Invoke("Rotate", 1);
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = transform.forward * speed * Time.deltaTime;
    }

    void Rotate()
    {
        transform.LookAt(Player.transform);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PointScript.numOfPoints--;
            Destroy(gameObject);
        }
    }

}
