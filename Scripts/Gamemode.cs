using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemode : MonoBehaviour
{
    private ScrDetectmode scrDetect;

    // Start is called before the first frame update
    void Start()
    {
        scrDetect = GameObject.Find("Detectmode").GetComponent<ScrDetectmode>();
    }
    
    public void onePlayer()
    {
        scrDetect.onePlayer = true;
        SceneManager.LoadScene("SampleScene");
    }

    public void twoPlayers()
    {
        scrDetect.onePlayer = false;
        SceneManager.LoadScene("SampleScene");
    }

    public void IAvsIA()
    {
        scrDetect.twoPlayers = true;
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
