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
    public bool inRange = false;
    public bool use = false;

    // Start is called before the first frame update
    void Start()
    {
        tooltipVisible = false;
    }

    // Update is called once per frame
    void Update()
    {
        tooltip.SetActive(tooltipVisible);
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            use = true;
            if(animator != null) {
                animator.SetTrigger("m1trigger");
            }
            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tooltipVisible = true;
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tooltipVisible = false;
            inRange = false;
        }
    }
   
}
