using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
    public GameObject house1;
    public GameObject house2;
    // Start is called before the first frame update
    void Start()
    {
        house1.SetActive(true);
        house2.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        house1.SetActive(true);
        house2.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        house1.SetActive(false);
        house2.SetActive(true);
    }
}
