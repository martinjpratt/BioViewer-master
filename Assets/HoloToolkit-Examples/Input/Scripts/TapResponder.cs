// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule.Tests
{
    /// <summary>
    /// This class implements IInputClickHandler to handle the tap gesture.
    /// It increases the scale of the object when tapped.
    /// </summary>
    public class TapResponder : MonoBehaviour, IInputClickHandler
    {
        public GameObject goToObject;
        Color startColor;
        Renderer rend;
        public bool selected = false;

        public void OnInputClicked(InputClickedEventData eventData)
        {
            if (selected != true)
            {
                goToObject.SetActive(true);

                selected = true;
            }
            else
            {
                goToObject.SetActive(false);
                selected = false;
            }

            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
    }
}