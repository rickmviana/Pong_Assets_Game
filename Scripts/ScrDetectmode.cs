using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrDetectmode : MonoBehaviour
{
    public bool onePlayer;
    public bool twoPlayers;
    public bool IAvsIA;

    void Start()
    {
        DontDestroyOnLoad(gameObject);    
    }
}
