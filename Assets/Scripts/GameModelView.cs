using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModelView : MonoBehaviour, IGame {

    public SceneController sceneController
    {
        get
        {
            return sceneController;
        }

        set
        {
            sceneController = value;
        }
    }

}
