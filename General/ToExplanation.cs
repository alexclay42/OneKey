using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToExplanation : MonoBehaviour
{
    public void Goexp()
    {
        SceneManager.LoadScene("Explanation");
    }

    public void GoInstruct()
    {
        SceneManager.LoadScene("Instruction");
    }

}
