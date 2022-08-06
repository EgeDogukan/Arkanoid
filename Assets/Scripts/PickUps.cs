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

    public PickUps(BoxCollider2D paddleCollider, SpriteRenderer paddleSpriteRend)
    {
        this.paddleCollider = paddleCollider;
        this.paddleSpriteRend = paddleSpriteRend;
    }

    public PickUps()
    {

    }

    public float[] spawnPickUp()
    {
        int randSelect = Random.Range(1, 4);
        if(randSelect == 1)
        {
            spawnX = Random.Range(Paddle.leftBorder + 1f, Paddle.leftBorder + 4.8f);
            spawnY = Random.Range(Paddle.lowerBorder - 1f, Paddle.upperBorder + 1f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 2)
        {
            spawnX = Random.Range(Paddle.rightBorder - 1f, Paddle.rightBorder - 4.8f);
            spawnY = Random.Range(Paddle.lowerBorder - 1f, Paddle.upperBorder + 1f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 3)
        {
            spawnX = Random.Range(Paddle.leftBorder, Paddle.rightBorder);
            spawnY = Random.Range(Paddle.lowerBorder + 1f, Paddle.lowerBorder + 3f);
        }
        else if(randSelect == 4)
        {
            spawnX = Random.Range(Paddle.leftBorder, Paddle.rightBorder);
            spawnY = Random.Range(Paddle.upperBorder - 3f, Paddle.upperBorder - 1f);
        }
        Debug.Log(Paddle.upperBorder);
        Debug.Log(Paddle.lowerBorder);
        Debug.Log(Paddle.rightBorder);
        Debug.Log(Paddle.leftBorder);
        float[] toReturn = {spawnX, spawnY, 0};
        return toReturn;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        new PaddleGrow(pickupType, paddleCollider, paddleSpriteRend);  
        Destroy(this.gameObject);  
    }

    public void setPaddleCollider(BoxCollider2D paddleCollider)
    {
        this.paddleCollider = paddleCollider;
    }

    public void setPaddleSpriteRend(SpriteRenderer paddleSpriteRend)
    {
        Debug.Log(this.transform.position);
        //this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.paddleSpriteRend = paddleSpriteRend;
        //float[] spawnRet = spawnPickUp();
        //this.transform.position = new Vector3(spawnRet[0], spawnRet[1], spawnRet[2]);
        //Debug.Log(spriteRenderer.isVisible);

    }
    public void setPos(float[] floats)
    {
        this.transform.position = new Vector3(floats[0], floats[1], floats[2]);
    }
}
