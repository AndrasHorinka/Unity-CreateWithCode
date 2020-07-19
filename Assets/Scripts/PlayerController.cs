using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed;
    private float TurnSpeed;
    private float HorizontalInput;
    private float VerticalInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string HorizontalController;
    public string VerticalController;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 5.0f;
        TurnSpeed = 25.0f;
    }

    // Update is called once per frame
    void Update()
    {

        HorizontalInput = Input.GetAxis(HorizontalController);
        VerticalInput = Input.GetAxis(VerticalController);

        transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * HorizontalInput);

        if (Speed < 80)
        {
            Speed = Speed + Time.deltaTime * 10;
        }

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}

