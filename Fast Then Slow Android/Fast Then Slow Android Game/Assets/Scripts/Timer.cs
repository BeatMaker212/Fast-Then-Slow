using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI TimeTXT;

    private float startTime;

    private bool StopTimeBool = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (StopTimeBool == false)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            TimeTXT.text = minutes + ":" + seconds;
        }
    }

    public void StopTimer()
    {
        TimeTXT.color = Color.green;
        StopTimeBool = true;
    }
}
