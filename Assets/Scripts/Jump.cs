using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector2 JumpForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpForce);
            GetComponent<AudioSource>().Play();

        }


    }
}
