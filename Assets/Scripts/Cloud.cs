using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    private float x1;
    private float x2;
    public bool swiped = false;
    public Rigidbody2D rigidbody2d;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            x1 = Input.mousePosition.x;
        }

        if (Input.GetMouseButtonUp(0))
        {
            x2 = Input.mousePosition.x;
            if ((x2 - x1) > 3)
            {
                rigidbody2d.AddForce(new Vector2(100, 0));
            }
            if ((x1 - x2) > 3)
            {
                rigidbody2d.AddForce(new Vector2(-100, 0));
            }
            swiped = true;
        }
    }
}
