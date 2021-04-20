using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_test : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 1;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 55)
        {
            transform.position = new Vector3(0, 0, 0);
        }
        else
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
