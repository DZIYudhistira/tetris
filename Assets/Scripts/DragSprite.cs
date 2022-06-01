using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragSprite : MonoBehaviour
{
    private float distanceFromCamera;
    private Rigidbody2D r;
    private Transform block;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        block = GetComponent<Transform>();

        distanceFromCamera = Vector3.Distance(block.transform.position, cam.transform.position);
        r = block.transform.GetComponent<Rigidbody2D>();

        Debug.Log("mousePosition " + block.transform.position);
        Debug.Log("camPosition " + cam.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            block = GetComponent<Transform>();

            Vector3 mousePosition = Input.mousePosition;
//            mousePosition.z = distanceFromCamera;
            mousePosition.z = cam.nearClipPlane;
            mousePosition = cam.ScreenToWorldPoint(mousePosition);
            Debug.Log("mousePosition " + mousePosition);

            r.velocity = (mousePosition - block.transform.position);
        } else
        {
            r.velocity = Vector2.zero;
        }
    }
}
