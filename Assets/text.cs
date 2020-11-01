using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class text : MonoBehaviour
{
    public Text MyTestLabel;
    public string str;

    public char ch;

    void Start()
    {
        str = textRand();
        string space = "  ";
        
        MyTestLabel.text = space;

        for (int i = 0; i < 19; i++)
        {
            if (i == str.Length)
                break;
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
                if (ch == '\n')
                    MyTestLabel.text = $"  <color=grey>{'|'}</color>";
                else
                    MyTestLabel.text = $" <color=green>{tempch}</color>" + $"<color=grey>{'|'}</color>";
                for (int i = 0; i < 18; i++)
                {
                    if (i == str.Length)
                        break;
                    MyTestLabel.text = MyTestLabel.text + str[i];
                }
            }
            else if (str[0] != ch)
            {
                MyTestLabel.text = $"  <color=red>{'|'}</color>" + $"<color=red>{tempch}</color>";
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

    string textRand()
    {
        string filename = " ";
        Random rnd = new Random();
        int tempRand = rnd.Next(3);
        if (tempRand == 0)
            filename = "Text1.txt";
        else if (tempRand == 1)
            filename = "Text2.txt";
        else if (tempRand == 2)
            filename = "Text3.txt";
        
        byte[] bytes;
        bytes = System.IO.File.ReadAllBytes(filename);
        
        string tempstr = Encoding.UTF8.GetString(bytes);
        
        return tempstr;
    }
    
    // Update is calle once per frame
    void Update()
    {
        //SHIFT
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            //А
            if (Input.GetKeyDown("f"))
            {
                ch = 'А';
                check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                ch = 'Б';
                check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                ch = 'В';
                check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                ch = 'Г';
                check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                ch = 'Д';
                check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                ch = 'Е';
                check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = 'Ё';
                check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                ch = 'Ж';
                check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                ch = 'З';
                check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                ch = 'И';
                check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                ch = 'Й';
                check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                ch = 'К';
                check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                ch = 'Л';
                check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                ch = 'М';
                check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                ch = 'Н';
                check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                ch = 'О';
                check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                ch = 'П';
                check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                ch = 'Р';
                check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                ch = 'С';
                check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                ch = 'Т';
                check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                ch = 'У';
                check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                ch = 'Ф';
                check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                ch = 'Х';
                check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                ch = 'Ц';
                check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                ch = 'Ч';
                check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                ch = 'Ш';
                check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                ch = 'Щ';
                check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                ch = 'Ъ';
                check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                ch = 'Ы';
                check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                ch = 'Ь';
                check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                ch = 'Э';
                check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                ch = 'Ю';
                check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                ch = 'Я';
                check();
            }
            
            //запятая
            if (Input.GetKeyDown("/"))
            {
                ch = ',';
                check();
            }

            //воскл знак
            if (Input.GetKeyDown("1"))
            {
                ch = '!';
                check();
            }
            
            //ковычки
            if (Input.GetKeyDown("2"))
            {
                ch = '"';
                check();
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                ch = ';';
                check();
            }
            
            //двоеточие
            if (Input.GetKeyDown("6"))
            {
                ch = ':';
                check();
            }
            
            //вопр знак
            if (Input.GetKeyDown("7"))
            {
                ch = '?';
                check();
            }
            
            //звездочка
            if (Input.GetKeyDown("8"))
            {
                ch = '*';
                check();
            }
            
            //открыв скобка
            if (Input.GetKeyDown("9"))
            {
                ch = '(';
                check();
            }
            
            //закрыв скобка
            if (Input.GetKeyDown("0"))
            {
                ch = ')';
                check();
            }
        }
        else
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
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = 'ё';
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
            
            //пробел
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ch = ' ';
                check();
            }
            
            //точка
            if (Input.GetKeyDown("/"))
            {
                ch = '.';
                check();
            }
            
            //enter
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ch = '↵';
                check();
                ch = '\r';
                check();
                ch = '\n';
                check();
            } 
            
            //тире
            if (Input.GetKeyDown("-"))
            {
                ch = '-';
                check();
            }
        }
        
    }
}