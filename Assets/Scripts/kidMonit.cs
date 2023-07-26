using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kidMonit : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController Player;

    // Update is called once per frame
    void Update()
    {
        if (Player.HasNecklace)
        {
            this.gameObject.SetActive(false);
        }
    }
}
