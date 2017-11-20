using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HandDragging : MonoBehaviour, IManipulationHandler
{
    [SerializeField]
    float DragSpeed = 3f;

    [SerializeField]
    float DragScale = 5f;

    [SerializeField]
    float MaxDragDistance = 10f;
        
    Vector3 lastPosition;

    [SerializeField]
    public bool draggingEnabled = true;
    public void SetDragging(bool enabled)
    {
        draggingEnabled = enabled;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        InputManager.Instance.PushModalInputHandler(gameObject);
        lastPosition = transform.position;
        GetComponent<ManipulationBox>().manipulationInProgress = true;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (draggingEnabled)
        {         
            Drag(eventData.CumulativeDelta);
            
            //sharing & messaging
            //SharingMessages.Instance.SendDragging(Id, eventData.CumulativeDelta);
        }
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();
        GetComponent<ManipulationBox>().manipulationInProgress = false;
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();
    }

    void Drag(Vector3 positon)
    {
        var targetPosition = lastPosition + positon * DragScale;
        if (Vector3.Distance(lastPosition, targetPosition) <= MaxDragDistance)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, DragSpeed);
        }
    }
}
