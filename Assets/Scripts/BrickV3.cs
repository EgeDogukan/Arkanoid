using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;


public class BrickV3 : Brick
{

    public AudioSource[] soundss;
    public AudioSource sound1;
    public AudioSource sound2;

    // Start is called before the first frame update
    void Start()
    {
        soundss = GetComponentsInParent<AudioSource>();
        sound1 = soundss[0];
        sound2 = soundss[1];
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        loadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadData()
    {
        this.hitPoints = 3;
        this.scoreValue = 300;
    }

    new private void OnCollisionEnter2D(Collision2D other) 
    {
        if(this.hitPoints > 1)
        {
            sound2.PlayOneShot(sound2.clip, 0.5f);
        }
        else
        {
            sound1.PlayOneShot(sound1.clip, 0.5f);
            CameraShaker.Instance.ShakeOnce(BallMove.GetRigidbody2DVel(), 4f, .1f, 1f);
        }
        base.coll();
    }
}
