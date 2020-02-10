using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public AudioClip hitSound;
    public AudioSource speaker;
    public GameObject ball;
    public Rigidbody rb;

    void Start()
    {
        speaker = GetComponent<AudioSource>();
        ball = GameObject.Find("Ball");
        rb = ball.GetComponent<Rigidbody>();
    }

    // Plays audio clip on collision as well as modifies the pitch according to
    // the balls speed
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            speaker.PlayOneShot(hitSound);
            GetComponent<AudioSource>().pitch += rb.velocity.magnitude / 10;
        }
    }
}
