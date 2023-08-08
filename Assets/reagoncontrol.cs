using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reagoncontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public InteractiveParent ip;
    public GameObject lt;

    // Update is called once per frame
    void Update()
    {
        if (ip.use)
        {
            lt.SetActive(false);
        }
    }
}
