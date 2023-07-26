using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveParent : MonoBehaviour
{
    public GameObject sprite;
    public GameObject tooltip;
    public Collider2D detector;
    public Animator animator;
    
    private bool tooltipVisible;
    private bool use = false;

    // Start is called before the first frame update
    void Start()
    {
        tooltipVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        tooltip.SetActive(tooltipVisible);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tooltipVisible = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tooltipVisible = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            use = true;
            animator.SetBool("use", use);
        }
    }
}
