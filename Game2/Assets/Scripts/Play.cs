using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField]
    string strscenename;
    public void StartGame ()
    {
        SceneManager.LoadScene(strscenename);
    }
}
