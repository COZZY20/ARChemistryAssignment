using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDragObject : MonoBehaviour
{
    private Touch touch;
    private float speed; // Controls how fast the model will move
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.001f; // can be modified to change the model movement speed
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) // When a finger is touching the screen
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved) // When move gestures is made
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z + touch.deltaPosition.y * speed);
            }
        }
    }
}
