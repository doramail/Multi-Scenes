using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class MyRightplayerMovementsJoystick : MonoBehaviour
{
    MyDefaultInputActions _myDefaultInputActions;
    MyPlayerController _myPlayerController;

    public CharacterController _myTouchCharacterController;

    Vector2 _playertouchPress;
    Vector2 _playertouchPosition;
    private float _playerMoveSpeed = 05.0f;
    public Vector3 _playerDirection;
    private float _touchPressed;

    private void Awake()
    {
        _myTouchCharacterController = GetComponent<CharacterController>();
        _myTouchCharacterController.minMoveDistance = 0.0f;

        _myDefaultInputActions = new MyDefaultInputActions();
    }

    private void OnEnable()
    {
        Debug.Log("From class 'MyRightplayerMovementsJoystick', OnEnable Function");
        _myDefaultInputActions.Enable();
        _myDefaultInputActions.MyTouch.MyTouchPosition.performed += TouchPositionPlayerMove;
        _myDefaultInputActions.MyTouch.MyTouchPosition.canceled += TouchPositionPlayerMove;
        _myDefaultInputActions.MyTouch.MyTouchPress.performed += TouchPressPlayer;
        _myDefaultInputActions.MyTouch.MyTouchPress.canceled += TouchPressPlayer;

    }

    private void OnDisable()
    {
        Debug.Log("From class 'MyRightplayerMovementsJoystick', OnDisable Function");
        _myDefaultInputActions.Disable();
        _myDefaultInputActions.MyTouch.MyTouchPosition.performed -= TouchPositionPlayerMove;
        _myDefaultInputActions.MyTouch.MyTouchPosition.canceled -= TouchPositionPlayerMove;
        _myDefaultInputActions.MyTouch.MyTouchPress.performed -= TouchPressPlayer;
        _myDefaultInputActions.MyTouch.MyTouchPress.canceled -= TouchPressPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovements();
        //TouchPressedPlayer();
    }

    public void TouchPositionPlayerMove(InputAction.CallbackContext _touchPosition)
    {
        _playertouchPosition = _touchPosition.ReadValue<Vector2>();
        //_playerDirection = new Vector3(_playertouchPosition.x, 0.0f, _playertouchPosition.y);
        Debug.Log("From TouchPositionPlayerMove : " + _playertouchPosition);
    }

    public void TouchPressPlayer(InputAction.CallbackContext _touchPress)
    {
        _touchPressed = _touchPress.ReadValue<float>();
       Debug.Log("From TouchPressPlayer Function : " + _touchPressed);
    }

    private void PlayerMovements()
    {
        // Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(_playertouchPosition.x, _playertouchPosition.y, 5));
        Vector3 worldPosition = Camera.main.ScreenToViewportPoint(new Vector3(_playertouchPosition.x, _playertouchPosition.y, 0));
        //this.transform.position = worldPosition;
        Debug.Log("From PlaterMovement(), worldPosition = " + worldPosition);

        //_myTouchCharacterController.Move(transform.TransformDirection(_playerDirection * _playerMoveSpeed * Time.deltaTime));
    }
    public void TouchPressedPlayer()
    {
        if (_myTouchCharacterController != null)
        {
            if (_touchPressed == 1)
            {
                Debug.Log("_touchPressed =  " + _touchPressed);
            }
        }
        else return;
    }
}
