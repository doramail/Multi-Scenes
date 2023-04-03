using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyTouchManager : MonoBehaviour
{
    private PlayerInput _playerInput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        touchPressAction = _playerInput.actions["TouchPress"];
        touchPositionAction = _playerInput.actions["TouchPosition"];
    }

    private void OnEnable()
    {
        touchPressAction.performed += TouchPressed;
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }
    public void TouchPressed(InputAction.CallbackContext touchPressedContext)
    {
        float value = touchPressedContext.ReadValue<float>();
        Debug.Log("value = " + value);
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
