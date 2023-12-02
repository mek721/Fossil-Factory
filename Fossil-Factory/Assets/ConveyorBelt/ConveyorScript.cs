using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorScript : MonoBehaviour
{
    public Conveyor con;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = con.sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered Fossil");

        if (collision.tag == "Fossil")
        {
            Debug.Log("Collided Fossil");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10 * Time.deltaTime);
        }
    }
}
