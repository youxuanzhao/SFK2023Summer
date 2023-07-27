using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bishop : MonoBehaviour
{
    public InteractiveParent ip;
    public PlayerController player;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if(ip.inRange && Input.GetKeyDown(KeyCode.E) && player.HasNecklace)
        {
            SceneManager.LoadScene("Puzzle1");
        }
    }
}
