using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PickUps : MonoBehaviour
{
    
    protected int pickupType = 1; //random
    protected Vector3 pickUpLocation;
    private float spawnY;
    private float spawnX;
    private BoxCollider2D paddleCollider;
    private SpriteRenderer paddleSpriteRend;
    public PowerUps powerUps;

    private void Start() 
    {
    }

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
            spawnX = Random.Range(Paddle.leftBorder + 2f, Paddle.leftBorder + 4f);
            spawnY = Random.Range(Paddle.lowerBorder + 3f, Paddle.upperBorder - 2f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 2)
        {
            spawnX = Random.Range(Paddle.rightBorder - 4f, Paddle.rightBorder - 2f);
            spawnY = Random.Range(Paddle.lowerBorder + 3f, Paddle.upperBorder - 2f);
            this.transform.position = new Vector3(spawnX, spawnY, 0);
        }
        else if(randSelect == 3)
        {
            spawnX = Random.Range(Paddle.leftBorder + 2f, Paddle.rightBorder - 2f);
            spawnY = Random.Range(Paddle.lowerBorder + 2f, Paddle.lowerBorder + 3f);
        }
        else if(randSelect == 4)
        {
            spawnX = Random.Range(Paddle.leftBorder + 2f, Paddle.rightBorder - 2f);
            spawnY = Random.Range(Paddle.upperBorder - 3f, Paddle.upperBorder - 2f);
        }
        float[] toReturn = {spawnX, spawnY, 0};
        return toReturn;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //PrefabUtility.InstantiatePrefab(paddleGrow);
        Instantiate(powerUps);
        PaddleGrow paddlegr  = powerUps.instantiatePaddleGrow(powerUps.getType(), this.paddleCollider, this.paddleSpriteRend);
        Destroy(this.gameObject);  
    }

    public void setPaddleCollider(BoxCollider2D paddleCollider)
    {
        this.paddleCollider = paddleCollider;
    }

    public void setPaddleSpriteRend(SpriteRenderer paddleSpriteRend)
    {
        this.paddleSpriteRend = paddleSpriteRend;
    }

    public void setPos(float[] floats)
    {
        this.transform.position = new Vector3(floats[0], floats[1], floats[2]);
    }
}
