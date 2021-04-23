using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrocaCena : MonoBehaviour
{
    public string NomeDaCena;
    public void changeS()
    {
        SceneManager.LoadScene(NomeDaCena);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
