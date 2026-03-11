using UnityEngine;
using UnityEngine.InputSystem;

public class CtrlInput : MonoBehaviour
{
    public float speed = 5;
    public Vector2 movement;
    void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("Attack " + context.phase);
    }
}