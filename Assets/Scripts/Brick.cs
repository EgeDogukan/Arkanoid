using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    protected int hitPoints = 1;
    public int scoreValue = 100;
    protected AudioClip brickBounce;
    protected AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        brickBounce = GetComponent<AudioSource>().clip;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void OnCollisionEnter2D(Collision2D other) 
    {
        audioSource.PlayOneShot(brickBounce);
        coll();
    }

    protected void coll()
    {
        this.hitPoints--;
        if(this.hitPoints <= 0) 
        {
            ScoreSystem.addScore(this);
            Destroy(this.gameObject);
        } 
        else 
        {
            // change the visual of the brick with a more damaged one
        }
    }

    public int getScoreValue()
    {
        return this.scoreValue;
    }
}
