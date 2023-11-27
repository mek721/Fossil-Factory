using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Floats

    public float _borderY;
    public float _borderX;
    public float _speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Clamps camera between two variables 

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -_borderX, _borderX);
        position.y = Mathf.Clamp(position.y, -_borderY, _borderY);
        position.z = -10f;
        transform.position = position;


        // Moves Camera based on two values

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * Horizontal * _speed * Time.deltaTime);
        transform.Translate(Vector2.up * Vertical * _speed * Time.deltaTime);

    }
}
