using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    
    protected int pickupType = 1; //random
    protected Vector3 pickUpLocation;
    private float spawnY;
    private float spawnX;
    private BoxCollider2D paddleCollider;
    private SpriteRenderer paddleSpriteRend;

    public PickUps(Vector3 pickUpLocation, BoxCollider2D paddleCollider, SpriteRenderer paddleSpriteRend)
    {
        this.pickUpLocation = pickUpLocation;
        this.transform.position = this.pickUpLocation;
        this.paddleCollider = paddleCollider;
        this.paddleSpriteRend = paddleSpriteRend;
    }

    private void spawnPickUp()
    {
        int randSelect = Random.Range(1, 4);
        if(randSelect == 1)
        {
            spawnX = Random.Range(Paddle.leftBorder, Paddle.leftBorder + 4.8f);
            spawnY = Random.Range(Paddle.lowerBorder + 0.2f, Paddle.upperBorder - 0.2f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 2)
        {
            spawnX = Random.Range(Paddle.rightBorder, Paddle.rightBorder - 4.2f);
            spawnY = Random.Range(Paddle.lowerBorder + 0.2f, Paddle.upperBorder - 0.2f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 3)
        {
            spawnX = Random.Range(Paddle.leftBorder, Paddle.rightBorder);
            spawnY = Random.Range(Paddle.lowerBorder + 0.2f, Paddle.lowerBorder + 3.8f);
        }
        else if(randSelect == 4)
        {
            spawnX = Random.Range(Paddle.leftBorder, Paddle.rightBorder);
            spawnY = Random.Range(Paddle.upperBorder - 3.8f, Paddle.upperBorder - 0.2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        spawnPickUp();
        new PaddleGrow(pickupType, paddleCollider, paddleSpriteRend);  
        Destroy(this.gameObject);  
    }
}
