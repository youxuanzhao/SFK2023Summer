using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class statcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public InteractiveParent ip;
    public GameObject lt;

    // Update is called once per frame
    void Update()
    {
        if (ip.use)
        {
            lt.SetActive(true);
            StartCoroutine(switc());
        }

        IEnumerator switc()
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Level4");
        }
        
    }
    
}
