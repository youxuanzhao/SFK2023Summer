using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2trig : MonoBehaviour
{
    public InteractiveParent ip;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (ip.use)
        {
            SceneManager.LoadScene("Puzzle2");
        }
    }
}
