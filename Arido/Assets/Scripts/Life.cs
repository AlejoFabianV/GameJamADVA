using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public float life = 100f;
    public Slider lifeBar;

    void Start()
    {
        
    }

    void Update()
    {
        lifeBar.value = life;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
