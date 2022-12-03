using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float TimeCount = 0;
    float TimeCount2 = 0;
    void Start()
    {
     //   StartCoroutine(rotateCoin());
    }




    IEnumerator rotateCoin()
    {

        transform.rotation= Quaternion.identity;
        yield return new WaitForFixedUpdate();
    }

    // Update is called once per frame
    void Update()
    {


        TimeCount += Time.deltaTime;

        if (TimeCount > 360) TimeCount = 0f;

        Vector3 newRotation = new Vector3(TimeCount * 20, TimeCount * 10, TimeCount * 20);
       transform.eulerAngles = newRotation;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print(TimeCount);
            Destroy(gameObject);
        }
        else
            print(" OnCollisionEnter TimeCount" + collision.gameObject.tag.ToString());

    }


    private void OnTriggerEnter(Collider other)


    {
        TimeCount2 += Time.deltaTime;

        if (TimeCount2 > 360) TimeCount2 = 0f;

        if (other.gameObject.tag == "Player")
        {
            print("OntriOnTriggerEnter   " + TimeCount2.ToString());
            Destroy(gameObject);
        }
        else
            print(" OntriOnTriggerEnter TimeCount " + other.gameObject.tag.ToString());
        print(" gameObject " + other.gameObject.ToString());

    }
}
