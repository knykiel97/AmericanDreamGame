using UnityEngine;
using UnityEngine.EventSystems;

/*
 * Script to control on-screen button
 */
public class JoystickButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerUp(PointerEventData eventData)
    {
        IsPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        IsPressed = true;
    }

    public bool IsPressed { get; private set; }
}
