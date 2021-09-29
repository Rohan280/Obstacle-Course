using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] int spinSpeed = 100;
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Spin();
    }

    void Spin()
    {
        float yvalue = spinSpeed;//* Time.deltaTime;

        Constraints();
        rb.AddTorque(0, spinSpeed, 0);

        //Vector3 targetRotation = transform.eulerAngles + new Vector3(0, spinSpeed, 0);
        //rb.MoveRotation( Quaternion.Euler(targetRotation));

    }

    void Constraints()
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationX;
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;
        rb.constraints = RigidbodyConstraints.FreezePosition;
        
    }
}
