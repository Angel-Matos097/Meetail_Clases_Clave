using System;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private PersonajeStats stats;

    public PersonajeAnimaciones PersonajeAnimaciones { get; private set; }

    private void Awake()
    {

        PersonajeAnimaciones = GetComponent<PersonajeAnimaciones>();

    }

}