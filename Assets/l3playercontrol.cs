using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3playercontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public InteractiveParent ip;
    public GameObject lt;
    public PlayerController pc;

    // Update is called once per frame
    void Update()
    {
        if (ip.use)
        {
            lt.SetActive(true);
        }
        if(!(pc.Front) && lt.active)
        {
            lt.transform.localScale.Set(-1, 1, 1);
        }
        lt.transform.position.Set(pc.gameObject.transform.position.x, pc.gameObject.transform.position.y, pc.gameObject.transform.position.z+1);
    }
}
