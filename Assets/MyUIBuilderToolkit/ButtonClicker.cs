using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonClicker : MonoBehaviour
{
    UIDocument buttonDocument;
    Button uiButton;

    private void OnEnable()
    {
        buttonDocument = GetComponent<UIDocument>();
        if(buttonDocument == null)
        {
            Debug.Log("No Button Document Found");
        }
        uiButton = buttonDocument.rootVisualElement.Q(name: "TestButton") as Button;
        if(uiButton != null)
        {
            Debug.Log("Button Found");
        }
        uiButton.RegisterCallback<ClickEvent>(OnButtonClick);
    }
    public void OnButtonClick(ClickEvent clickEvent)
    {
        Debug.Log("The UI Button has been clicked on successfully !");
    }
}
