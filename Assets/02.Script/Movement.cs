using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float moveSpeed = 10f;
    float moveSpeed1;
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + Vector3.forward * moveSpeed;

        if (Input.GetKey(KeyCode.W)) // 앞으로가는기능
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) //뒤로가는기능 
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) //왼쪽으로가는기능
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) //오른쪽으로가는기능
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
