using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickV2 : Brick
{

    // Start is called before the first frame update
    void Start()
    {
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
}
