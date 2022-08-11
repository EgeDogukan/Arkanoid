using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    public float projectileSpeed = 150f;
    public float forceApplied = 300f;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position += transform.up * Time.deltaTime * projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            other.rigidbody.velocity += -other.rigidbody.velocity;
        }
        Destroy(gameObject);
    }
}