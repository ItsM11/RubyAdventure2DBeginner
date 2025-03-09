using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float horizontal = 0.0f;
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        horizontal = -1.0f;
 	    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        horizontal = 1.0f;
    }
    Debug.Log(horizontal);


    float vertical = 0.0f;
    if (Input.GetKey(KeyCode.UpArrow))
    {
        vertical = 1.0f;
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
        vertical = -1.0f;
    }
    Debug.Log(vertical);


    Vector2 position = transform.position;
    position.x = position.x + 0.1f * horizontal;
    position.y = position.y + 0.1f * vertical;
    transform.position = position;
}

    }

