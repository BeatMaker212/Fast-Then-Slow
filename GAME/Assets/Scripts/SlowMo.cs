using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    public bool SlowMoActive;
    public float SlowMoTime = 5f;
    //public bool IsPlayer = false;
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
        if(SlowMoActive == false)
        {
            Debug.Log("Recieved request");
            SlowMoActive = true;
            Time.timeScale = 0.5f;
            Invoke("SlowMoEnd", SlowMoTime);
            Debug.Log("Recieved request time frozen");
            FindObjectOfType<PlayerMove>().SlowMoNo();
        }

    }

    public void SlowMoEnd()
    {
        if (SlowMoActive == true)
        {
            FindObjectOfType<PlayerMove>().NormSpeed();
            SlowMoActive = false;
            Time.timeScale = 1f;
            Debug.Log("Time returned to normal");
        }
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
