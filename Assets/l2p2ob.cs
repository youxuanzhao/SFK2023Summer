using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class l2p2ob : MonoBehaviour
{
    // Start is called before the first frame update
    public CinemachineVirtualCamera cvc;
    bool end = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(transition());
        IEnumerator transition()
        {
            cvc.enabled = false;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("Level3");
        }
    }
    
}
