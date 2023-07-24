using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 Speed = new Vector2(100f, 100f);
    private Vector2 InputVector;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        InputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().MovePosition(GetComponent<Rigidbody2D>().position + (InputVector * Speed * Time.fixedDeltaTime));
    }
}
