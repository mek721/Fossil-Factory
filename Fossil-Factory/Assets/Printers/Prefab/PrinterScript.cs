using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrinterScript : MonoBehaviour
{
    public Printer so;
    public GameObject[] fossils;

    private float rate;
    public float speed;
    private float timer;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        rate = so._productionRate;
        sprite = so.sprite;
        speed = so._speed;
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= rate)
        {
            Debug.Log("Spawned Fossil");
            var fossil = Instantiate(fossils[Random.Range(0, 2)], transform.position, transform.rotation);
            fossil.GetComponent<Rigidbody2D>().AddForce(-transform.right * speed * Time.deltaTime, ForceMode2D.Impulse);
            fossil.tag = "Fossil";
            timer = 0;
        }
    }
}
