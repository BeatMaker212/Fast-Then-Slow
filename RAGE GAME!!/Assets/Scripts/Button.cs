using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    public float Radius = 50f;

    Transform playertrans;

    public GameObject Activatetxt;

    public GameObject Player;

    public bool dieOnTime = false;

    public bool levelComplete = false;

    public float DieTime = 7.5f;

    [SerializeField]
    string SceneName;

    public void Start()
    {
        playertrans = Player.transform;
        if (dieOnTime == true)
        {
            Invoke("DIE", DieTime);
        }

    }

    public void FixedUpdate()
    {
        float distance = Vector3.Distance(playertrans.position, transform.position);
        if (distance <= Radius)
        {
            NextLevel();
            Debug.Log("ree");
        }

        if (distance <= Radius)
        {
            Activatetxt.active = true;
        }

        if (distance >= Radius)
        {
            Activatetxt.active = false;
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }

    public void DIE()
    {
        if (levelComplete == false)
        {
            FindObjectOfType<GameManager>().DieUI();
        }
    }

    public void NextLevel()
    {
        levelComplete = true;
        FindObjectOfType<GameManager>().CompleteLevel();
    }
}
