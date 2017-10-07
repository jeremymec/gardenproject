using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneModelView : MonoBehaviour, IScene {

    public int SceneIndex
    {
        get
        {
            return SceneIndex;
        }

        set
        {
            SceneIndex = value;
        }
    }

    public event EventHandler<SceneChangedEventArgs> OnSceneChange;

}
