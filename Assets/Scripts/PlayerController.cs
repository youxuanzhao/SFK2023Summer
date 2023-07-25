using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 Speed = new Vector2(100f, 100f);
    public Rigidbody2D rigidbody2d;
    private Vector2 InputVector;
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
    }
    private void FixedUpdate()
    {
        rigidbody2d.MovePosition(rigidbody2d.position + (InputVector * Speed * Time.fixedDeltaTime));
    }
}
