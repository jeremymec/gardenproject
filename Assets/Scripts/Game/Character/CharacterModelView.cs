using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModelView : MonoBehaviour, ICharacter {

    public event EventHandler<MovementEventArgs> onMove = (s, e) => { };

    new Rigidbody2D rigidbody2D;

    public float speed = 1f;

    void OnAwake()
    {
        this.rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void moveRidgidBody(Vector2 vect)
    {
        rigidbody2D.MovePosition(vect);
    }

    void Update()
    {
        onMove(this, new MovementEventArgs(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
    }

    public float getSpeed()
    {
        return this.speed;
    }

    public Vector2 getRBPosition()
    {
        return this.rigidbody2D.position;
    }
}
