using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    [ContextMenu("Open")]
    public void Open ()
    {
        animator.SetTrigger("Open");
    }



}
