using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float jump_force;
    [SerializeField] Transform jump_point;
    [SerializeField] LayerMask jump_mask;
    [SerializeField] float jump_radius;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        DownPlayer();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obst"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
    private void Jump()
    {
        bool is_jump = Physics2D.OverlapCircle(jump_point.position, jump_radius, jump_mask);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (is_jump)
            {
                rb.AddForce(Vector2.up * jump_force);
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }
    }
    public void DownPlayer()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(0.5f, 0.2f, 0.5f);
        }
    }

}
