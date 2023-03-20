using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;


public class MyPlayerController : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    [SerializeField] MyPlayerMovement _navette;
    public float speed = 05f;
    public float gravity = -9.81f;
    public float jumpForce = 02f;
    public Camera cam;
    public float xSens = 03f;
    public float ySens = 03f;
    public Vector2 moveInput;
    //public Vector2 _escape;

    public CharacterController _controller;
    public Vector3 playerVelocity;
    public bool grounded;
    public Vector2 lookPos;
    public float xRotation = 0f;

    public void MoveCharacter(InputAction.CallbackContext ctx)
    {
        moveInput = (ctx.ReadValue<Vector2>());
    }

    public void JumpCharacter(InputAction.CallbackContext ctx)
    {
       _navette.Jump();
    }
    public void LookCharacter(InputAction.CallbackContext ctx)
    {
        lookPos = (ctx.ReadValue<Vector2>());
    }

    public void EscapeCharacter(InputAction.CallbackContext ctx)
    {
        //_escape = (ctx.ReadValue<Vector2>());
        Debug.Log("Escape activated by ! " + this + " Gameobject, Context = " + ctx);
    }

    //public void MovePlayer(Vector2 axesDeDeplacementReçu)
    //{
    //    Vector3 moveDirection = Vector3.zero;
    //    moveDirection.x = moveInput.x;
    //    moveDirection.z = moveInput.y;
    //    _controller.Move(transform.TransformDirection(moveDirection * speed * Time.deltaTime));
    //}

    public void Update()
    {
        //_navette.RotateCharacter(move);
        _navette.MovePlayer(moveInput);
        _navette.PlayerLook();
    }

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
}
