using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;

    void Start()
    {
        ball = GameObject.Find("Ball");
        rb = ball.GetComponent<Rigidbody>();
    }
    // Power up makes ball speed slow down.
    // Power down makes ball scale down to a smaller size.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball" && this.gameObject.name == "PowerUp")
        {
            rb.velocity *= 0.4f;
            Destroy(this);
            Destroy(GetComponent<MeshRenderer>());
        }

        if (other.gameObject.name == "Ball" && this.gameObject.name == "PowerDown")
        {
            ball.transform.localScale *= 0.4f;
            Destroy(this);
            Destroy(GetComponent<MeshRenderer>());
        }

    }
}
