using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text MyTestLabel;
    public string str;

    public char ch;

    void Start()
    {
        str = "абвгдежзийклмнопрстуфхцчшщьыъэюя";
        string space = "  ";
        
        MyTestLabel.text = space;

        for (int i = 0; i < 19; i++)
        {
            MyTestLabel.text = MyTestLabel.text + str[i];
        }
    }

    void check()
    {
        if (str.Length > 0)
        {
            char tempch = str[0];
            if (str[0] == ch)
            {
                str = str.Remove(0, 1);

                MyTestLabel.text = $" <color=green>{tempch} </color>";
                for (int i = 0; i < 18; i++)
                {
                    if (i == str.Length)
                        break;
                    MyTestLabel.text = MyTestLabel.text + str[i];
                }
            }
            else if (str[0] != ch)
            {
                MyTestLabel.text = $"   <color=red>{tempch}</color>";
                for (int i = 1; i < 18; i++)
                {
                    if (i == str.Length)
                        break;
                    MyTestLabel.text = MyTestLabel.text + str[i];
                }
            }
        }
        else if (str.Length == 0)
        {
            MyTestLabel.text = str;
        }
    }
    
    // Update is calle once per frame
    void Update()
    {
        
        //А
        if (Input.GetKeyDown("f"))
        {
            ch = 'а';
            check();
        }
        
        //Б
        if (Input.GetKeyDown(","))
        {
            ch = 'б';
            check();
        }
        
        //В
        if (Input.GetKeyDown("d"))
        {
            ch = 'в';
            check();
        }
        
        //Г
        if (Input.GetKeyDown("u"))
        {
            ch = 'г';
            check();
        }
        
        //Д
        if (Input.GetKeyDown("l"))
        {
            ch = 'д';
            check();
        }
        
        //Е
        if (Input.GetKeyDown("t"))
        {
            ch = 'е';
            check();
        }
        
        //Ж
        if (Input.GetKeyDown(";"))
        {
            ch = 'ж';
            check();
        }
        
        //З
        if (Input.GetKeyDown("p"))
        {
            ch = 'з';
            check();
        }
        
        //И
        if (Input.GetKeyDown("b"))
        {
            ch = 'и';
            check();
        }
        
        //Й
        if (Input.GetKeyDown("q"))
        {
            ch = 'й';
            check();
        }
        
        //К
        if (Input.GetKeyDown("r"))
        {
            ch = 'к';
            check();
        }
        
        //Л
        if (Input.GetKeyDown("k"))
        {
            ch = 'л';
            check();
        }
        
        //М
        if (Input.GetKeyDown("v"))
        {
            ch = 'м';
            check();
        }
        
        //Н
        if (Input.GetKeyDown("y"))
        {
            ch = 'н';
            check();
        }
        
        //О
        if (Input.GetKeyDown("j"))
        {
            ch = 'о';
            check();
        }
        
        //П
        if (Input.GetKeyDown("g"))
        {
            ch = 'п';
            check();
        }
        
        //Р
        if (Input.GetKeyDown("h"))
        {
            ch = 'р';
            check();
        }
        
        //С
        if (Input.GetKeyDown("c"))
        {
            ch = 'с';
            check();
        }
        
        //Т
        if (Input.GetKeyDown("n"))
        {
            ch = 'т';
            check();
        }
        
        //У
        if (Input.GetKeyDown("e"))
        {
            ch = 'у';
            check();
        }
        
        //Ф
        if (Input.GetKeyDown("a"))
        {
            ch = 'ф';
            check();
        }
        
        //Х
        if (Input.GetKeyDown("["))
        {
            ch = 'х';
            check();
        }
        
        //Ц
        if (Input.GetKeyDown("w"))
        {
            ch = 'ц';
            check();
        }
        
        //Ч
        if (Input.GetKeyDown("x"))
        {
            ch = 'ч';
            check();
        }
        
        //Ш
        if (Input.GetKeyDown("i"))
        {
            ch = 'ш';
            check();
        }
        
        //Щ
        if (Input.GetKeyDown("o"))
        {
            ch = 'щ';
            check();
        }
        
        //Ъ
        if (Input.GetKeyDown("]"))
        {
            ch = 'ъ';
            check();
        }
        
        //Ы
        if (Input.GetKeyDown("s"))
        {
            ch = 'ы';
            check();
        }
        
        //Ь
        if (Input.GetKeyDown("m"))
        {
            ch = 'ь';
            check();
        }
        
        //Э
        if (Input.GetKeyDown("'"))
        {
            ch = 'э';
            check();
        }
        
        //Ю
        if (Input.GetKeyDown("."))
        {
            ch = 'ю';
            check();
        }
        
        //Я
        if (Input.GetKeyDown("z"))
        {
            ch = 'я';
            check();
        }
    }
}