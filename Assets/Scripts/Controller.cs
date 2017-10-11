using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller {

    GameController overlord;

    public Controller(GameController gc)
    {
        this.overlord = gc;
    }

    public abstract void InitModelView();

    public abstract void InitModelView(GameObject parent);

    void OnInit()
    {
        // Default is to do nothing
    }

}
