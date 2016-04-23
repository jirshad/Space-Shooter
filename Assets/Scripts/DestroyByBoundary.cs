using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{
    //sample code from documentation
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
