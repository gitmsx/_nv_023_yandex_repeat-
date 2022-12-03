using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    float TimeCount=0;
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
        if(collision.gameObject.tag == "Player") 
        {
            print(TimeCount);
            Destroy(gameObject);
        }
        else
            print("TimeCount");

    }
}
