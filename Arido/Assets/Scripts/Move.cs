using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 4;
    public float dirX;
    public SpriteRenderer spr;
    public Rigidbody2D jump;
    public float strengthJump = 4.2f;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(dirX * speed, 0, 0);
        transform.position += new Vector3(dirX * speed * Time.deltaTime, 0);


        if (dirX > 0 ) 
        {
            spr.flipX = false;
        }
        else if (dirX < 0 )
        {
            spr.flipX = true;
        }

        Debug.DrawRay(transform.position, Vector3.down * 2, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 2))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump.AddForce(Vector2.up * strengthJump, ForceMode2D.Impulse);
        }
    }
}
