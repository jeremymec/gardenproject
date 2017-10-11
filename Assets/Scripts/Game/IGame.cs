using System;

using UnityEngine;

public interface IGame {

    CameraController CameraController { get; set; }
    CharacterController CharacterController { get; set; }
    SceneController SceneController { get; set; }

    void InitCamera(GameController gameController);
    void InitCharacter(GameController gameController);
    void InitScene(GameController gameController);

}