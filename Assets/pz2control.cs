using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pz2control : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public GameObject obj;
    // Start is called before the first frame update
    private bool isPressed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !(isPressed))
        {
            isPressed = true;
            obj.transform.position += new Vector3(3, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isPressed = false;
        }
        if (rigidbody2d.velocity.x>-5)
        {
            rigidbody2d.AddForce(new Vector2(-2, 0));
        }
    }
}
