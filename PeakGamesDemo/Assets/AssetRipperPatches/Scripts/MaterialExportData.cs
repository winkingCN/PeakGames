using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class FloatParam
{
    public string key;
    public float value;
}
[System.Serializable]
public class IntParam
{
    public string key;
    public int value;
}

// �����л����Զ�����ɫ��
[System.Serializable]
public class MyColor
{
    public float r;
    public float g;
    public float b;
    public float a;

    public MyColor() { }

    public MyColor(Color color)
    {
        r = color.r;
        g = color.g;
        b = color.b;
        a = color.a;
    }
}

[System.Serializable]
public class ColorParam
{
    public string key;
    public MyColor value;
}

[System.Serializable]
public class MaterialExportData
{
    public string name;
    public List<FloatParam> floats = new List<FloatParam>();
    public List<IntParam> ints = new List<IntParam>();
    public List<ColorParam> colors = new List<ColorParam>();
}
