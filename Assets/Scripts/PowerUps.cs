using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    protected int powerUpType;

    public PowerUps(int powerUpType)
    {
        this.powerUpType = powerUpType;
    }
}
