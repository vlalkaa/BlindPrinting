using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = System.Random;

public class text : MonoBehaviour
{
    public Text textMain;
    public Text textInform;
    public Text textStatistics;
    private string str;
    private char ch;
    private int lengthStr;
    private Stopwatch stopWatch = new Stopwatch();
    private int[] numButton = new int [104];
    private int oneEnter = 1;

    void Start()
    {
        str = textRand();
        string space = "  ";

        lengthStr = str.Length;
        
        textMain.text = space;

        for (int i = 0; i < 19; i++)
        {
            if (i == str.Length)
                break;
            textMain.text = textMain.text + str[i];
        }

        for (int i = 0; i < 104; i++)
        {
            numButton[i] = 0;
        }
    }

    void check(int numChar)
    {
        if (str.Length > 0)
        {
            char tempch = str[0];
            
            if (str[0] == ch)
            {
                str = str.Remove(0, 1);
                if (ch == '\n')
                    textMain.text = $"  <color=grey>{'|'}</color>";
                else
                    textMain.text = $" <color=green>{tempch}</color>" + $"<color=grey>{'|'}</color>";
                for (int i = 0; i < 18; i++)
                {
                    if (i == str.Length)
                        break;
                    textMain.text = textMain.text + str[i];
                }
            }
            else if (str[0] != ch)
            {
                numButton[NumChar(str[0])]++;
                textMain.text = $"  <color=red>{'|'}</color>" + $"<color=red>{tempch}</color>";
                for (int i = 1; i < 18; i++)
                {
                    if (i == str.Length)
                        break;
                    textMain.text = textMain.text + str[i];
                }
            }
        }
        else if (str.Length == 0)
        {
            textMain.text = str;
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

    void pressingKeyboard()
    {
        //SHIFT
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            //А
            if (Input.GetKeyDown("f"))
            {
                ch = 'А';
                check(1);
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                ch = 'Б';
                check(2);
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                ch = 'В';
                check(3);
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                ch = 'Г';
                check(4);
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                ch = 'Д';
                check(5);
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                ch = 'Е';
                check(6);
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = 'Ё';
                check(7);
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                ch = 'Ж';
                check(8);
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                ch = 'З';
                check(9);
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                ch = 'И';
                check(10);
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                ch = 'Й';
                check(11);
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                ch = 'К';
                check(12);
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                ch = 'Л';
                check(13);
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                ch = 'М';
                check(14);
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                ch = 'Н';
                check(15);
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                ch = 'О';
                check(16);
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                ch = 'П';
                check(17);
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                ch = 'Р';
                check(18);
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                ch = 'С';
                check(19);
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                ch = 'Т';
                check(20);
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                ch = 'У';
                check(21);
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                ch = 'Ф';
                check(22);
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                ch = 'Х';
                check(23);
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                ch = 'Ц';
                check(24);
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                ch = 'Ч';
                check(25);
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                ch = 'Ш';
                check(26);
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                ch = 'Щ';
                check(27);
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                ch = 'Ъ';
                check(28);
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                ch = 'Ы';
                check(29);
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                ch = 'Ь';
                check(30);
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                ch = 'Э';
                check(31);
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                ch = 'Ю';
                check(32);
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                ch = 'Я';
                check(33);
            }
            
            //запятая
            if (Input.GetKeyDown("/"))
            {
                ch = ',';
                check(0);
            }

            //воскл знак
            if (Input.GetKeyDown("1"))
            {
                ch = '!';
                check(34);
            }
            
            //ковычки
            if (Input.GetKeyDown("2"))
            {
                ch = '"';
                check(35);
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                ch = ';';
                check(36);
            }
            
            //двоеточие
            if (Input.GetKeyDown("6"))
            {
                ch = ':';
                check(37);
            }
            
            //вопр знак
            if (Input.GetKeyDown("7"))
            {
                ch = '?';
                check(38);
            }
            
            //звездочка
            if (Input.GetKeyDown("8"))
            {
                ch = '*';
                check(39);
            }
            
            //открыв скобка
            if (Input.GetKeyDown("9"))
            {
                ch = '(';
                check(40);
            }
            
            //закрыв скобка
            if (Input.GetKeyDown("0"))
            {
                ch = ')';
                check(41);
            }
        }
        else
        { 
            //А
            if (Input.GetKeyDown("f"))
            {
                ch = 'а';
                check(1);
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                ch = 'б';
                check(2);
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                ch = 'в';
                check(3);
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                ch = 'г';
                check(4);
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                ch = 'д';
                check(5);
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                ch = 'е';
                check(6);
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = 'ё';
                check(7);
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                ch = 'ж';
                check(8);
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                ch = 'з';
                check(9);
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                ch = 'и';
                check(10);
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                ch = 'й';
                check(11);
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                ch = 'к';
                check(12);
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                ch = 'л';
                check(13);
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                ch = 'м';
                check(14);
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                ch = 'н';
                check(15);
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                ch = 'о';
                check(16);
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                ch = 'п';
                check(17);
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                ch = 'р';
                check(18);
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                ch = 'с';
                check(19);
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                ch = 'т';
                check(20);
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                ch = 'у';
                check(21);
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                ch = 'ф';
                check(22);
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                ch = 'х';
                check(23);
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                ch = 'ц';
                check(24);
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                ch = 'ч';
                check(25);
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                ch = 'ш';
                check(26);
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                ch = 'щ';
                check(27);
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                ch = 'ъ';
                check(28);
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                ch = 'ы';
                check(29);
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                ch = 'ь';
                check(30);
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                ch = 'э';
                check(31);
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                ch = 'ю';
                check(32);
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                ch = 'я';
                check(33);
            }
            
            //пробел
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ch = ' ';
                check(42);
            }
            
            //точка
            if (Input.GetKeyDown("/"))
            {
                ch = '.';
                check(43);
            }
            
            //enter
            if (Input.GetKeyDown(KeyCode.Return))//исправить тройной баг
            {
                ch = '↵';
                check(44);
                ch = '\r';
                check(44);
                ch = '\n';
                check(44);
            } 
            
            //тире
            if (Input.GetKeyDown("-"))
            {
                ch = '-';
                check(45);
            }
        }
    }

