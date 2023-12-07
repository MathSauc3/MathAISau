using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    float speed = 0.5f;

    void Start()
    {
        direction = goal.transform.position - transform.position;
    }

    private void LateUpdate()
    {
        Vector3 velocity = direction.normalized * speed * Time.deltaTime;
        this.transform.position = this.transform.position + velocity;

    }
}
