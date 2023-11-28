using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateHolder : MonoBehaviour
{
    public enum State
    {
        Default,
        Printer,
        ConveyorBelt
    }

    // The current state
    public State currentState;

    public void SetState(State newState)
    {
        currentState = newState;
    }

    public void SetStateToPrinter()
    {
        SetState(StateHolder.State.Printer);
    }

    public void SetStateToConveyorBelt()
    {
        SetState(StateHolder.State.ConveyorBelt);
    }
}
