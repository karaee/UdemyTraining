using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    Camera mainCamera;
    Touch touch;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            CheckTouch();

            RaycastHit hitObject;
            if (Physics.Raycast(mainCamera.ScreenPointToRay(touch.position), out hitObject))
            {
                if (hitObject.collider.gameObject.tag == "Cubes")
                {
                    if (hitObject.collider.gameObject.GetComponent<MeshRenderer>().enabled)
                    hitObject.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    else hitObject.collider.gameObject.GetComponent<MeshRenderer>().enabled = true;
                }

            }

        }

    }
    void CheckTouch()
    {
        touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            Debug.Log("Touch Started");
        }

        if (touch.phase == TouchPhase.Stationary)
        {
            Debug.Log("Finger is stationary");
        }

        if (touch.phase == TouchPhase.Moved)
        {
            Debug.Log("Finger is moved");
        }

        if (touch.phase == TouchPhase.Ended)
        {
            Debug.Log("Touch Ended");
        }

        Debug.Log("position: " + touch.position);
        Debug.Log("speed: " + touch.deltaPosition);
    }

}