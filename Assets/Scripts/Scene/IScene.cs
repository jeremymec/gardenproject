
using System;

using UnityEngine;

public interface IScene {

    event EventHandler<SceneChangedEventArgs> OnSceneChange;

    int SceneIndex { get; set; }

}

public class SceneChangedEventArgs : EventArgs
{

    public int ReplacementSceneIndex { get; set; }

    public SceneChangedEventArgs(int index)
    {
        ReplacementSceneIndex = index;
    }

}