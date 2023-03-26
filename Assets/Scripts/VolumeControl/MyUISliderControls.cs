using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyUISliderControls : MonoBehaviour
{
    public UIDocument document;
    //public GameObject slider;

    private void Awake()
    {
        var root = document.rootVisualElement;
        var volumeSlider = root.Q<SliderInt>("VolumeSlider");
        volumeSlider.RegisterValueChangedCallback(evt =>
        {
            Debug.Log(evt.newValue);
        });
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
