using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayerController : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    #region Variables: Movement

    private Vector2 _input;
    private CharacterController _characterController;
    private Vector3 _direction;

    [SerializeField] private float speed;

    #endregion Variables: Movement

    #region Variables: Rotation

    public float xSens = 03f;
    public float ySens = 03f;
    public Vector2 lookPos;
    public Camera cam;
    public float xRotation = 0f;

    #endregion Variables: Rotation

    #region Variables: Gravity

    private float _gravity = -9.81f;
    [SerializeField] private float gravityMultiplier = 3.0f;
    private float _velocity;
    private bool IsGrounded() => _characterController.isGrounded;
    #endregion Variables: Gravity

    #region Variables: Jumps

    private int _numberOfJumps;
    [SerializeField] private int maxNumberOfJumps = 2;
    [SerializeField] private float jumpPower;
    #endregion Variables: Jumps

    #region Variables: PlayerZoom
    private float targetFieldOfView;
    [SerializeField] float fieldOfViewMin = 05.0f;
    [SerializeField] float fieldOfViewMax = 050.0f;

    #endregion Variables: PlayerZoom

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _characterController.minMoveDistance = 0.0f;
    }

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    private void Update()
    {
        ApplyGravity();
        ApplyMovement();
        PlayerLook();
    }

    private void ApplyGravity()
    {
        if (_characterController.isGrounded && _velocity < 0.0f)
        {
            _velocity = -1.0f;
        }
        else
        {
            _velocity += _gravity * gravityMultiplier * Time.deltaTime;
        }
        _direction.y = _velocity;
    }

    private void ApplyMovement()
    {
        _characterController.Move(transform.TransformDirection(_direction * speed * Time.deltaTime));
    }

    public void JumpCharacter(InputAction.CallbackContext ctx)
    {
        if (!ctx.started) return;
        if (!IsGrounded() && _numberOfJumps >= maxNumberOfJumps) return;
        if (_numberOfJumps == 0) StartCoroutine(WaitForLanding());

        _numberOfJumps++;
        _velocity = jumpPower;
    }

    private IEnumerator WaitForLanding()
    {
        yield return new WaitUntil(() => !IsGrounded());
        yield return new WaitUntil(IsGrounded);

        _numberOfJumps = 0;
    }

    public void Move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
        _direction = new Vector3(_input.x, 0.0f, _input.y);
    }

    public void PlayerLook()
    {
        xRotation -= (lookPos.y * Time.deltaTime) * ySens;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.Rotate(Vector3.up * (lookPos.x * Time.deltaTime) * xSens);
    }

    //public void PlayerZoom() // 2btested & use with Cinemachine
    //{
    //    float fieldOfViewIncreaseAmount = 05.0f;
    //    if (Input.mouseScrollDelta.y > 0)
    //    {
    //        targetFieldOfView += fieldOfViewIncreaseAmount;
    //    }
    //    if (Input.mouseScrollDelta.y < 0)
    //    {
    //        targetFieldOfView -= fieldOfViewIncreaseAmount;
    //    }

    //    targetFieldOfView = Mathf.Clamp(targetFieldOfView, fieldOfViewMin, fieldOfViewMax);

    //    float zoomSpeed = 3.0f;
    //    cinemachineVirtualCamera.m_Lens.FieldOfView =  Mathf.Lerp(cinemachineVirtualCamera.m_Lens.FieldOfView, targetFieldOfView, Time.deltaTime * zoomSpeed);
    //}

    public void LookCharacter(InputAction.CallbackContext ctx)
    {
        lookPos = (ctx.ReadValue<Vector2>());
    }
}