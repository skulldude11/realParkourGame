using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;



    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("IsAttacking");
        }
    }
}
