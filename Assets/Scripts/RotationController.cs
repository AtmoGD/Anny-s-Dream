using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 3f;
    public void Rotate(InputAction.CallbackContext _delta) {
        Vector2 rotationDelta = _delta.ReadValue<Vector2>();
        transform.rotation *= Quaternion.AngleAxis(-rotationDelta.x * rotationSpeed * Time.deltaTime, Vector3.up);
    }
}
