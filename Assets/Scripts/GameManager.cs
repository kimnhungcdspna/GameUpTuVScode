using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int tongdiem = 0;
    [SerializeField] private TextMeshProUGUI DiemText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CapnhatDiem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void congdiem(int diem)
        { tongdiem += diem;
          CapnhatDiem();
         }
    private void CapnhatDiem()
    {
        DiemText.text = tongdiem.ToString();
    }    
}
