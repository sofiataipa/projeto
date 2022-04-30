using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControl : MonoBehaviour
{
    private Animator animator;
    private CapsuleCollider capsuleCollider;
    private float originalHeight;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        originalHeight = capsuleCollider.height;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));

        if (Input.GetButtonDown("Jump")) 
        {
            animator.SetTrigger("jump");
        }

        capsuleCollider.height = originalHeight * animator.GetFloat("collider_height");
        
    }
}
