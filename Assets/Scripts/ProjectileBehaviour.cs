using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    public float projectileSpeed = 150f;
    public float forceApplied = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Bricks"))
        {
            other.rigidbody.velocity = -other.rigidbody.velocity;
        }
        Destroy(gameObject);
    }
}
