using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public float interactionDistance = 3f;  // ระยะที่สามารถเก็บไอเท็มได้
    private bool isNearItem = false;       // ตรวจสอบว่าผู้เล่นอยู่ใกล้ไอเท็มหรือไม่

    void Update()
    {
        // ตรวจสอบว่าผู้เล่นกดปุ่ม "E"
        if (isNearItem && Input.GetKeyDown(KeyCode.E))
        {
            // ทำอะไรบางอย่างเมื่อผู้เล่นกด "E" เช่นเก็บไอเท็ม
            PickUp();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าผู้เล่นเข้าสู่ Trigger ของไอเท็ม
        if (other.CompareTag("Player"))
        {
            isNearItem = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ถ้าผู้เล่นออกจาก Trigger
        if (other.CompareTag("Player"))
        {
            isNearItem = false;
        }
    }

    void PickUp()
    {
        // ทำการเก็บไอเท็ม (เช่น ลบไอเท็มออกจาก scene หรือเพิ่มใน inventory)
        Debug.Log("Item Picked Up!");
        Destroy(gameObject);  // ลบไอเท็มออกจาก scene
    }
}
