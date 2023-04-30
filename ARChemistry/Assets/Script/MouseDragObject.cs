using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private float speed = 1000f;
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(Vector3.right, speed * Time.deltaTime);
        }
    }
}
