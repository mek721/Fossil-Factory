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
        if(colliding && !isUsed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isUsed = true;

                switch (stateHolder.currentState)
                {
                    case StateHolder.State.Printer:
                        Instantiate(printer, transform.position, Quaternion.identity);
                        break;

                    case StateHolder.State.ConveyorBelt:
                        Instantiate(conveyorBelt, transform.position, Quaternion.identity);
                        break;
                }
            }
        }
    }
}
