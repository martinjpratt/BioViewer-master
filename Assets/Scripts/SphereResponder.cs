using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class SphereResponder : MonoBehaviour, IFocusable {

    Color startMat;
    void Start()
    {
        startMat = GetComponent<Renderer>().material.color;
    }

    public void OnFocusEnter()
    {
        GetComponent<Renderer>().material.color = new Color(startMat.r, startMat.g / 2, 0, startMat.a);

        GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");

        if (bbox.GetComponent<ManipulationBox>().manipulationInProgress != true)
        {
            bbox.GetComponent<HandDragging>().draggingEnabled = false;
            bbox.GetComponent<HandRotate>().rotatingEnabled = true;
            bbox.GetComponent<HandResize>().resizingEnabled = false;
        }

    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material.color = startMat;
    }
}
