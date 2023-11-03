using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Over : MonoBehaviour
{
    public Text PuntosText;
    public GameObject GameOver;
    public GameObject Test;
    public static GameObject GameOverStatic;
    public static GameObject TestStatic;

    // Start is called before the first frame update
    void Start()
    {
        Over.GameOverStatic = GameOver;
        Over.GameOverStatic.gameObject.SetActive(false);
        Over.TestStatic = Test;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show()
    {
        PuntosText.text = GameManager.Points.ToString();
        Over.GameOverStatic.gameObject.SetActive(true);
        Over.TestStatic.gameObject.SetActive(false);
    }
}
