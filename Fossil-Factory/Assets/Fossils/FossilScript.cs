using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FossilScript : MonoBehaviour
{
    public Fossil so;

    public float _realness;
    public float _sellPrice;
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        _realness = so.realness;
        _sellPrice = so.sellPrice;
        sprite = so.sprite;
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 3, ForceMode2D.Impulse);
    }
}
