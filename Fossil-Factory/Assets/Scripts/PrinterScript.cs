using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrinterScript : MonoBehaviour
{
    public Printer so;
    public GameObject[] fossils;

    private float rate;
    private float timer;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        rate = so._productionRate;
        sprite = so.sprite;
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= rate)
        {
            var fossil = Instantiate(fossils[Random.Range(0, 2)], transform.position, transform.rotation);
            fossil.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 50 * Time.deltaTime, ForceMode2D.Impulse);
            timer = 0;
        }
    }
}
