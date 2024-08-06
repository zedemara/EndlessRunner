using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{

    public static float leftSide = -3.5f;
    public static float rightSide = 3.5f;
    public float internalleft;
    public float internalright;


    void Update()
    {
        internalleft = leftSide;
        internalright = rightSide;

    }
}
