using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleGrow : PowerUps
{
    
    private BoxCollider2D paddleCollider;
    private SpriteRenderer paddleSpriteRend;
    private BoxCollider2D originalCollider;
    private SpriteRenderer originalSR;
    private int powerUpTime;

    public PaddleGrow(int powerUpType, BoxCollider2D paddleCollider, SpriteRenderer paddleSpriteRend) : base(powerUpType)
    {
        this.paddleCollider = paddleCollider;
        this.paddleSpriteRend = paddleSpriteRend;
        this.originalCollider.size = paddleCollider.size;
        this.originalSR.size = paddleSpriteRend.size;
        this.powerUpTime = 10;
    }
    
    private void growPaddleCollider()
    {
        this.paddleCollider.size = new Vector2(paddleCollider.size.x * 2, paddleCollider.size.y);
    }
    
    private void growPaddleSprite()
    {
        this.paddleSpriteRend.size = new Vector2(paddleSpriteRend.size.x * 2, paddleSpriteRend.size.y);
    }

    private void shrinkBack()
    {
        this.paddleCollider.size = this.originalCollider.size;
        this.paddleSpriteRend.size = this.originalSR.size;
    }

    public void powerUpPaddle()
    {
        growPaddleCollider();
        growPaddleSprite();
        new WaitForSeconds(powerUpTime);
        shrinkBack();
    }

    public void setPaddleCollider(BoxCollider2D paddleCollider)
    {
        this.paddleCollider = paddleCollider;
        this.originalCollider.size = paddleCollider.size;
    }

    public void setPaddleSpriteRend(SpriteRenderer paddleSpriteRend)
    {
        this.paddleSpriteRend = paddleSpriteRend;
        this.originalSR.size = paddleSpriteRend.size;
    }

    
}
