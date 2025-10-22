using UnityEngine;

public class bowling : MonoBehaviour
{
    float zSpeed = 200.0f;
    public float xAxis = -0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // controls ball rotation
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Hai");
            xAxis -= 5
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            xAxis += 5
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            zSpeed -= 50;
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            zSpeed =+ 50;
        }

        if (Input.GetKeyDown("space")) {
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3(xAxis, 0.0f, -zSpeed));
        }
    }
}
