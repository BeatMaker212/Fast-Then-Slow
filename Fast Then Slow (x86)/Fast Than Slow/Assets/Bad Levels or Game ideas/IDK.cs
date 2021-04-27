using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IDK : MonoBehaviour
{
    public GameObject GoodJobTXT;

    public GameObject QTXT;

    public GameObject LOL;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GJ", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GJ()
    {
        GoodJobTXT.active = true;
        QTXT.active = false;
        Invoke("NowQ", 5f);
    }

    public void NowQ()
    {
        LOL.active = true;
        GoodJobTXT.active = false;
        Invoke("NextLevel", 7.5f);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
