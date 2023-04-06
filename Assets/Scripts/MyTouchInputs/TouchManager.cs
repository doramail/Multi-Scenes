using UnityEngine;
using UnityEngine.InputSystem;


public class TouchManager : MonoBehaviour
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

    public void TouchPressed(InputAction.CallbackContext callbackContext)
    {
        float value = callbackContext.ReadValue<float>();
        Debug.Log("Value = " + value);
    }
}
