using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickV2 : Brick
{

    public AudioSource[] sounds;
    public AudioSource sound1;
    public AudioSource sound2;

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponentsInParent<AudioSource>();
        sound1 = sounds[0];
        sound2 = sounds[1];
        loadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadData()
    {
        this.hitPoints = 2;
        this.scoreValue = 200;
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
        }
        base.coll();
    }
}
