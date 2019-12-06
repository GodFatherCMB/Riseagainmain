using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes2d : MonoBehaviour
{
  [SerializeField]   private string newlevel;

    void OntriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newlevel);
        }
    }
}
