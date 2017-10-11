using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController {

    private IGame gameModelView;

    public void OnInit()
    {
        createScene();
        createCharacter();
        createCamera();
    }

    void createScene()
    {
        gameModelView.InitScene(this);
    }

    void createCharacter()
    {
        gameModelView.InitCharacter(this);
    }

    void createCamera()
    {
        gameModelView.InitCamera(this);
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

    public CameraController GetCameraController()
    {
        return this.gameModelView.CameraController;
    }

    public CharacterController GetCharacterController()
    {
        return this.gameModelView.CharacterController;
    }

    public SceneController GetSceneController()
    {
        return this.gameModelView.SceneController;
    }
}
