using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController {

    private ICharacter characterModelView;

    void OnInit()
    {
        characterModelView.onMove += HandleMove;
    }

    public void InitModelView()
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Character") as GameObject);
        characterModelView = gameobject.GetComponent<CharacterModelView>();
        OnInit();
    }

    public void InitModelView(GameObject parent)
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Character") as GameObject, parent.transform);
        characterModelView = gameobject.GetComponent<CharacterModelView>();
        OnInit();
    }

    void HandleMove(object sender, MovementEventArgs args)
    {
        Vector2 movementVector = new Vector2(args.xAxis, args.yAxis);

        if (movementVector == Vector2.zero) return;

        Vector2 changeMovement = characterModelView.getRBPosition() + movementVector * characterModelView.getSpeed() * Time.deltaTime;

        characterModelView.moveRidgidBody(changeMovement);
    }

}
