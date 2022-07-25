using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    private float randVal;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        randVal = Random.value;
        if(randVal > 0.5f) 
        {
            randVal = -1;
        }
        else
        {
            randVal = 1;
        }

        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddForce(new Vector3(9.8f * UnityEngine.Random.Range(20f,40f) * randVal, 9.8f * 25f, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
