using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class cloudcontrol : MonoBehaviour
{
    public Cloud cloud1;
    public Cloud cloud2;
    public Cloud cloud3;

    public Light2D light2d;

    private bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        cloud1.enabled = true;
        cloud2.enabled = false;
        cloud3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cloud1.swiped)
        {
            cloud2.enabled = true;
        }
        if (cloud2.swiped)
        {
            cloud1.enabled = false;
            cloud3.enabled = true;
        }
        if (cloud3.swiped)
        {
            StartCoroutine(delay());
        }
        if (end)
        {
            if(light2d.intensity > 0)
            {
                light2d.intensity -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Level2");
            }
            
        }

    }

    IEnumerator delay()
    {
        cloud2.enabled = false;
        yield return new WaitForSeconds(3);
        cloud3.swiped = false;
        end = true;
    }
}
