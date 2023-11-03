using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSystem : MonoBehaviour
{
    public GameObject oseo1, oseo2, muscular1, muscular2, nervioso, circulatorio1, circulatorio2, linfatico1, linfatico2, tejido;
    private string system;

    // Update is called once per frame
    private void Update()
    {
        if (system == "oseo")
        {
            oseo1.SetActive(!oseo1.activeSelf);
            oseo2.SetActive(!oseo2.activeSelf);
        }
        else if (system == "muscular")
        {
            muscular1.SetActive(!muscular1.activeSelf);
            muscular2.SetActive(!muscular2.activeSelf);
        }
        else if (system == "nervioso")
        {
            nervioso.SetActive(!nervioso.activeSelf);
        }
        else if (system == "circulatorio")
        {
            circulatorio1.SetActive(!circulatorio1.activeSelf);
            circulatorio2.SetActive(!circulatorio2.activeSelf);
        }
        else if (system == "linfatico")
        {
            linfatico1.SetActive(!linfatico1.activeSelf);
            linfatico2.SetActive(!linfatico2.activeSelf);
        }
        else if (system == "tejido")
        {
            tejido.SetActive(!tejido.activeSelf);
        }
        system = "";
    }

    public void Oseo()
    {
        system = "oseo";
    }

    public void Muscular()
    {
        system = "muscular";
    }
    public void Nervioso()
    {
        system = "nervioso";
    }
    public void Circulatorio()
    {
        system = "circulatorio";
    }
    public void Linfatico()
    {
        system = "linfatico";
    }
    public void Tejido()
    {
        system = "tejido";
    }
}
