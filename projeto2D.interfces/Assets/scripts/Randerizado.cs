using System;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
public class Randerizado : MonoBehaviour
{
    public string novoTexto;
    public TextMeshProUGUI UITexto;
    
    void Start()
    {
        UITexto.text = novoTexto;     
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0)
            numero--;
        UITexto.text = novoTexto + " " + numero;

    }
    
    
        if (Input.GetKeyDown(KeyCode.Z))
    {
        numero++;
        UITexto.text = novoTexto " " + numero
    }

}




