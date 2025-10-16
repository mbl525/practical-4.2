using UnityEngine;

public class dungeon : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = target.transform.position + offset;
        transform.position = newPos;
    }
}
