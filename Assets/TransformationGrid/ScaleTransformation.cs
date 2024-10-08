using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTransformation : Transformation
{
    public Vector3 scale;
    //public override Vector3 Apply(Vector3 point)
    //{
    //    point.x *= scale.x;
    //    point.y *= scale.y;
    //    point.z *= scale.z;
    //    return point;
    //}

    public override Matrix4x4 Matrix
    {
        get
        {
            Matrix4x4 matrix = new Matrix4x4();
            matrix.SetRow(0, new Vector4(scale.x, 0, 0, 0));
            matrix.SetRow(1, new Vector4(0, scale.y, 0, 0));
            matrix.SetRow(2, new Vector4(0, 0, scale.z, 0));
            matrix.SetRow(3, new Vector4(0, 0, 0, 1));
            return matrix;
        }
    }
}
