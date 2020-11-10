using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter()
    {
        LapCompTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
