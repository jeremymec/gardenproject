using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICamera {

    CameraState State { get; set; }

    Vector2 TransformPosition { get; set; }

    event EventHandler<UpdateEventArgs> OnUpdate;

}

public class UpdateEventArgs : EventArgs
{

}

public enum CameraState
{
    Static,
    Following
}