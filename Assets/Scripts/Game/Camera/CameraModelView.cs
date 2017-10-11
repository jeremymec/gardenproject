using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraModelView : MonoBehaviour, ICamera
{
    public Vector2 TransformPosition
    {
        get
        {
            return this.transform.position;
        }

        set
        {
            this.transform.SetPositionAndRotation(value, Quaternion.identity);
        }
    }

    public CameraState State
    {
        get
        {
            return this.State;
        }

        set
        {
            this.State = value;
        }
    }

    public event EventHandler<UpdateEventArgs> OnUpdate = (s, e) => { };

    void Update()
    {
        OnUpdate(this, new UpdateEventArgs());
    }
}
