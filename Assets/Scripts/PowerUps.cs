using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    protected int powerUpType;
    public Paddle paddle;

    public PowerUps(int powerUpType)
    {
        this.powerUpType = powerUpType;
    }

    public void setType(int i)
    {
        this.powerUpType = i;
    }

    public int getType()
    {
        return this.powerUpType;
    }

    public void changeSize()
    {
        if(this.powerUpType == 1)
        {
            /*Paddle.changeBoxCollider2DSize();
            Paddle.changePaddleSpriteSize();*/
            /*new WaitForSeconds(10);
            Paddle.shrinkSizeBack();*/
            paddle.changeTransformScale();
        }
    }

    /*public PaddleGrow instantiatePaddleGrow(int powerUpType, BoxCollider2D paddleCollider, SpriteRenderer paddleSpriteRend)
    {
        Instantiate(paddleGrow);
        paddleGrow.setPaddleCollider(paddleCollider);
        paddleGrow.setPaddleSpriteRend(paddleSpriteRend);
        paddleGrow.setType(powerUpType);
        return paddleGrow;
    }*/
}
