using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Entrada : MonoBehaviour
{

    public GameObject Menu;
    public GameObject Aviso;

    void Start()
    {
        Screen.SetResolution(1200, 670, false);
    }

    public void ChanceEscene(string name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }

    public void mostraraviso()
    {
        Menu.SetActive(false);
        Aviso.SetActive(true);
    }
}
