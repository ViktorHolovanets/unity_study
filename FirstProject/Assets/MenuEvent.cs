using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToScene(int csene)
    {
        SceneManager.LoadScene(csene);
    }

    // Update is called once per frame
    public void Exit()
    {
        Application.Quit();
    }
}
