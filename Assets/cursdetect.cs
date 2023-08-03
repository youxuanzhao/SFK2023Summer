using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursdetect : MonoBehaviour
{
    // Start is called before the first frame update
    public bool touched = false;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touched = true;
    }
}
