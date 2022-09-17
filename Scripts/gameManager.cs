using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    [SerializeField] public int Point1;
    [SerializeField] public int Point2;
    [SerializeField] public Text PointP1;
    [SerializeField] public Text PointP2;


    // Start is called before the first frame update
    void Start()
    {
        Point1 = 0;
        Point2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PointP1.text = Point1.ToString();
        PointP2.text = Point2.ToString();
    }
}
