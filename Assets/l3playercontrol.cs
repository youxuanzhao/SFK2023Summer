using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3playercontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public InteractiveParent ip;
    public InteractiveParent ip2;
    public GameObject lt;
    public PlayerController pc;

    public SpriteRenderer sr;
    // Update is called once per frame
    void Update()
    {

        if (ip.use && !ip2.use)
        {
            lt.SetActive(true);
        }
        if (ip.use && ip2.use)
        {
            lt.SetActive(false);
        }

        if (!(pc.Front) && lt.active)
        {
            lt.transform.localScale.Set(-1, 1, 1);
            sr.sortingOrder = 1;
        }
        else
        {
            sr.sortingOrder = 2;
        }
    }
}
