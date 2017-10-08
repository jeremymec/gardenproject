using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController {

    private IScene sceneModelView;

    void OnInit()
    {
        sceneModelView.changeScene(sceneModelView.getSceneIndex());
    }

    public void InitModelView()
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Scene") as GameObject);
        sceneModelView = gameobject.GetComponent<SceneModelView>();
        OnInit();
    }

    public void InitModelView(GameObject parent)
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Scene") as GameObject, parent.transform);
        sceneModelView = gameobject.GetComponent<SceneModelView>();
        OnInit();
    }
}
