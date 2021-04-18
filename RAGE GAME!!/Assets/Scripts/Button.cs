using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    public float Radius = 50f;

    Transform playertrans;

    public TextMeshPro Activatetxt;

    public GameObject Player;

    [SerializeField]
    string SceneName;

    public void Start()
    {
        playertrans = Player.transform;
        Invoke("TextOn", 2f);
    }

    public void FixedUpdate()
    {
        float distance = Vector3.Distance(playertrans.position, transform.position);
        if (distance <= Radius && Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(SceneName);
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }

    public void TextOn()
    {
        Activatetxt.enabled = true;
        Debug.Log("Enabled");
    }
}
