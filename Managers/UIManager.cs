using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [Header("Stats")]
    [SerializeField] private PersonajeStats stats;

    [Header("Paneles")]
    [SerializeField] private GameObject panelStats;

    #region Paneles

    public void AbrirCerrarPanelStats()
    {
        panelStats.SetActive(!panelStats.activeSelf);
    }

    #endregion
}
