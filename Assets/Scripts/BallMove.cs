using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

    private float randVal;

    private Rigidbody2D rigidBody;

    int seconds = 0;

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
        rigidBody.AddForce(new Vector3(9.8f * 20f * randVal, 9.8f * 25f, 0));
        StartCoroutine(timer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator timer()
    {
        while(true)
        {
            secondsCount();
            ScoreSystem.addScoreTime(seconds / 5);
            yield return new WaitForSecondsRealtime(3);
        }
    }

    void secondsCount()
    {
        seconds++;
    }
}
