using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    [SerializeField] private GameObject lastHit;
    [SerializeField] private Vector3 collision = Vector3.zero;
    [SerializeField] private Rigidbody temp;

    [SerializeField] private float force;

    // Start is called before the first frame update
    void Start()
    {
        force = 100f;
        temp = null;
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            lastHit = hit.transform.gameObject;
            temp = hit.rigidbody;
            collision = hit.point;
        }

        Interact();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collision, 1.0f);
    }

    private void Interact()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (temp != null)
            {
                temp.AddForce(transform.forward * force);
                temp.useGravity = true;
            }
        }
    }
}
