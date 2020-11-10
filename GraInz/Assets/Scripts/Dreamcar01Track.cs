using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityStandardAssets.Vehicles.Car;

public class Dreamcar01Track : MonoBehaviour
{

    public GameObject TheMarker;
    public GameObject Mark00;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public int MarkTracker;

    

    void Update()
    {
        
        switch (MarkTracker)
        {
            case 0:
                TheMarker.transform.position = Mark01.transform.position;
                break;
            case 1:
                TheMarker.transform.position = Mark02.transform.position;
                break;
            case 2:
                TheMarker.transform.position = Mark03.transform.position;
                break;
            case 3:
                TheMarker.transform.position = Mark04.transform.position;
                break;
            case 4:
                TheMarker.transform.position = Mark05.transform.position;
                break;
            case 5:
                TheMarker.transform.position = Mark06.transform.position;
                break;
            default:
                TheMarker.transform.position = Mark00.transform.position;
                break;
        }


    }

        IEnumerator OnTriggerEnter(Collider collision)
        {
            if(collision.gameObject.tag == "Dreamcar01")
            {
                this.GetComponent<BoxCollider>().enabled = false;
                MarkTracker += 1;
                if(MarkTracker == 6)
                {
                    MarkTracker = 0;
                }
                yield return new WaitForSeconds(1);
                this.GetComponent<BoxCollider>().enabled = true;
            }
        }

    }
