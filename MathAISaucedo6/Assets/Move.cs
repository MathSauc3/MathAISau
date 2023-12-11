using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 2.0f;
    public Transform goal;
    public float accuracy = 0.01f;

    void Start()
    {
       
    }

    private void LateUpdate()
    {
        this.transform.LookAt(goal.position);
        Vector3 direction = goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction,Color.red);
        if (direction.magnitude > accuracy)  
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

    }
}
