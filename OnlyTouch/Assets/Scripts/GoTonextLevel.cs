using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTonextLevel : MonoBehaviour
{
    public int Lev;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UnLockLevel();
            SceneManager.LoadScene(Lev);
        }
    }
    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel >= PlayerPrefs.GetInt("levels"))
            PlayerPrefs.SetInt("levels", currentLevel + 1);
    }
}
