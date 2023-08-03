using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandControl : MonoBehaviour
{
    public Animator animator;
    public bool isLeft;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isLeft", isLeft);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
