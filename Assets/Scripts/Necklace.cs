using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necklace : MonoBehaviour
{
    public PlayerController player;
    public InteractiveParent parent;
    public Collision2D collision;

    
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (parent.use)
        {
            player.HasNecklace = true;
            this.gameObject.SetActive(false);
        }
    }
}
