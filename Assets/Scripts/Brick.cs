using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    protected int hitPoints = 1;
    public int scoreValue = 100;
    protected AudioSource audioSource;
    public Sprite newSprite;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void OnCollisionEnter2D(Collision2D other) 
    {
        audioSource.PlayOneShot(audioSource.clip, 0.5f);
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
        else if(this.hitPoints == 1)
        {
            changeSprite();
        }
    }

    public int getScoreValue()
    {
        return this.scoreValue;
    }

    protected void changeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
