using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    [SerializeField]
    private InputActionProperty gripAction;

    [SerializeField]
    private Animator handAnimator;

    private float gribInputValue;

    private void Update()
    {
        OnHandGrib();
    }

    private void OnHandGrib()
    {
        gribInputValue = gripAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gribInputValue);
    }
}
