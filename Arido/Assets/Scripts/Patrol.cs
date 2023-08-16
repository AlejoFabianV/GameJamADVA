using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Transform controlerFloor;
    [SerializeField] private float distance;
    [SerializeField] private bool moveRight;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D infoControlerFloor = Physics2D.Raycast(controlerFloor.position, Vector2.down, distance);

        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (infoControlerFloor == false )
        {
            Spin();
        }
    }

    //Girar el personaje para que no se caiga
    private void Spin()
    {
        moveRight = !moveRight;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        speed *= -1;
    }

    //Linea del raycast
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(controlerFloor.transform.position, controlerFloor.transform.position + Vector3.down * distance);
    } 

}
