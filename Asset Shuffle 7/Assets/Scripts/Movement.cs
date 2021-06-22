using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float force;
    public ParticleSystem particleFX;

    private bool launched = false;  // Remove this

    /// <summary>
    /// Do not try this at home, kid. This is poor engineering at work.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="direction"></param>
    public void Fail(Rigidbody body, Vector3 direction)
    {
        if (launched)
            return;
        launched = true;
        // Convoluted operations with no purpose
        float x = (Random.Range(0, 2) * 2 - 1) * force;
        float y = (Random.Range(0, 2) * 2 - 1) * force;
        float z = (Random.Range(0, 2) * 2 - 1) * force;
        direction = new Vector3(x, y, z);
        particleFX.Play();
        body.AddForce(new Vector3(force * .1f, force, 0f));
        body.AddTorque(direction);
    }
}
