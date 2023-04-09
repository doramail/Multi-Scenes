#region usings:
using UnityEngine;
using UnityEngine.InputSystem;
#endregion usings: End

public class MyJoystickPlayerExample : MonoBehaviour
{
    public MyPlayerController _myPlayerController;
    public float speed = 20;
    public FixedJoystick _fixedJoystick;
    //public Rigidbody rb;
    public Vector2 moveInput = Vector2.zero;

    private float movementX;
    private float movementY;

    public void FixedUpdate()
    {
        // Créer un vecteur de direction à partir des valeurs X et Y du joystick
        //Vector3 direction = new Vector3(movementX, 0, movementY);
        //Vector3 direction = Vector3.forward * _fixedJoystick.Vertical + Vector3.right * _fixedJoystick.Horizontal;
        //_myPlayerController._characterController.Move(transform.TransformDirection(direction * speed * Time.deltaTime));
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public void onMyTouchPosition(InputValue _movementValue)
    //private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = _movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
        Debug.Log("From onTouchPosition(), movementX = " + movementX);
        Debug.Log("From onTouchPosition(), movementX = " + movementY);
    }

    public void onMyTouchPress (InputValue _pressedValue)
    {
        Debug.Log("From onTouchPress(), _pressedValue = " + _pressedValue);
    }

    public void onTouchPosition(InputValue _movementValue)
    //private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = _movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
        Debug.Log("From onTouchPosition(), movementX = " + movementX);
        Debug.Log("From onTouchPosition(), movementX = " + movementY);
    }

    public void onTouchPress(InputValue _pressedValue)
    {
        Debug.Log("From onTouchPress(), _pressedValue = " + _pressedValue);
    }

}