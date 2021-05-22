using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int LevelUnLock = 1;
    [SerializeField]
    public Button[] LevelButtons;
    void Start()
    {
        LevelUnLock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < LevelButtons.Length; i++)
            LevelButtons[i].interactable = false;

        for (int i = 0; i < LevelUnLock; i++)
            LevelButtons[i].interactable = true;
    }

    public void LoadLevel(int levelIndex)
    {
       SceneManager.LoadScene(levelIndex);
    }
    


}
