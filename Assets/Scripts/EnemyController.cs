using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
        private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");

        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1);
        }
    }

}
