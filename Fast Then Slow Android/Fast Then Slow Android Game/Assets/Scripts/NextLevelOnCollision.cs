using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string Player;

    [SerializeField]
    string SceneName;

    public bool NextLevel = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            if (NextLevel == true)
            {
                FindObjectOfType<GameManager>().CompleteLevel();
            }
            else if (NextLevel == false)
            {
                FindObjectOfType<GameManager>().DieUI();
            }

    }
}
