using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class roomdetect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject map;
    public GameObject decorations;
    public Light2D maplight;
    public Light2D roomlight;
    private bool inRoom;
    public float dimSpeed;
    public int mlawakeStatus;
    public int rlawakeStatus;

    private void Awake()
    {
        maplight.intensity = mlawakeStatus;
        roomlight.intensity = rlawakeStatus;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRoom = true;
        /*cover.SetActive(false);
        map.SetActive(false);
        decorations.SetActive(false);
        */
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inRoom = false;
        /*cover.SetActive(true);
        map.SetActive(true);
        decorations.SetActive(true);
        */
    }
    private void FixedUpdate()
    {
        if(inRoom == true && maplight.intensity>=0 && roomlight.intensity<=1)
        {
            maplight.intensity -= Time.fixedDeltaTime * dimSpeed;
            roomlight.intensity += Time.fixedDeltaTime * dimSpeed;
        }
        else if(inRoom == false && roomlight.intensity >= 0 && maplight.intensity <= 1)
        {
            maplight.intensity += Time.fixedDeltaTime * dimSpeed;
            roomlight.intensity -= Time.fixedDeltaTime * dimSpeed;
        }
    }
}
