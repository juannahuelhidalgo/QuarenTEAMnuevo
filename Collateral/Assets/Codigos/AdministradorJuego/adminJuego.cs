﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class adminJuego : MonoBehaviour
{
    int EscenaActual;
    public static int semanaActual = -1;
    int pacientesTotales = 0;
    static int pacientesAtendidos = 0;


    void Start()
    {
        EscenaActual = SceneManager.GetActiveScene().buildIndex;
       // Debug.Log("DEBUG DE ADMINISTRADOR DE ESCENA -La escena es: " + EscenaActual);
    }

    public void cargarEscenaSiguiente()
    {
        if (getNumeroEscenaActual() == 0 || getNumeroEscenaActual() == 1)
        {
            sumarSemana();
            Debug.Log("la semana actual: " + semanaActual);
            SceneManager.LoadScene(EscenaActual + 1);
        }
        if (getNumeroEscenaActual() == 2)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void sumarSemana()
    {
        semanaActual++;
    }

    public int getSemanaActual()
    {
        return semanaActual;
    }


    public void cargarEscenaAnterior()
    {
        SceneManager.LoadScene(EscenaActual - 1);
    }

    public int getNumeroEscenaActual()
    {
        return EscenaActual;
    }

    public void cerrarJuego()
    {
        Debug.Log("estoy cerrando el juego");
        Application.Quit();
    }
    public void cargarEscena(int num)
    {
        SceneManager.LoadScene(num);
    }

    public int semanaAct()
    {
        return semanaActual;
    }

    public void setSemana(int n)
    {
        semanaActual = n;
    }

    public void moverEnfermero()
    {
       
    }

    public void mouseController()
    {

    }
}
