using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string[] palabrasGuardadas;
    [SerializeField] private string[] preguntas;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textoPreguntas;
    [SerializeField] TextMeshProUGUI textoHistoria;
    [SerializeField] TMP_InputField inputRespuesta;
    [SerializeField] GameObject botonRespuesta;

    int indicePregunta = 0;

    void Start()
    {
        Debug.Log("Hola c:");
        textoPreguntas.text = preguntas[indicePregunta];

        palabrasGuardadas = new string[preguntas.Length];

    }

    public void GuardarRespuesta()
    {
        //Guardar lo que escribió el jugador
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;

        //Limpiar el texto
        inputRespuesta.text = "";

        //Poner la siguiente pregunta
        indicePregunta++;

        //Comrobación
        if (indicePregunta >= preguntas.Length)
        {
            MostrarHistoria();
        }
        else
        {
            textoPreguntas.text = preguntas[indicePregunta];
        }
    }

    void MostrarHistoria()
    {
        //TODO Mostrar un nuevo text mesh que tenga toda la historia
        textoHistoria.gameObject.SetActive(true);
        textoHistoria.text = historia;

        //TODO ocultar los elementos que no se utilizan
        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
    }
}
