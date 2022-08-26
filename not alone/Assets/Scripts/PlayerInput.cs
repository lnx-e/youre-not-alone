using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    public UnityEvent<Vector2> OnMovementInput;


    [SerializeField]
    private InputActionReference movement;


    public void Update()
    {
        OnMovementInput?.Invoke(movement.action.ReadValue<Vector2>().normalized);
    }

}
