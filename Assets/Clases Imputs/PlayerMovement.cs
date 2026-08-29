using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] ButtonController _buttonController;
    [SerializeField] float _speed;

    private void Update()
    {
        transform.position += _buttonController.GetMovementInput() * _speed * Time.deltaTime;
    }
}
