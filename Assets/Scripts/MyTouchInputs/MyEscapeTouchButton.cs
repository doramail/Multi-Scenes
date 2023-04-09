using UnityEngine;
using UnityEngine.EventSystems;

public class MyEscapeTouchButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool clicked;
    public void OnPointerDown(PointerEventData eventData)
    {
        clicked = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        clicked = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