    void charactedInMinutes()
    {
        if (str.Length == lengthStr - 1)
            stopWatch.Start();
        if (str.Length == 0)
        {
            stopWatch.Stop();
            long seconds = stopWatch.ElapsedMilliseconds/1000;
            long tempF = 60 * lengthStr / seconds;
            textInform.text = tempF.ToString() + " зн/m";
            //Debug.Log(60 * lengthStr / seconds);
        }
    }
    
    // Update is calle once per frame
    void Update()
    {
        pressingKeyboard();
        charactedInMinutes();

        if(str.Length == 0)  //Вывод только один раз
        {
            
            if(oneEnter == 1)
            {
                for (int i = 0; i < 104; i++)
                {
                    if (numButton[i] != 0)
                    {
                        char tempChar = ' ';
                        switch (i)
                        {
                            case 0:
                                tempChar = ',';
                                break;
                            case 1:
                                tempChar = 'А';
                                break;
                            case 2:
                                tempChar = 'Б';
                                break;
                            case 3:
                                tempChar = 'В';
                                break;
                            case 4:
                                tempChar = 'Г';
                                break;
                            case 5:
                                tempChar = 'Д';
                                break;
                            case 6:
                                tempChar = 'Е';
                                break;
                            case 7:
                                tempChar = 'Ё';
                                break;
                            case 8:
                                tempChar = 'Ж';
                                break;
                            case 9:
                                tempChar = 'З';
                                break;
                            case 10:
                                tempChar = 'И';
                                break;
                            case 11:
                                tempChar = 'Й';
                                break;
                            case 12:
                                tempChar = 'К';
                                break;
                            case 13:
                                tempChar = 'Л';
                                break;
                            case 14:
                                tempChar = 'М';
                                break;
                            case 15:
                                tempChar = 'Н';
                                break;
                            case 16:
                                tempChar = 'О';
                                break;
                            case 17:
                                tempChar = 'П';
                                break;
                            case 18:
                                tempChar = 'Р';
                                break;
                            case 19:
                                tempChar = 'С';
                                break;
                            case 20:
                                tempChar = 'Т';
                                break;
                            case 21:
                                tempChar = 'У';
                                break;
                            case 22:
                                tempChar = 'Ф';
                                break;
                            case 23:
                                tempChar = 'Х';
                                break;
                            case 24:
                                tempChar = 'Ц';
                                break;
                            case 25:
                                tempChar = 'Ч';
                                break;
                            case 26:
                                tempChar = 'Ш';
                                break;
                            case 27:
                                tempChar = 'Щ';
                                break;
                            case 28:
                                tempChar = 'Ъ';
                                break;
                            case 29:
                                tempChar = 'Ы';
                                break;
                            case 30:
                                tempChar = 'Ь';
                                break;
                            case 31:
                                tempChar = 'Э';
                                break;
                            case 32:
                                tempChar = 'Ю';
                                break;
                            case 33:
                                tempChar = 'Я';
                                break;
                            case 34:
                                tempChar = '!';
                                break;
                            case 35:
                                tempChar = '"';
                                break;
                            case 36:
                                tempChar = ';';
                                break;
                            case 37:
                                tempChar = ':';
                                break;
                            case 38:
                                tempChar = '?';
                                break;
                            case 39:
                                tempChar = '*';
                                break;
                            case 40:
                                tempChar = '(';
                                break;
                            case 41:
                                tempChar = ')';
                                break;
                            case 42:
                                tempChar = ' ';
                                break;
                            case 43:
                                tempChar = '.';
                                break;
                            case 44:
                                tempChar = '↵';
                                break;
                            case 45:
                                tempChar = '-';
                                break;
                        }
                        textStatistics.text = textStatistics.text + " " + tempChar + " = " + numButton[i] + "\n";
                    }    
                }
            }

            oneEnter--;
        }
    }

