using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private Camera activeCamera = null;

    private InputControlls input;

    private void Awake() {
        input = new InputControlls();    
    }

    private void OnEnable() {
        input.Enable();
    }

    private void OnDisable() {
        input.Disable();
    }

    private void Start() {
        // input.Input.Interact.
    }
    
    public void Interact(InputAction.CallbackContext _input) {
        if(_input.ReadValue<float>() != 1) return;

        Vector2 position = input.Input.InteractPosition.ReadValue<Vector2>();
        Ray ray = activeCamera.ScreenPointToRay(position);

        if(Physics.Raycast(ray, out RaycastHit hit, float.MaxValue)) {
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if(interactable != null) {
                interactable.Interact();
            }
        }
    }
}
