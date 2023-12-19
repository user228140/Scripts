using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

        private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= 2; 
    }

        private void OnTriggerExit(Collider other) 
    {
        other.GetComponent<Jump>().jumpStrength /= 2;
    }
}
 