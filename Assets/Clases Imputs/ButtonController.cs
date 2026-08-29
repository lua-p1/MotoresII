using UnityEngine;

public class ButtonController : MonoBehaviour
{
    Vector3 _moveDir;
    public Vector3 GetMovementInput() => _moveDir;

    public void NotMove() => _moveDir = Vector3.zero;
    public void MoveFoward() => _moveDir = Vector3.forward;
    public void MoveBack() => _moveDir = Vector3.back;
    public void MoveRight() => _moveDir = Vector3.right;
    public void MoveLeft () => _moveDir = Vector3.left;
}
