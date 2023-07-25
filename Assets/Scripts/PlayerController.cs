using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 Speed = new Vector2(100f, 100f);
    public Rigidbody2D rigidbody2d;
    public Animator animator;
    private Vector2 InputVector;
    private bool Front = true;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Awake()
    {
        rigidbody2d.gravityScale = 0;
        rigidbody2d.angularDrag = 0;
        
    }
    void Update()
    {
        InputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (InputVector != Vector2.zero)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (InputVector.x < 0)
        {
            if(!Front)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1,1,1);
            }
            
        }

        if (InputVector.x > 0)
        {
            if (!Front)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }

        if (InputVector.y > 0)
        {
            Front = false;
        }
        if (InputVector.y < 0)
        {
            Front = true;
        }

        animator.SetBool("Front", Front);
    }
    private void FixedUpdate()
    {
        //rigidbody2d.MovePosition(rigidbody2d.position + (InputVector * Speed * Time.fixedDeltaTime));
        rigidbody2d.velocity = InputVector * Speed;
    }
}
