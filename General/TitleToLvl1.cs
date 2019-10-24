using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToLvl1 : MonoBehaviour
{
    public void GoNext()
    {
        SceneManager.LoadScene("Lvl1");
    }
}
