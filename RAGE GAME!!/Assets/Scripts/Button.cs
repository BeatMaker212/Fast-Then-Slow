using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public float Radius = 50f;

    Transform playertrans;

    public GameObject Player;

    [SerializeField]
    string SceneName;

    public void Start()
    {
        playertrans = Player.transform;
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
}
