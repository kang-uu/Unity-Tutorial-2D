using UnityEngine;
public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {

        CreateAmongus();

    }

    public void CreateAmongus()
    {

        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";
        Transform objTf = obj.transform;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {objTf.childCount}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(objTf.childCount - 1).name}");

    }

}