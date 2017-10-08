using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneModelView : MonoBehaviour, IScene {

    int SceneIndex;

    public int getSceneIndex()
    {
        return SceneIndex;
    }

    public void changeScene(int index)
    {
        this.SceneIndex = index;
        // CHANGE SCENE
    }

}
