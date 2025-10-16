using UnityEngine;

public class followCamera : MonoBehaviour
{
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find ("Car");
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.LookAt(target.transform);
    }
}
