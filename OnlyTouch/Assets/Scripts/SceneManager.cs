using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private int CountKey;
    private int OurKey;
    [SerializeField]
    private GameObject ExitDoor;

    public void AddKey()
    {
        OurKey++;
    }
    private void Update()
    {
        if(OurKey == CountKey)
        {
            ExitDoor.SetActive(true);
        }
    }


}
