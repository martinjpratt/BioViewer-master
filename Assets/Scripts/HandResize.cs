using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class HandResize : MonoBehaviour, IManipulationHandler
{
    [Tooltip("Speed at which the object is resized.")]
    [SerializeField]
    float ResizeSpeedFactor = 1.5f;

    [SerializeField]
    float ResizeScaleFactor = 1.5f;

    [Tooltip("When warp is checked, we allow resizing of all three scale axes - otherwise we scale each axis by the same amount.")]
    [SerializeField]
    bool AllowResizeWarp = false;

    [Tooltip("Minimum resize scale allowed.")]
    [SerializeField]
    float MinScale = 0.1f;

    [Tooltip("Maximum resize scale allowed.")]
    [SerializeField]
    float MaxScale = 10f;

    [SerializeField]
    public bool resizingEnabled = true;

    Vector3 lastScale;

    public void SetResizing(bool enabled)
    {
        resizingEnabled = enabled;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        InputManager.Instance.PushModalInputHandler(gameObject);
        lastScale = GameObject.FindGameObjectWithTag("Selected").transform.localScale;
        GetComponent<ManipulationBox>().manipulationInProgress = true;
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (resizingEnabled)
        {
            Resize(eventData.CumulativeDelta);

            //sharing & messaging
            //SharingMessages.Instance.SendResizing(Id, eventData.CumulativeDelta);
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
    void Resize(Vector3 newScale)
    {
        float resizeX, resizeY, resizeZ;
        //if we are warping, honor axis delta, else take the x
        if (AllowResizeWarp)
        {
            resizeX = newScale.x * ResizeScaleFactor;
            resizeY = newScale.y * ResizeScaleFactor;
            resizeZ = newScale.z * ResizeScaleFactor;
        }
        else
        {
            resizeX = resizeY = resizeZ = newScale.x * ResizeScaleFactor;
        }

        resizeX = Mathf.Clamp(lastScale.x + resizeX, MinScale, MaxScale);
        resizeY = Mathf.Clamp(lastScale.y + resizeY, MinScale, MaxScale);
        resizeZ = Mathf.Clamp(lastScale.z + resizeZ, MinScale, MaxScale);

        GameObject.FindGameObjectWithTag("Selected").transform.localScale = Vector3.Lerp(transform.localScale,
            new Vector3(resizeX, resizeY, resizeZ),
            ResizeSpeedFactor);
    }
}
