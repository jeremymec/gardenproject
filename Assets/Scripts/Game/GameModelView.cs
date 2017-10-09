using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModelView : MonoBehaviour, IGame {

    SceneController sceneController;
    CharacterController characterController;

    public void InitCharacter()
    {
        characterController = new CharacterController();
        characterController.InitModelView(this.gameObject);
    }

    public void InitScene()
    {
        sceneController = new SceneController();
        sceneController.InitModelView(this.gameObject);
    }

}
