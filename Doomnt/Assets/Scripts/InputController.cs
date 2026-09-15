using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public static InputController Instance;

    InputAction movementInput;
    [HideInInspector] public Vector2 movementVector;


    // Generico para los singelton
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        movementInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        GetMoveInput();
    }

    public void GetMoveInput()
    {
        movementVector = movementInput.ReadValue<Vector2>();
    }
}
