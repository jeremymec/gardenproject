using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter {

    event EventHandler<MovementEventArgs> onMove;

    void moveRidgidBody(Vector2 vect);

    float getSpeed();

    Vector2 getRBPosition();

}

public class MovementEventArgs : EventArgs
{

    public float xAxis { get; set; }
    public float yAxis { get; set; }

    public MovementEventArgs(float xAxis, float yAxis)
    {
        this.xAxis = xAxis;
        this.yAxis = yAxis;
    }

}