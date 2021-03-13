using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class krig6 : MonoBehaviour
{
    public Camera cam;
    public Text FOV;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 100, 0);

        if (rb.position.y < 100)
        {
            SceneManager.SetActiveScene(SceneManager.GetActiveScene());
        }
    }
}
