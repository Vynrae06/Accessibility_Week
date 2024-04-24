using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isFlat = true;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 hopefulAcceleration = Input.gyro.userAcceleration;
        Vector3 hopefulAcceleration = Input.acceleration;
        float limitValue = 0.10f;

        float accelerationX = hopefulAcceleration.x;
        float accelerationY = hopefulAcceleration.y;
        float accelerationZ = hopefulAcceleration.z;
        
        if(accelerationX >= limitValue)
            transform.Translate(new Vector3(-accelerationX/10, 0, 0));
        else if(accelerationX <= -limitValue)
            transform.Translate(new Vector3(-accelerationX/10, 0, 0));
        //if(accelerationY != 0)
            //transform.Translate(0, accelerationY, 0);
        
        // Debug.Log(Input.acceleration.x);
        Debug.Log(hopefulAcceleration);
    }
}
