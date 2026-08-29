using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : Controller, IDragHandler, IEndDragHandler
{
    Vector3 _initialPos;
    Vector3 _modifiedDir;
    [SerializeField] float _maxMagnitude = 150;
    void Start()
    {
        _initialPos = transform.position;
    }
    public override Vector3 GetMovementInput()
    {
        _modifiedDir = new Vector3 (_moveDir.x, 0, _moveDir.y);
        _modifiedDir /= _maxMagnitude;
        return _modifiedDir;
    }
    public void OnDrag(PointerEventData eventData)
    {
        _moveDir = Vector3.ClampMagnitude((Vector3)eventData.position - _initialPos, _maxMagnitude);
        transform.position = _initialPos + _moveDir;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = _initialPos;
        NotMove();
    }
}
