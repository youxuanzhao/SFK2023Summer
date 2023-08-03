using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curscontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject reference;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(reference.transform.position.x + offset, transform.position.y);
    }
}
