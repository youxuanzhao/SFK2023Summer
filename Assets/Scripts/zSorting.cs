using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zSorting : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }
   
}
