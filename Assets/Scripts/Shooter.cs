using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefabes;

   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            var projectile = Instantiate(
                projectilePrefabes,
                transform.position,
                projectilePrefabes.transform.rotation);
        }
    }
}
   