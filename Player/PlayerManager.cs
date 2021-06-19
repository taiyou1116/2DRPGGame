using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 3f;
    Animator animator;
    Item.Type item;
    public bool near;

    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x,y) * speed;
        

        animator.SetFloat("speed",x);
        animator.SetFloat("y.speed",y);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Item")
        {
            near = true;
        }
    }

   
    
}
