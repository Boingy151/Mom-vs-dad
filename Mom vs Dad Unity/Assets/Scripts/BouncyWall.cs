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
    private void OnTriggerEnter(Collider walls)
    {
        PlayerRigidbody.velocity = new Vector3(PlayerRigidbody.velocity.x * -0.8f, 0, 0);

    }
    private void OnTriggerStay(Collider walls)
    {
        //Makes it so the ball never goes past the bouncy ball.. i mean walls
        if (PlayerRigidbody.position.x > 3)
        {
            Player.transform.Translate(-0.1f, 0, 0);
        }
        else if (PlayerRigidbody.position.x < -3)
        {
            Player.transform.Translate(0.1f, 0, 0);
        }
    }


}
