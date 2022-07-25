using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    protected int hitPoints = 1;
    public int scoreValue = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnCollisionEnter2D(Collision2D other) 
    {
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
