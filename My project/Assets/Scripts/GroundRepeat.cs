using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeat : MonoBehaviour
{
    private float ground_width;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D colider = GetComponent<BoxCollider2D>();
        ground_width = colider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -ground_width)
        {
            transform.Translate(Vector2.right * 2f * ground_width);
        }
    }
}
