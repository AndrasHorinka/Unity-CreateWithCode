using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(15, 0, 0);
        transform.rotation = Quaternion.Euler(0, 270, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Plane.transform.position + offset;
    }
}
