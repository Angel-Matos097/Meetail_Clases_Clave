using System;
using System.Collections;
using UnityEngine;

public enum TipoPersonaje
{
    Player,
    IA
}

public class PersonajeFX : MonoBehaviour
{
    [Header("Pooler")] 
    [SerializeField] private ObjectPooler pooler;
    
    [Header("Config")] 
    [SerializeField] private GameObject canvasTextoAnimacionPrefab;
    [SerializeField] private Transform canvasTextoPosicion;

    [Header("Tipo")] 
    [SerializeField] private TipoPersonaje tipoPersonaje;


}
