using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimController : MonoBehaviour
{
    public Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lastPosition = new Vector3(lastPosition.x, lastPosition.y + 0.1f, lastPosition.z);
            transform.position = lastPosition;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lastPosition = new Vector3(lastPosition.x, lastPosition.y - 0.1f, lastPosition.z);
            transform.position = lastPosition;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lastPosition = new Vector3(lastPosition.x - 0.1f, lastPosition.y, lastPosition.z);
            transform.position = lastPosition;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lastPosition = new Vector3(lastPosition.x + 0.1f, lastPosition.y, lastPosition.z);
            transform.position = lastPosition;
        }
    }
}
