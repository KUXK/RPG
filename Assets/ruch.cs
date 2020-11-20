using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        
        animator.SetFloat("vertical",Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftShift ))
        {
            run();
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("bieg", false);
        }

    }
    public void Jump()
    {
        animator.SetTrigger("jump");
    }
    public void run()
    {
        animator.SetBool("bieg",true);
    }
    
    
}
