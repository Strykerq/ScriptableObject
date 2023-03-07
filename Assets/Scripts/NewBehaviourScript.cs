using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        var aLlInfo = Resources.LoadAll<CreateScriptableObject>("");
        foreach (var Create in aLlInfo)
        {
            Debug.Log(Create.id);
            Debug.Log(Create.prefab);
            Debug.Log(Create.amount);
        }
    }
    
}
