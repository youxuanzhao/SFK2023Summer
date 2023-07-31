using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pz2monit : MonoBehaviour
{
    // Start is called before the first frame update
    public cursdetect curs1;
    public cursdetect curs2;

    private float timecount = 0f;

    // Update is called once per frame
    void Update()
    {
        timecount += Time.deltaTime;
        if(timecount >= 10 || curs1.touched || curs2.touched)
        {
            SceneManager.LoadScene("Level2part2");
        }
    }
}
