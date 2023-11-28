using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -5f;
    public float maxY = 5f;

    public float zoomSpeed = 5f; // New variable for zoom speed
    public float minZoom = 5f;  // Minimum zoom value
    public float maxZoom = 15f; // Maximum zoom value

    void Update()
    {
        MoveCamera();
        ZoomCamera();
    }

    void MoveCamera()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Clamp the camera position to stay within the specified borders
        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedY = Mathf.Clamp(transform.position.y, minY, maxY);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }

    void ZoomCamera()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        // Adjust the size of the camera based on the mouse wheel input
        float newSize = Camera.main.orthographicSize - scrollInput * zoomSpeed * Time.deltaTime;
        newSize = Mathf.Clamp(newSize, minZoom, maxZoom);
        Camera.main.orthographicSize = newSize;
    }
}
