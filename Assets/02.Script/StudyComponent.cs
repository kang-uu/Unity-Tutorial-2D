using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public string changeName;


    void Start()
    {
        obj = GameObject.Find("Main Camera"); // Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���

        obj.name = changeName;
    }

}