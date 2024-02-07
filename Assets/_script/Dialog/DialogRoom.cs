using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogRoom : MonoBehaviour
{
    [SerializeField] RoomItem room_item;
    [SerializeField] Button m_btn_create_room, m_btn_join_room;
    [SerializeField] RectTransform m_rect_content;
    [SerializeField] InputField m_input_room_name;
    List<RoomItem> lst_room = new List<RoomItem>();

    private void Awake()
    {
        m_btn_create_room = this.transform.Find("Panel").Find("BG").Find("btn_create_room").GetComponent<Button>();
        m_btn_join_room = this.transform.Find("Panel").Find("BG").Find("btn_join_room").GetComponent<Button>();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_btn_create_room.onClick.AddListener(() => { PressCreateRoom(); });
        m_btn_join_room.onClick.AddListener(() => { PressJoinRoom(); });
    }

    public void Init()
    {
        for (int i = 0; i < 5; i++)
        {
            PoolingRoom();
        }
    }

    public void PressCreateRoom()
    {

    }

    public void PressJoinRoom()
    {

    }

    void ResetData()
    {
        m_input_room_name.text = string.Empty;
    }

    private void OnDisable()
    {
        ResetData();
    }

    void PoolingRoom()
    {
        foreach (var room in lst_room)
        {
            if (!room.gameObject.activeSelf)
            {
                room.gameObject.SetActive(true);
                room.Init();
                return;
            }
            GameObject room_ob = Instantiate(room_item.gameObject, m_rect_content);
            var temp_room_item = room_ob.GetComponent<RoomItem>();
            temp_room_item.Init();
            lst_room.Add(temp_room_item);
        }
    }
}