    int NumChar(char tempChar)
    {
        int tempInt = -1;

        switch (tempChar)
        {
          case ',':
                tempInt = 0;
                break;
            case 'А':
                tempInt = 1;
                break;
            case 'Б':
                tempInt = 2;
                break;
            case 'В':
                tempInt = 3;
                break;
            case 'Г':
                tempInt = 4;
                break;
            case 'Д':
                tempInt = 5;
                break;
            case 'Е':
                tempInt = 6;
                break;
            case 'Ё':
                tempInt = 7;
                break;
            case 'Ж':
                tempInt = 8;
                break;
            case 'З':
                tempInt = 9;
                break;
            case 'И':
                tempInt = 10;
                break;
            case 'Й':
                tempInt = 11;
                break;
            case 'К':
                tempInt = 12;
                break;
            case 'Л':
                tempInt = 13;
                break;
            case 'М':
                tempInt = 14;
                break;
            case 'Н':
                tempInt = 15;
                break;
            case 'О':
                tempInt = 16;
                break;
            case 'П':
                tempInt = 17;
                break;
            case 'Р':
                tempInt = 18;
                break;
            case 'С':
                tempInt = 19;
                break;
            case 'Т':
                tempInt = 20;
                break;
            case 'У':
                tempInt = 21;
                break;
            case 'Ф':
                tempInt = 22;
                break;
            case 'Х':
                tempInt = 23;
                break;
            case 'Ц':
                tempInt = 24;
                break;
            case 'Ч':
                tempInt = 25;
                break;
            case 'Ш':
                tempInt = 26;
                break;
            case 'Щ':
                tempInt = 27;
                break;
            case 'Ъ':
                tempInt = 28;
                break;
            case 'Ы':
                tempInt = 29;
                break;
            case 'Ь':
                tempInt = 30;
                break;
            case 'Э':
                tempInt = 31;
                break;
            case 'Ю':
                tempInt = 32;
                break;
            case 'Я':
                tempInt = 33;
                break;
            case 'а':
                tempInt = 1;
                break;
            case 'б':
                tempInt = 2;
                break;
            case 'в':
                tempInt = 3;
                break;
            case 'г':
                tempInt = 4;
                break;
            case 'д':
                tempInt = 5;
                break;
            case 'е':
                tempInt = 6;
                break;
            case 'ё':
                tempInt = 7;
                break;
            case 'ж':
                tempInt = 8;
                break;
            case 'з':
                tempInt = 9;
                break;
            case 'и':
                tempInt = 10;
                break;
            case 'й':
                tempInt = 11;
                break;
            case 'к':
                tempInt = 12;
                break;
            case 'л':
                tempInt = 13;
                break;
            case 'м':
                tempInt = 14;
                break;
            case 'н':
                tempInt = 15;
                break;
            case 'о':
                tempInt = 16;
                break;
            case 'п':
                tempInt = 17;
                break;
            case 'р':
                tempInt = 18;
                break;
            case 'с':
                tempInt = 19;
                break;
            case 'т':
                tempInt = 20;
                break;
            case 'у':
                tempInt = 21;
                break;
            case 'ф':
                tempInt = 22;
                break;
            case 'х':
                tempInt = 23;
                break;
            case 'ц':
                tempInt = 24;
                break;
            case 'ч':
                tempInt = 25;
                break;
            case 'ш':
                tempInt = 26;
                break;
            case 'щ':
                tempInt = 27;
                break;
            case 'ъ':
                tempInt = 28;
                break;
            case 'ы':
                tempInt = 29;
                break;
            case 'ь':
                tempInt = 30;
                break;
            case 'э':
                tempInt = 31;
                break;
            case 'ю':
                tempInt = 32;
                break;
            case 'я':
                tempInt = 33;
                break;
            case '!':
                tempInt = 34;
                break;
            case '"':
                tempInt = 35;
                break;
            case ';':
                tempInt = 36;
                break;
            case ':':
                tempInt = 37;
                break;
            case '?':
                tempInt = 38;
                break;
            case '*':
                tempInt = 39;
                break;
            case '(':
                tempInt = 40;
                break;
            case ')':
                tempInt = 41;
                break;
            case ' ':
                tempInt = 42;
                break;
            case '.':
                tempInt = 43;
                break;
            case '↵':
                tempInt = 44;
                break;
            case '-':
                tempInt = 45;
                break;
            
        }

        return tempInt;
    }
}