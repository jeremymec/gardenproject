using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModelView : MonoBehaviour, IGame {

    SceneController sceneController;

    public void InitScene()
    {
        sceneController = new SceneController();
        sceneController.InitModelView(this.gameObject);
    }

}
