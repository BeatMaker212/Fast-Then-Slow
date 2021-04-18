using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject CompleteLevelUI;

    public GameObject DIEUI;

    public PlayerMove PlayerMovement;

    [SerializeField]
    string NextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("e");
        }

        if (Input.GetKeyDown("r"))
        {
            RestartLevel();
        }

        if (Input.GetKeyDown("q"))
        {
            Application.Quit();
        }
    }

    public void DieUI()
    {
        PlayerMovement.enabled = false;
        DIEUI.active = true;
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        PlayerMovement.enabled = false;
        CompleteLevelUI.active = true;
        Invoke("NextLevel", 3.5f);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(NextSceneName);
    }
}
