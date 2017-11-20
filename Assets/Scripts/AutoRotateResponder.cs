using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class AutoRotateResponder : MonoBehaviour, IInputClickHandler, IFocusable {

    public bool selected = false;
    Color startColor;

    // Use this for initialization
    void Start()
    {
        startColor = this.GetComponent<Renderer>().material.color;
    }

    public void OnFocusEnter()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnFocusExit()
    {
        this.GetComponent<Renderer>().material.color = startColor;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (selected != true)
        {
            selected = true;
            GetComponent<TextMesh>().text = "Stop";
            GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");
            Renderer[] rend = bbox.GetComponentsInChildren<Renderer>();
            Collider[] coll = bbox.GetComponentsInChildren<Collider>();
            for (int i = 1; i < 15; i++)
            {
                Debug.Log(rend[i].name);
                rend[i].enabled = false;
                coll[i].enabled = false;
            }
            AudioClip clickOff = Resources.Load<AudioClip>("ClickOn");
            bbox.GetComponent<AudioSource>().clip = clickOff;
            bbox.GetComponent<AudioSource>().Play();
        }
        else
        {
            selected = false;
            GetComponent<TextMesh>().text = "Auto X\nRotate";
            GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");
            Renderer[] rend = bbox.GetComponentsInChildren<Renderer>();
            Collider[] coll = bbox.GetComponentsInChildren<Collider>();
            for (int i = 1; i < 15; i++)
            {
                rend[i].enabled = true;
                coll[i].enabled = true;
            }

            AudioClip clickOff = Resources.Load<AudioClip>("ClickOff");
            bbox.GetComponent<AudioSource>().clip = clickOff;
            bbox.GetComponent<AudioSource>().Play();
        }

        this.GetComponent<Renderer>().material.color = startColor;
    }

 
	
	// Update is called once per frame
	void Update () {

        if (selected == true)
        {
            GameObject selectedPrefab = GameObject.FindGameObjectWithTag("Selected");
            selectedPrefab.transform.Rotate(Vector3.up * 10 * Time.deltaTime, Space.World);
        }
       

    }
}
