using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    public Player_Move button;

    public void OnUpdateSelected(BaseEventData data)
    {
        if (isPressed)
        {
            button.MoveRight();
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
}
