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
}
