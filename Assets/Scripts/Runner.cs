using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameController gameController = new GameController();
        gameController.InitModelView();

    }
	
}
