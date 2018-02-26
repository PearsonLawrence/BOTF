using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
public class CameraController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isDown;
    private float downTime;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
        this.downTime = Time.realtimeSinceStartup;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    public void Update()
    {
        if (!this.isDown) return;
        if (Time.realtimeSinceStartup - this.downTime > 2f)
        {
            print("Handle Long Tap");
            this.isDown = false;
        }
    }
}
