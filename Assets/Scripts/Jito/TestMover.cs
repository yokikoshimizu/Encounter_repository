using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TestMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(1.2f, 1, 1));
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);

        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(-1.2f, 1, 1));
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(1, 1.2f, 1));
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);

        }else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(1, -1.2f, 1));
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        }
    }
}
