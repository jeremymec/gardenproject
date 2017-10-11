using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Controller {

    private IScene sceneModelView;

    public SceneController(GameController gameController) : base(gameController)
    {

    }

    void OnInit()
    {
        sceneModelView.changeScene(sceneModelView.getSceneIndex());
    }

    public override void InitModelView()
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Scene") as GameObject);
        sceneModelView = gameobject.GetComponent<SceneModelView>();
        OnInit();
    }

    public override void InitModelView(GameObject parent)
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Scene") as GameObject, parent.transform);
        sceneModelView = gameobject.GetComponent<SceneModelView>();
        OnInit();
    }
}
