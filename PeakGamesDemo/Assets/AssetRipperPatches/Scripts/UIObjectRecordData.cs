using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UIObjectRecordData", menuName = "UI����/�����¼����", order = 1)]
public class UIObjectRecordData : ScriptableObject
{
    public List<UIObjectRecord> records = new List<UIObjectRecord>();
}

[System.Serializable]
public class UIObjectRecord
{
    public GameObject rootObject;
    public string rootName;
    public List<string> allNames = new List<string>();
    
    // ������ʾ�ö���
    public GameObject displayObject;
    public string displayName;
}
