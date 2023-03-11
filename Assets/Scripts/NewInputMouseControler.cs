using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class NewInputMouseControler : MonoBehaviour, IPointerEnterHandler,
             IPointerExitHandler, IPointerClickHandler, IPointerDownHandler,
             IPointerUpHandler, IPointerMoveHandler, IPointerCaptureEvent, 
             IMouseCaptureEvent, IMouseEvent, IMouseEventUnit
{
    EventModifiers IMouseEvent.modifiers => throw new System.NotImplementedException();

    Vector2 IMouseEvent.mousePosition => throw new System.NotImplementedException();

    Vector2 IMouseEvent.localMousePosition => throw new System.NotImplementedException();

    Vector2 IMouseEvent.mouseDelta => throw new System.NotImplementedException();

    int IMouseEvent.clickCount => throw new System.NotImplementedException();

    int IMouseEvent.button => throw new System.NotImplementedException();

    int IMouseEvent.pressedButtons => throw new System.NotImplementedException();

    bool IMouseEvent.shiftKey => throw new System.NotImplementedException();

    bool IMouseEvent.ctrlKey => throw new System.NotImplementedException();

    bool IMouseEvent.commandKey => throw new System.NotImplementedException();

    bool IMouseEvent.altKey => throw new System.NotImplementedException();

    bool IMouseEvent.actionKey => throw new System.NotImplementedException();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            print(" Bouton gauche de la souris appuyé !");
        }

        print("OnPointerClick Activated !");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            print(" Bouton gauche de la souris appuyé !");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
        //print("OnPointerEnter activated !");

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
