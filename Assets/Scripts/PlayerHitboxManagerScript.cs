using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitboxManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider[] attackColliders;
    void Start()
    {
        foreach(Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
        
    }

    public void EnableHitbox()
    {
        foreach( Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    public void DisableHitbox()
    {
        foreach( Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }

}
