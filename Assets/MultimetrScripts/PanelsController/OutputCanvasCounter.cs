using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputCanvasCounter : MonoBehaviour
{
    public static GameObject outputTextCanvas;

    public void Awake()
    {
        outputTextCanvas = gameObject.transform.GetChild(0).gameObject;
    }
}
