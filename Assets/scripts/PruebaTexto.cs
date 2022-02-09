using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PruebaTexto : MonoBehaviour
{
    public TextMeshProUGUI textoEditable;
    public Color colorTexto;

    void Start()
    {
        textoEditable.text = "Hola cara de bola";
        textoEditable.color = colorTexto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
