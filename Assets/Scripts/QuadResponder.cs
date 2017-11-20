using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class QuadResponder : MonoBehaviour, IFocusable, IInputClickHandler {

    Color startMat;
    // Use this for initialization
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
            bbox.GetComponent<HandDragging>().draggingEnabled = true;
            bbox.GetComponent<HandRotate>().rotatingEnabled = false;
            bbox.GetComponent<HandResize>().resizingEnabled = false;
        }
        

    }

    public void OnFocusExit()
    {
        GetComponent<Renderer>().material.color = startMat;
        //GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");
        //Destroy(bbox.GetComponent<HandDragging>());
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        GameObject selectedPrefab = GameObject.FindGameObjectWithTag("Selected");
        selectedPrefab.transform.parent = GameObject.Find("PH_" + selectedPrefab.GetComponentInChildren<TextMesh>().text).transform;
        selectedPrefab.tag = "Untagged";

        GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");
        bbox.transform.position = new Vector3(-5, 0, 0);
        
        Renderer[] rend = bbox.GetComponentsInChildren<Renderer>();
        Collider[] coll = bbox.GetComponentsInChildren<Collider>();
        foreach (var ren in rend)
        {
            ren.enabled = false;
        }
        foreach (var col in coll)
        {
            col.enabled = false;
        }

        AudioClip clickOff = Resources.Load<AudioClip>("ClickOff");
        bbox.GetComponent<AudioSource>().clip = clickOff;
        bbox.GetComponent<AudioSource>().Play();
    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
