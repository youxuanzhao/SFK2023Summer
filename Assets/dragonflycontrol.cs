using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonflycontrol : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.AddForce(new Vector2(-1, 0));
        if (transform.position.x < 45)
        {
            rigidbody2d.Sleep();
        }
        
    }
}
