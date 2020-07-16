using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Vehicle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vehicle.transform.position + new Vector3(0, 5, -20);
    }
}
