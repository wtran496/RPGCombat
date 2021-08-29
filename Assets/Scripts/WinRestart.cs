using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinRestart : MonoBehaviour
{
    [SerializeField] Canvas restart = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
            restart.gameObject.SetActive(true);
    }
}
