using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnviroment : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("damage");
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<Life>().life -= 10f;
        }
    }

}
