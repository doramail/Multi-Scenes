using UnityEngine;

public class MyPlayerMovement : MonoBehaviour //Inherits from class `MonoBehaviour`. This makes it attachable to a game object as a component.
{
    [SerializeField] MyPlayerController _navetteRetour;

    public void MovePlayer(Vector2 axesDeDeplacementReçu)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = _navetteRetour.moveInput.x;
        moveDirection.z = _navetteRetour.moveInput.y;
        _navetteRetour._controller.Move(transform.TransformDirection(moveDirection * _navetteRetour.speed * Time.deltaTime));
        _navetteRetour.playerVelocity.y *= _navetteRetour.gravity * Time.deltaTime;
        if (_navetteRetour.grounded && _navetteRetour.playerVelocity.y < 0)
        {
            _navetteRetour.playerVelocity.y = -2f;
        }
        _navetteRetour._controller.Move(_navetteRetour.playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        //if (_navetteRetour.grounded)
        {
            _navetteRetour.playerVelocity.y = Mathf.Sqrt(_navetteRetour.jumpForce * -3f * _navetteRetour.gravity);
        }
    }

    public void PlayerLook()
    {
        _navetteRetour.xRotation -= (_navetteRetour.lookPos.y * Time.deltaTime) * _navetteRetour.ySens;
        _navetteRetour.xRotation = Mathf.Clamp(_navetteRetour.xRotation, -80f, 80f);

        _navetteRetour.cam.transform.localRotation = Quaternion.Euler(_navetteRetour.xRotation, 0, 0);
        transform.Rotate(Vector3.up * (_navetteRetour.lookPos.x * Time.deltaTime) * _navetteRetour.xSens);
    }


    //public void RotateCharacter(Vector2 directionDeplacementReçu)
    //{
    //    // déplacement du character lui permettant de tourner dans la direction du déplacement.
    //    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(directionDeplacementReçu),0.15f);
    //}
}

