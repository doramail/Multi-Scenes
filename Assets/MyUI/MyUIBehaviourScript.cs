using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyUIBehaviourScript : MonoBehaviour
{
    public MenuUIHandler menuUIHandler;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button scene1 = root.Q<Button>("ButtonScene1");
        Button scene2 = root.Q<Button>("ButtonScene2");
        Button scene3 = root.Q<Button>("ButtonScene3");
        Button volume = root.Q<Button>("ButtonVolume");
        Button quit = root.Q<Button>("ButtonSortie");

        scene1.clicked += () => menuUIHandler.StartNew();
        //scene2.clicked += () => menuUIHandler.StartNew();
        //scene3.clicked += () => menuUIHandler.StartNew();
        quit.clicked += () => menuUIHandler.Exit();

    }
}
