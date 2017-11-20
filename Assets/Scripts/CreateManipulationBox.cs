using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class CreateManipulationBox : MonoBehaviour, IInputClickHandler
{
    public string phName;
    public bool hasParent = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (hasParent == false)
        {
            GameObject oldSelectedObject = GameObject.FindGameObjectWithTag("Selected");
            if (oldSelectedObject != null)
            {
                oldSelectedObject.tag = "Player";
                oldSelectedObject.transform.parent = GameObject.Find("PH_" + oldSelectedObject.GetComponentInChildren<TextMesh>().text).transform;
            }
            
            transform.tag = "Selected";
            GameObject.FindGameObjectWithTag("BoundingBox").GetComponent<ManipulationBox>().prefabOfChoice = this.transform.gameObject;
        }

        if (hasParent == true)
        {
            GameObject oldSelectedObject = GameObject.FindGameObjectWithTag("Selected");
            if (oldSelectedObject != null)
            {
                oldSelectedObject.tag = "Player";
                oldSelectedObject.transform.parent = GameObject.Find("PH_" + oldSelectedObject.GetComponentInChildren<TextMesh>().text).transform;
            }
            
            transform.parent.tag = "Selected";
            GameObject.FindGameObjectWithTag("BoundingBox").GetComponent<ManipulationBox>().prefabOfChoice = this.transform.parent.gameObject;
        }



        AudioClip clickOn = Resources.Load<AudioClip>("ClickOn");
        GameObject bbox = GameObject.FindGameObjectWithTag("BoundingBox");
        bbox.GetComponent<AudioSource>().clip = clickOn;
        bbox.GetComponent<AudioSource>().Play();
    }
}
