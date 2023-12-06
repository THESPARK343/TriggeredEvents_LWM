using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLost : MonoBehaviour
{
    public GameObject Self;
    public void Update()
    {
        if (Self.activeSelf == true)
        {
            SceneManager.LoadScene(1);
        }
    }
}
