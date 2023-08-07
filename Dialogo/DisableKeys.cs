using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class DisableKeys : MonoBehaviour
{
    GameObject miObjeto;

    void Start()
    {
        miObjeto = GameObject.Find("Canvas_UI");
    }


    public void MyFunction()
    {
        PersonajeMovimiento classInstance = FindObjectOfType<PersonajeMovimiento>();
        classInstance.velocidad = 2f;
        miObjeto.SetActive(true);
        Debug.Log("Se cambio");
        newdialog[] dialogs = FindObjectsOfType<newdialog>();

        // Itera sobre cada instancia y establece ya_hablando en false
        foreach (newdialog dialog in dialogs)
        {
            dialog.ya_hablando = false;
        }

    }
}
