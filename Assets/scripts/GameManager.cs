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
        textoPreguntas.text = preguntas[0];

        palabrasGuardadas = new string[preguntas.Length];

    }

    public void guardarRespuesta()
    {
        //Guardar lo que escribió el jugador
        palabrasGuardadas[0] = inputRespuesta.text;

        //Limpiar el texto
        inputRespuesta.text = "";

        //Poner la siguiente pregunta
        indicePregunta++;

        //Comrobación
        if (indicePregunta >= preguntas.Length)
        {
            mostrarHistoria();
        }
        else
        {
            textoPreguntas.text = preguntas[indicePregunta];
        }
    }

    void mostrarHistoria()
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
