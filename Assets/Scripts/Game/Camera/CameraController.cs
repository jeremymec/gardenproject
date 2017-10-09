using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : Controller {

    private ICamera cameraModelView;

    void OnInit()
    {

    }

    public override void InitModelView()
    {
        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Camera") as GameObject);
        cameraModelView = gameobject.GetComponent<CameraModelView>();
        OnInit();
    }

    public override void InitModelView(GameObject parent)
    {

        GameObject gameobject = GameObject.Instantiate(Resources.Load("Prefabs/Camera") as GameObject, parent.transform);
        cameraModelView = gameobject.GetComponent<CameraModelView>();
        OnInit();
    }

}
