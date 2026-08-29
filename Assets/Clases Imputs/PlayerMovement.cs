using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Controller _controller;
    [SerializeField] float _speed;

    private void Update()
    {
        transform.position += _controller.GetMovementInput() * _speed * Time.deltaTime;
    }
}
