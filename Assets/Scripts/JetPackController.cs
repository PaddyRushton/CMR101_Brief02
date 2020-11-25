using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackController : MonoBehaviour
{
    
        public GameObject jetNozzle;


        private void Update()
        {
            ThrottleOn();
        }


        public void ThrottleOn()
        {
            Vector3 jetDirection = jetNozzle.transform.up;
            if (Input.GetAxis("Axis1D.PrimaryIndexTrigger") > 0.2f)
            {
                jetNozzle.GetComponent<Rigidbody>().AddForce(jetDirection*1000, ForceMode.VelocityChange);
            }

            else if (Input.GetAxis("Axis1D.PrimaryIndexTrigger") < 0.2f)
            {
                jetNozzle.GetComponent<Rigidbody>().AddForce(jetDirection * 0, ForceMode.VelocityChange);
            }
        }
    
}

