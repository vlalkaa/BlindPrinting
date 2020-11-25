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
    public Text textButton;
    //public Button stsrtButton;
    private bool pressStartButton;
    //private bool pressHomeButton;
    private string str;
    private char ch;
    private int lengthStr;
    private Stopwatch stopWatch = new Stopwatch();
    private int[] numButton = new int [104];
    private int oneEnter = 1;
    private bool firstLogin = true;

    void Start()
    {
        pressStartButton = false;
        //pressHomeButton = false;

        /*
         string space = "  ";

        textMain.text = space;
         pressStartButton = false;
        str = textRand();
                
        lengthStr = str.Length;
                
        for (int i = 0; i < 19; i++)
        {
            if (i == str.Length)
                break;
            textMain.text = textMain.text + str[i];
        }*/
        
        for (int i = 0; i < 104; i++)
        {
            numButton[i] = 0;
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
        if (textButton.text == "Язык ru")
        {
            if (tempRand == 0)
                filename = "Text1.txt";
            else if (tempRand == 1)
                filename = "Text2.txt";
            else if (tempRand == 2)
                filename = "Text3.txt";
        }
        else if (textButton.text == "Язык eng")
        {
            if (tempRand == 0)
                filename = "Text4.txt";
            else if (tempRand == 1)
                filename = "Text5.txt";
            else if (tempRand == 2)
                filename = "Text6.txt";
        }
            
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
            
            //№
            if (Input.GetKeyDown("3"))
            {
                ch = '№';
                check();
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                ch = ';';
                check();
            }
            
            //процент
            if (Input.GetKeyDown("5"))
            {
                ch = '%';
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
            
            //_
            if (Input.GetKeyDown("-"))
            {
                ch = '_';
                check();
            }
            
            //+
            if (Input.GetKeyDown("="))
            {
                ch = '+';
                check();
            }
            
            ///
            if (Input.GetKeyDown("\\"))
            {
                ch = '/';
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
            if (Input.GetKeyDown(KeyCode.Return))//исправить тройной баг
            {
                ch = '↵';
                check();
                ch = '\r';
                check();
                ch = '\n';
                check();
            } 
            
            //1
            if (Input.GetKeyDown("1"))
            {
                ch = '1';
                check();
            }
            
            //2
            if (Input.GetKeyDown("2"))
            {
                ch = '2';
                check();
            }
            
            //3
            if (Input.GetKeyDown("3"))
            {
                ch = '3';
                check();
            }
            
            //4
            if (Input.GetKeyDown("4"))
            {
                ch = '4';
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

    void pressingKeyboardEng()
    {
        //SHIFT
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            //А
            if (Input.GetKeyDown("f"))
            {
                ch = 'F';
                check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                ch = '<';
                check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                ch = 'D';
                check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                ch = 'U';
                check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                ch = 'L';
                check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                ch = 'T';
                check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = '~';
                check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                ch = ':';
                check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                ch = 'P';
                check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                ch = 'B';
                check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                ch = 'Q';
                check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                ch = 'R';
                check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                ch = 'K';
                check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                ch = 'V';
                check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                ch = 'Y';
                check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                ch = 'J';
                check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                ch = 'G';
                check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                ch = 'H';
                check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                ch = 'C';
                check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                ch = 'N';
                check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                ch = 'E';
                check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                ch = 'A';
                check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                ch = '{';
                check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                ch = 'W';
                check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                ch = 'X';
                check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                ch = 'I';
                check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                ch = 'O';
                check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                ch = '}';
                check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                ch = 'S';
                check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                ch = 'M';
                check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                ch = '"';
                check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                ch = '>';
                check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                ch = 'Z';
                check();
            }
            
            //запятая
            if (Input.GetKeyDown("/"))
            {
                ch = '?';
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
                ch = '@';
                check();
            }
            
            //№
            if (Input.GetKeyDown("3"))
            {
                ch = '#';
                check();
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                ch = '$';
                check();
            }
            
            //процент
            if (Input.GetKeyDown("5"))
            {
                ch = '%';
                check();
            }
            
            //двоеточие
            if (Input.GetKeyDown("6"))
            {
                ch = '^';
                check();
            }
            
            //вопр знак
            if (Input.GetKeyDown("7"))
            {
                ch = '&';
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
            
            //_
            if (Input.GetKeyDown("-"))
            {
                ch = '_';
                check();
            }
            
            //+
            if (Input.GetKeyDown("="))
            {
                ch = '+';
                check();
            }
            
            ///
            if (Input.GetKeyDown("\\"))
            {
                ch = '|';
                check();
            }
        }
        else
        { 
            //А
            if (Input.GetKeyDown("f"))
            {
                ch = 'f';
                check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                ch = ',';
                check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                ch = 'd';
                check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                ch = 'u';
                check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                ch = 'l';
                check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                ch = 't';
                check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                ch = '`';
                check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                ch = ';';
                check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                ch = 'p';
                check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                ch = 'b';
                check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                ch = 'q';
                check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                ch = 'r';
                check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                ch = 'k';
                check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                ch = 'v';
                check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                ch = 'y';
                check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                ch = 'j';
                check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                ch = 'g';
                check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                ch = 'h';
                check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                ch = 'c';
                check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                ch = 'n';
                check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                ch = 'e';
                check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                ch = 'a';
                check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                ch = '[';
                check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                ch = 'w';
                check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                ch = 'x';
                check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                ch = 'i';
                check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                ch = 'o';
                check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                ch = ']';
                check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                ch = 's';
                check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                ch = 'm';
                check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                ch = '\'';
                check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                ch = '.';
                check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                ch = 'z';
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
                ch = '/';
                check();
            }
            
            //enter
            if (Input.GetKeyDown(KeyCode.Return))//исправить тройной баг
            {
                ch = '↵';
                check();
                ch = '\r';
                check();
                ch = '\n';
                check();
            } 
            
            //1
            if (Input.GetKeyDown("1"))
            {
                ch = '1';
                check();
            }
            
            //2
            if (Input.GetKeyDown("2"))
            {
                ch = '2';
                check();
            }
            
            //3
            if (Input.GetKeyDown("3"))
            {
                ch = '3';
                check();
            }
            
            //4
            if (Input.GetKeyDown("4"))
            {
                ch = '4';
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
        }
    }

    public void PressStartButton()
    {
        pressStartButton = true;
        
    }

    public void PressHomeButton()
    {
        //pressHomeButton = true;
        pressStartButton = false;
        firstLogin = true;
    }

    // Update is calle once per frame
    void Update()
    {
        if (pressStartButton)
        {
            if (firstLogin)
            {
                string space = "  ";
                textMain.text = space;
                
                str = textRand();
                
                lengthStr = str.Length;
                
                for (int i = 0; i < 19; i++)
                {
                    if (i == str.Length)
                        break;
                    textMain.text = textMain.text + str[i];
                }

                firstLogin = false;
            }
            
            if (textButton.text == "Язык ru")
            {
               pressingKeyboard();
               charactedInMinutes();
   
               if(str.Length == 0)  //Сработывает только один раз
               {
                   
                   if(oneEnter == 1)
                   {
                       enterInform();
                   }
                   oneEnter--;
               }
            }
            else if (textButton.text == "Язык eng")
            {
               pressingKeyboardEng();
               charactedInMinutes();
               
               if(str.Length == 0)  //Сработывает только один раз
               {
                   
                   if(oneEnter == 1)
                   {
                       enterInformEng();
                   }
                   oneEnter--;
               }
            } 
        }
        else
        {
            string space = "  ";
            textMain.text = space;
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
            case 'A':
                tempInt = 1;
                break;
            case 'B':
                tempInt = 2;
                break;
            case 'C':
                tempInt = 3;
                break;
            case 'D':
                tempInt = 4;
                break;
            case 'E':
                tempInt = 5;
                break;
            case 'F':
                tempInt = 6;
                break;
            case 'G':
                tempInt = 7;
                break;
            case 'H':
                tempInt = 8;
                break;
            case 'I':
                tempInt = 9;
                break;
            case 'J':
                tempInt = 10;
                break;
            case 'K':
                tempInt = 11;
                break;
            case 'L':
                tempInt = 12;
                break;
            case 'M':
                tempInt = 13;
                break;
            case 'N':
                tempInt = 14;
                break;
            case 'O':
                tempInt = 15;
                break;
            case 'P':
                tempInt = 16;
                break;
            case 'Q':
                tempInt = 17;
                break;
            case 'R':
                tempInt = 18;
                break;
            case 'S':
                tempInt = 19;
                break;
            case 'T':
                tempInt = 20;
                break;
            case 'U':
                tempInt = 21;
                break;
            case 'V':
                tempInt = 22;
                break;
            case 'W':
                tempInt = 23;
                break;
            case 'X':
                tempInt = 24;
                break;
            case 'Y':
                tempInt = 25;
                break;
            case 'Z':
                tempInt = 26;
                break;
          case 'a':
              tempInt = 1;
              break;
          case 'b':
              tempInt = 2;
              break;
          case 'c':
              tempInt = 3;
              break;
          case 'd':
              tempInt = 4;
              break;
          case 'e':
              tempInt = 5;
              break;
          case 'f':
              tempInt = 6;
              break;
          case 'g':
              tempInt = 7;
              break;
          case 'h':
              tempInt = 8;
              break;
          case 'i':
              tempInt = 9;
              break;
          case 'j':
              tempInt = 10;
              break;
          case 'k':
              tempInt = 11;
              break;
          case 'l':
              tempInt = 12;
              break;
          case 'm':
              tempInt = 13;
              break;
          case 'n':
              tempInt = 14;
              break;
          case 'o':
              tempInt = 15;
              break;
          case 'p':
              tempInt = 16;
              break;
          case 'q':
              tempInt = 17;
              break;
          case 'r':
              tempInt = 18;
              break;
          case 's':
              tempInt = 19;
              break;
          case 't':
              tempInt = 20;
              break;
          case 'u':
              tempInt = 21;
              break;
          case 'v':
              tempInt = 22;
              break;
          case 'w':
              tempInt = 23;
              break;
          case 'x':
              tempInt = 24;
              break;
          case 'y':
              tempInt = 25;
              break;
          case 'z':
              tempInt = 26;
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
            case '№':
                tempInt = 46;
                break;
            case '%':
                tempInt = 47;
                break;
            case '1':
              tempInt = 48;
              break;
          case '2':
              tempInt = 49;
              break;
          case '3':
              tempInt = 50;
              break;
          case '4':
              tempInt = 51;
              break;
          case '5':
              tempInt = 52;
              break;
          case '6':
              tempInt = 53;
              break;
          case '7':
              tempInt = 54;
              break;
          case '8':
              tempInt = 55;
              break;
          case '9':
              tempInt = 56;
              break;
          case '0':
              tempInt = 57;
              break;
        }
        return tempInt;
    }

    void enterInform()
    {
        int[] EnterBut = new int[104];
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
    
    void enterInformEng()
    {
        int[] EnterBut = new int[104];
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
                        tempChar = 'A';
                        break;
                    case 2:
                        tempChar = 'B';
                        break;
                    case 3:
                        tempChar = 'C';
                        break;
                    case 4:
                        tempChar = 'D';
                        break;
                    case 5:
                        tempChar = 'E';
                        break;
                    case 6:
                        tempChar = 'F';
                        break;
                    case 7:
                        tempChar = 'G';
                        break;
                    case 8:
                        tempChar = 'H';
                        break;
                    case 9:
                        tempChar = 'I';
                        break;
                    case 10:
                        tempChar = 'J';
                        break;
                    case 11:
                        tempChar = 'K';
                        break;
                    case 12:
                        tempChar = 'L';
                        break;
                    case 13:
                        tempChar = 'M';
                        break;
                    case 14:
                        tempChar = 'N';
                        break;
                    case 15:
                        tempChar = 'O';
                        break;
                    case 16:
                        tempChar = 'P';
                        break;
                    case 17:
                        tempChar = 'Q';
                        break;
                    case 18:
                        tempChar = 'R';
                        break;
                    case 19:
                        tempChar = 'S';
                        break;
                    case 20:
                        tempChar = 'T';
                        break;
                    case 21:
                        tempChar = 'U';
                        break;
                    case 22:
                        tempChar = 'V';
                        break;
                    case 23:
                        tempChar = 'W';
                        break;
                    case 24:
                        tempChar = 'X';
                        break;
                    case 25:
                        tempChar = 'Y';
                        break;
                    case 26:
                        tempChar = 'Z';
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
}