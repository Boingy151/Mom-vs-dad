using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyWall : MonoBehaviour
{
    public GameObject Player;
    Rigidbody PlayerRigidbody;

    private void Start()
    {
        PlayerRigidbody = Player.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("entered");
        PlayerRigidbody.velocity = new Vector3(PlayerRigidbody.velocity.x * -1, 0, 0);
    }



}
