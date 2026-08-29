using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    protected Vector3 _moveDir;
    public abstract Vector3 GetMovementInput();
    public virtual void NotMove() => _moveDir = Vector3.zero;
    //virtual en caso de que quiera modificarlo en una clase que herede de controller y abstract en caso de que no quiera modificarlo
}
