using UnityEngine;

[CreateAssetMenu (fileName = "Info",menuName = "Address/NewInfo")]
public class CreateScriptableObject : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _amount;

    public string id => this._id;
    public GameObject prefab => this._prefab;
    public int amount => this._amount;
}
