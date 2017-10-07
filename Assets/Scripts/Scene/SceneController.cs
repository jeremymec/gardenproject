using UnityEngine.SceneManagement;

public class SceneController {

    private readonly IScene sceneModelView;

    public SceneController(IScene modelView)
    {
        this.sceneModelView = modelView;

        sceneModelView.OnSceneChange += HandleSceneChange;
    }

    private void HandleSceneChange(object sender, SceneChangedEventArgs e)
    {
        SceneManager.LoadScene(e.ReplacementSceneIndex);
    }

}
