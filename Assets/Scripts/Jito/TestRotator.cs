using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float factor;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1));
            transform.localScale = new Vector3(transform.localScale.x + Time.deltaTime * factor,
                                               transform.localScale.y + Time.deltaTime * factor,
                                               1); 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1f));
            transform.localScale = new Vector3(transform.localScale.x - Time.deltaTime * factor,
                                               transform.localScale.y - Time.deltaTime * factor,
                                               1);
        }
    }
}
