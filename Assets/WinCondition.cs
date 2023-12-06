using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            SceneManager.LoadScene(2);
        }
    }
}
