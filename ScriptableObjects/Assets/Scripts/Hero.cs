using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "New Hero", menuName = "Hero")]
public class Hero : ScriptableObject
{
    [SerializeField] private Sprite img;
    [SerializeField] private new string name;
    [SerializeField] private int age;
    [SerializeField] private string location;
    
    public Sprite Img 
    {
        get 
        {
            return img;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
    }
    public string Location
    {
        get
        {
            return location;
        }
    }
}
