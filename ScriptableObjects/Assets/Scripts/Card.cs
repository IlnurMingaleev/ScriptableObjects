using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    [SerializeField] private Hero hero;

    [SerializeField] private Image img;
    [SerializeField] private new TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI age;
    [SerializeField] private TextMeshProUGUI location;
    
    
    // Start is called before the first frame update
    void Start()
    {
        img.sprite = hero.Img;
        name.text +=" " + hero.Name;
        age.text +=" " + hero.Age.ToString();
        location.text += " " + hero.Location;
    }

    
}
