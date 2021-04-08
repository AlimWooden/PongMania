using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddedForce : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(-10f, 0f, -30f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
    }
}
