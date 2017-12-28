using UnityEngine;
using System.Collections;

public class Raycasting : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Ray GRay = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(GRay, out hit, 1000000))
        {
            Debug.DrawRay(transform.position, transform.forward, Color.green, 1);

        }
    }
}
