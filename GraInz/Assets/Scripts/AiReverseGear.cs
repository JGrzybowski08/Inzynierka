using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class AiReverseGear : MonoBehaviour
{
    public GameObject AiCar;
    public float SpeedAiCar;
    public bool Started = false;
    public bool test = false;

    Rigidbody RbAi;

    public float Acceleration;
    public float MinAcceleration = 0.0f;
    public float MaxAcceleration = 30.0f;
    public float DecelerationRate = 10.0f;

    void Start()
    {
            
            StartCoroutine(StopCar());

    }

    private void Update()
    {
        RbAi = AiCar.GetComponent<Rigidbody>();
        SpeedAiCar = RbAi.velocity.magnitude * 3.6f;
    }


    void goBackwards()
    {

        Acceleration = DecelerationRate * Time.deltaTime * -50;
        //Acceleration = Mathf.Clamp(Acceleration, MinAcceleration, MaxAcceleration);
        AiCar.transform.Translate(Vector3.forward * Acceleration);

    }

    IEnumerator StopCar()
    {
        while (true) { 
        yield return new WaitForSeconds(0.5f);

            if(SpeedAiCar > 5)
            {
                Started = true;
            }


        if (Started && SpeedAiCar < 0.5f)
        {

            test = true;
            AiCar.GetComponent<CarAIControl>().enabled = false;
            AiCar.GetComponent<CarController>().enabled = false;
            goBackwards();
            yield return new WaitForSeconds(1);
            AiCar.GetComponent<CarAIControl>().enabled = true;
            AiCar.GetComponent<CarController>().enabled = true;
        }

        }

    }
}

