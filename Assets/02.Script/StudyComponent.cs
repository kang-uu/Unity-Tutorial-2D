using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        
    }

}