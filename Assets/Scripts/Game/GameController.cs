using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController {

    private IGame gameModelView;

    public void OnInit()
    {
        createScene();
        createCharacter();
    }

    void createScene()
    {
        gameModelView.InitScene();
    }

    void createCharacter()
    {
        gameModelView.InitCharacter();
    }

    public void InitModelView()
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Game") as GameObject);
        gameModelView = gameobject.GetComponent<GameModelView>();
        OnInit();
    }

    public void InitModelView(GameObject parent)
    {

        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Game") as GameObject, parent.transform);
        gameModelView = gameobject.GetComponent<GameModelView>();
        OnInit();
    }
}
