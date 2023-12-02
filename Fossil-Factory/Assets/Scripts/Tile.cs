using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;

    private StateHolder stateHolder;

    public GameObject printer;
    public GameObject conveyorBelt;

    public bool colliding;
    private bool isUsed = false;

    public Quaternion _rotation;
    public float rotationUsed = 1;

    void Start()
    {
        stateHolder = GameObject.FindObjectOfType<StateHolder>();
    }

    public void Init(bool isoffSet)
    {
        _renderer.color = isoffSet ? _offsetColor : _baseColor;
    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);

        colliding = true;
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);

        colliding = false;
    }

    private void Update()
    {
        if (colliding && !isUsed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                switch (stateHolder.currentState)
                {
                    case StateHolder.State.Printer:
                        var printerVar = Instantiate(printer, transform.position, _rotation);
                        break;

                    case StateHolder.State.ConveyorBelt:
                        var conveyorVar = Instantiate(conveyorBelt, transform.position, _rotation);
                        break;
                }

                isUsed = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            rotationUsed = (rotationUsed % 4) + 1; // Loop between 1 and 4

            float rotationAngle = (rotationUsed - 1) * 90f;
            _rotation = Quaternion.Euler(0f, 0f, rotationAngle);
        }
    }
}
