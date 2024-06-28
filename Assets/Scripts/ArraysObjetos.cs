﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArraysObjetos : MonoBehaviour
{
    public GameObject[] objetos; // Arreglo de objetos
    private int objetosIndex = 0; // Índice del objeto activo

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNextLight();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePreviousLight();
        }
    }

    public void ActivateNextLight()
    {
        objetosIndex++;
        if (objetosIndex >= objetos.Length)
        {
            objetosIndex = 0;
        }
        DeactivateAllLights();
        objetos[objetosIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        objetosIndex--;
        if (objetosIndex < 0)
        {
            objetosIndex = objetos.Length - 1;
        }
        DeactivateAllLights();
        objetos[objetosIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        foreach (GameObject g in objetos)
        {
            g.SetActive(false);
        }
    }


    public void ActivateRepeating(float t)
    {

    }
}