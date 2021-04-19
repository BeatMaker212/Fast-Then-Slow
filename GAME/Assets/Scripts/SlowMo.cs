using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    public bool SlowMoActive;
    public float SlowMoTime = 5f;
    //public bool IsPlayer = false;
    GameObject[] notplayer;
    public string speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Time.timeScale.ToString("0");
    }

    public void SlowMoStart()
    {
        Debug.Log("Recieved request");
        SlowMoActive = true;
        //if (IsPlayer == false)
        //{
            Time.timeScale = 0.5f;
            //SlowMoActive = true;
            //GetComponent<Rigidbody>().isKinematic = true;
            Invoke("SlowMoEnd", SlowMoTime);
            Debug.Log("Recieved request time frozen");
        //}

    }

    public void SlowMoEnd()
    {
        SlowMoActive = false;
        //if (IsPlayer == true)
        //{
            Time.timeScale = 1f;
            Debug.Log("Time returned to normal");
            //tComponent<Rigidbody>().isKinematic = false;
        //}
    }

    public void SPEEEEEDStart()
    {
        Time.timeScale = 3f;
    }

    public void SPEEEEEDEnd()
    {
        Invoke("SPEEEEEDStart", SlowMoTime);
        Time.timeScale = 1f;
    }
}
