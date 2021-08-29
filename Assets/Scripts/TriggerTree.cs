using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTree : MonoBehaviour
{
    [SerializeField] Animator tree = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            tree.Play("TreeFall");
            Destroy(gameObject);
        } 
    }
}
