using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public Health hp;
    public PlayerController pc;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10)
        {
            hp.TakeDamage();
            pc.rb.velocity = Vector3.zero;
            pc.transform.position = new Vector3(0, 5, 0);
        }
    }
}
