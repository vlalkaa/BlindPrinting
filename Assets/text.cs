using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;
public class text : MonoBehaviour
{
    public Text textMain;
    public Text textInform;
    public Text textStatistics;
    public Text textButton;

    public Text textEnterStat;

    private bool _pressStartButton;
    private string _str;
    private char _ch;
    private int _lengthStr;
    
    private int _TEMPlengthStr;
    private bool _veryFirstLogin; 
    
    private readonly Stopwatch _stopWatch = new Stopwatch();
    private readonly int[] _numButton = new int [104];
    private int _oneEnter;
    private bool _firstLogin = true;
    private bool _column = true;
    
    public Item item;

    private bool _buttonTopicText1 = true;
    private bool _buttonTopicText2;
    private bool _buttonTopicText3;
    private bool _buttonTopicText4;

    private string nameFile;

    private void Start()
    {
        _oneEnter = 1;
        string space = "  ";
        textMain.text = space;
        textStatistics.text = "";
        textInform.text = space;

        //_str = TextRand();
        SelectFile();
        _str = item.textFromFile; 
                  
        
        _lengthStr = _str.Length;

        _TEMPlengthStr = 0;
                
        for (int i = 0; i < 19; i++)
        {
            if (i == _str.Length)
                break;
            textMain.text = textMain.text + _str[i];
            
        }
        if (_pressStartButton)
            _firstLogin = false;
        
        for (int i = 0; i < 104; i++)
        {
            _numButton[i] = 0;
        }
    }

    private void Check()
    {
        if (_str.Length > 0)
        {
            char tempch = _str[0];
            
            if (_str[0] == _ch)
            {
                _str = _str.Remove(0, 1);
                if (_ch == '\n')
                    textMain.text = $"  <color=grey>{'|'}</color>";
                else
                    textMain.text = $" <color=green>{tempch}</color>" + $"<color=grey>{'|'}</color>";
                for (int i = 0; i < 18; i++)
                {
                    if (i == _str.Length)
                        break;
                    textMain.text = textMain.text + _str[i];
                }

                _TEMPlengthStr++;
            }
            else if (_str[0] != _ch)
            {
                _numButton[NumChar(_str[0])]++;
                textMain.text = $"  <color=red>{'|'}</color>" + $"<color=red>{tempch}</color>";
                
                for (int i = 1; i < 18; i++)
                {
                    if (i == _str.Length)
                        break;
                    textMain.text = textMain.text + _str[i];
                }
            }
        }
        else if (_str.Length == 0)
        {
            textMain.text = _str;
        }
        
    }

    private string TextRand()
    {
        string filename = " ";
        Random rnd = new Random();
        int tempRand = rnd.Next(4);
        if (textButton.text == "Язык ru")
        {
            if (tempRand == 0)
                filename = "Text1.txt";
            else if (tempRand == 1)
                filename = "Text2.txt";
            else if (tempRand == 2)
                filename = "Text3.txt";
            else if (tempRand == 3)
                filename = "Text7.txt";
        }
        else if (textButton.text == "Язык eng")
        {
            if (tempRand == 0)
                filename = "Text4.txt";
            else if (tempRand == 1)
                filename = "Text5.txt";
            else if (tempRand == 2)
                filename = "Text6.txt";
            else if (tempRand == 3)
                filename = "Text8.txt";
        }
        
        byte[] bytes;
        bytes = File.ReadAllBytes(filename);
        
        string tempstr = Encoding.UTF8.GetString(bytes);
        
        if (tempRand == 3)
        {
            Random strRand = new Random();
            string tempstr2 = "";
            for (int i = 0; i < 100; i++)
            {
                int strRandTemp = strRand.Next(52);
                tempstr2 = tempstr2 + tempstr[strRandTemp];
            }
            return tempstr2;
        }
        else return tempstr;
    }

    public class Item
    {
        public string textFromFile;
        public string statisticsFromFile;
        public string speedFromFile;
    }
    
    public void ButtonTopicText1()
    {
        _buttonTopicText1 = true;
        _buttonTopicText2 = false;
        _buttonTopicText3 = false;
        _buttonTopicText4 = false;
    }
    
    public void ButtonTopicText2()
    {
        _buttonTopicText1 = false;
        _buttonTopicText2 = true;
        _buttonTopicText3 = false;
        _buttonTopicText4 = false;
    }
    
    public void ButtonTopicText3()
    {
        _buttonTopicText1 = false;
        _buttonTopicText2 = false;
        _buttonTopicText3 = true;
        _buttonTopicText4 = false;
    }
    
    public void ButtonTopicText4()
    {
        _buttonTopicText1 = false;
        _buttonTopicText2 = false;
        _buttonTopicText3 = false;
        _buttonTopicText4 = true;
    }

    private void SelectNameFile()
    {
        if (textButton.text == "Язык ru")
        {
            if (_buttonTopicText1)
                nameFile = "/Text1.json";
            else if (_buttonTopicText2)
                nameFile = "/Text2.json";
            else if (_buttonTopicText3)
                nameFile = "/Text3.json";
            else if (_buttonTopicText4)
                nameFile = "/Text4.json";
        }
        else if (textButton.text == "Язык eng")
        {
            
        }
    }

    private void SelectFile()
    {
        SelectNameFile();
        item = JsonUtility.FromJson<Item>(File.ReadAllText(Application.streamingAssetsPath + nameFile));
    }

    private void SaveToFile()
    {
        File.WriteAllText(Application.streamingAssetsPath + nameFile, JsonUtility.ToJson(item));
    }
    
    private void PressingKeyboard()
    {
        //SHIFT
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            //А
            if (Input.GetKeyDown("f"))
            {
                _ch = 'А';
                Check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                _ch = 'Б';
                Check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                _ch = 'В';
                Check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                _ch = 'Г';
                Check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                _ch = 'Д';
                Check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                _ch = 'Е';
                Check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                _ch = 'Ё';
                Check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                _ch = 'Ж';
                Check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                _ch = 'З';
                Check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                _ch = 'И';
                Check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                _ch = 'Й';
                Check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                _ch = 'К';
                Check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                _ch = 'Л';
                Check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                _ch = 'М';
                Check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                _ch = 'Н';
                Check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                _ch = 'О';
                Check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                _ch = 'П';
                Check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                _ch = 'Р';
                Check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                _ch = 'С';
                Check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                _ch = 'Т';
                Check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                _ch = 'У';
                Check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                _ch = 'Ф';
                Check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                _ch = 'Х';
                Check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                _ch = 'Ц';
                Check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                _ch = 'Ч';
                Check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                _ch = 'Ш';
                Check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                _ch = 'Щ';
                Check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                _ch = 'Ъ';
                Check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                _ch = 'Ы';
                Check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                _ch = 'Ь';
                Check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                _ch = 'Э';
                Check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                _ch = 'Ю';
                Check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                _ch = 'Я';
                Check();
            }
            
            //запятая
            if (Input.GetKeyDown("/"))
            {
                _ch = ',';
                Check();
            }

            //воскл знак
            if (Input.GetKeyDown("1"))
            {
                _ch = '!';
                Check();
            }
            
            //ковычки
            if (Input.GetKeyDown("2"))
            {
                _ch = '"';
                Check();
            }
            
            //№
            if (Input.GetKeyDown("3"))
            {
                _ch = '№';
                Check();
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                _ch = ';';
                Check();
            }
            
            //процент
            if (Input.GetKeyDown("5"))
            {
                _ch = '%';
                Check();
            }
            
            //двоеточие
            if (Input.GetKeyDown("6"))
            {
                _ch = ':';
                Check();
            }
            
            //вопр знак
            if (Input.GetKeyDown("7"))
            {
                _ch = '?';
                Check();
            }
            
            //звездочка
            if (Input.GetKeyDown("8"))
            {
                _ch = '*';
                Check();
            }
            
            //открыв скобка
            if (Input.GetKeyDown("9"))
            {
                _ch = '(';
                Check();
            }
            
            //закрыв скобка
            if (Input.GetKeyDown("0"))
            {
                _ch = ')';
                Check();
            }
            
            //_
            if (Input.GetKeyDown("-"))
            {
                _ch = '_';
                Check();
            }
            
            //+
            if (Input.GetKeyDown("="))
            {
                _ch = '+';
                Check();
            }
            
            ///
            if (Input.GetKeyDown("\\"))
            {
                _ch = '/';
                Check();
            }
        }
        else
        { 
            //А
            if (Input.GetKeyDown("f"))
            {
                _ch = 'а';
                Check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                _ch = 'б';
                Check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                _ch = 'в';
                Check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                _ch = 'г';
                Check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                _ch = 'д';
                Check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                _ch = 'е';
                Check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                _ch = 'ё';
                Check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                _ch = 'ж';
                Check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                _ch = 'з';
                Check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                _ch = 'и';
                Check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                _ch = 'й';
                Check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                _ch = 'к';
                Check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                _ch = 'л';
                Check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                _ch = 'м';
                Check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                _ch = 'н';
                Check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                _ch = 'о';
                Check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                _ch = 'п';
                Check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                _ch = 'р';
                Check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                _ch = 'с';
                Check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                _ch = 'т';
                Check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                _ch = 'у';
                Check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                _ch = 'ф';
                Check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                _ch = 'х';
                Check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                _ch = 'ц';
                Check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                _ch = 'ч';
                Check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                _ch = 'ш';
                Check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                _ch = 'щ';
                Check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                _ch = 'ъ';
                Check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                _ch = 'ы';
                Check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                _ch = 'ь';
                Check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                _ch = 'э';
                Check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                _ch = 'ю';
                Check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                _ch = 'я';
                Check();
            }
            
            //пробел
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _ch = ' ';
                Check();
            }
            
            //точка
            if (Input.GetKeyDown("/"))
            {
                _ch = '.';
                Check();
            }
            
            //enter
            if (Input.GetKeyDown(KeyCode.Return))//исправить тройной баг
            {
                _ch = '↵';
                Check();
                _ch = '\r';
                Check();
                _ch = '\n';
                Check();
            } 
            
            //1
            if (Input.GetKeyDown("1"))
            {
                _ch = '1';
                Check();
            }
            
            //2
            if (Input.GetKeyDown("2"))
            {
                _ch = '2';
                Check();
            }
            
            //3
            if (Input.GetKeyDown("3"))
            {
                _ch = '3';
                Check();
            }
            
            //4
            if (Input.GetKeyDown("4"))
            {
                _ch = '4';
                Check();
            }
            
            //5
            if (Input.GetKeyDown("5"))
            {
                _ch = '5';
                Check();
            }
            
            //6
            if (Input.GetKeyDown("6"))
            {
                _ch = '6';
                Check();
            }
            
            //7
            if (Input.GetKeyDown("7"))
            {
                _ch = '7';
                Check();
            }
            
            //8
            if (Input.GetKeyDown("8"))
            {
                _ch = '8';
                Check();
            }
            
            //9
            if (Input.GetKeyDown("9"))
            {
                _ch = '9';
                Check();
            }
            
            //0
            if (Input.GetKeyDown("0"))
            {
                _ch = '0';
                Check();
            }
            
            //тире
            if (Input.GetKeyDown("-"))
            {
                _ch = '-';
                Check();
            }
        }
    }

    private void PressingKeyboardEng()
    {
        //SHIFT
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            //А
            if (Input.GetKeyDown("f"))
            {
                _ch = 'F';
                Check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                _ch = '<';
                Check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                _ch = 'D';
                Check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                _ch = 'U';
                Check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                _ch = 'L';
                Check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                _ch = 'T';
                Check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                _ch = '~';
                Check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                _ch = ':';
                Check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                _ch = 'P';
                Check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                _ch = 'B';
                Check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                _ch = 'Q';
                Check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                _ch = 'R';
                Check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                _ch = 'K';
                Check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                _ch = 'V';
                Check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                _ch = 'Y';
                Check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                _ch = 'J';
                Check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                _ch = 'G';
                Check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                _ch = 'H';
                Check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                _ch = 'C';
                Check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                _ch = 'N';
                Check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                _ch = 'E';
                Check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                _ch = 'A';
                Check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                _ch = '{';
                Check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                _ch = 'W';
                Check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                _ch = 'X';
                Check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                _ch = 'I';
                Check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                _ch = 'O';
                Check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                _ch = '}';
                Check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                _ch = 'S';
                Check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                _ch = 'M';
                Check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                _ch = '"';
                Check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                _ch = '>';
                Check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                _ch = 'Z';
                Check();
            }
            
            //запятая
            if (Input.GetKeyDown("/"))
            {
                _ch = '?';
                Check();
            }

            //воскл знак
            if (Input.GetKeyDown("1"))
            {
                _ch = '!';
                Check();
            }
            
            //ковычки
            if (Input.GetKeyDown("2"))
            {
                _ch = '@';
                Check();
            }
            
            //№
            if (Input.GetKeyDown("3"))
            {
                _ch = '#';
                Check();
            }
            
            //точка с запятой
            if (Input.GetKeyDown("4"))
            {
                _ch = '$';
                Check();
            }
            
            //процент
            if (Input.GetKeyDown("5"))
            {
                _ch = '%';
                Check();
            }
            
            //двоеточие
            if (Input.GetKeyDown("6"))
            {
                _ch = '^';
                Check();
            }
            
            //вопр знак
            if (Input.GetKeyDown("7"))
            {
                _ch = '&';
                Check();
            }
            
            //звездочка
            if (Input.GetKeyDown("8"))
            {
                _ch = '*';
                Check();
            }
            
            //открыв скобка
            if (Input.GetKeyDown("9"))
            {
                _ch = '(';
                Check();
            }
            
            //закрыв скобка
            if (Input.GetKeyDown("0"))
            {
                _ch = ')';
                Check();
            }
            
            //_
            if (Input.GetKeyDown("-"))
            {
                _ch = '_';
                Check();
            }
            
            //+
            if (Input.GetKeyDown("="))
            {
                _ch = '+';
                Check();
            }
            
            ///
            if (Input.GetKeyDown("\\"))
            {
                _ch = '|';
                Check();
            }
        }
        else
        { 
            //А
            if (Input.GetKeyDown("f"))
            {
                _ch = 'f';
                Check();
            }
            
            //Б
            if (Input.GetKeyDown(","))
            {
                _ch = ',';
                Check();
            }
            
            //В
            if (Input.GetKeyDown("d"))
            {
                _ch = 'd';
                Check();
            }
            
            //Г
            if (Input.GetKeyDown("u"))
            {
                _ch = 'u';
                Check();
            }
            
            //Д
            if (Input.GetKeyDown("l"))
            {
                _ch = 'l';
                Check();
            }
            
            //Е
            if (Input.GetKeyDown("t"))
            {
                _ch = 't';
                Check();
            }
            
            //Ё
            if (Input.GetKeyDown("`"))
            {
                _ch = '`';
                Check();
            }
            
            //Ж
            if (Input.GetKeyDown(";"))
            {
                _ch = ';';
                Check();
            }
            
            //З
            if (Input.GetKeyDown("p"))
            {
                _ch = 'p';
                Check();
            }
            
            //И
            if (Input.GetKeyDown("b"))
            {
                _ch = 'b';
                Check();
            }
            
            //Й
            if (Input.GetKeyDown("q"))
            {
                _ch = 'q';
                Check();
            }
            
            //К
            if (Input.GetKeyDown("r"))
            {
                _ch = 'r';
                Check();
            }
            
            //Л
            if (Input.GetKeyDown("k"))
            {
                _ch = 'k';
                Check();
            }
            
            //М
            if (Input.GetKeyDown("v"))
            {
                _ch = 'v';
                Check();
            }
            
            //Н
            if (Input.GetKeyDown("y"))
            {
                _ch = 'y';
                Check();
            }
            
            //О
            if (Input.GetKeyDown("j"))
            {
                _ch = 'j';
                Check();
            }
            
            //П
            if (Input.GetKeyDown("g"))
            {
                _ch = 'g';
                Check();
            }
            
            //Р
            if (Input.GetKeyDown("h"))
            {
                _ch = 'h';
                Check();
            }
            
            //С
            if (Input.GetKeyDown("c"))
            {
                _ch = 'c';
                Check();
            }

            //Т
            if (Input.GetKeyDown("n"))
            {
                _ch = 'n';
                Check();
            }
            
            //У
            if (Input.GetKeyDown("e"))
            {
                _ch = 'e';
                Check();
            }
            
            //Ф
            if (Input.GetKeyDown("a"))
            {
                _ch = 'a';
                Check();
            }
            
            //Х
            if (Input.GetKeyDown("["))
            {
                _ch = '[';
                Check();
            }
            
            //Ц
            if (Input.GetKeyDown("w"))
            {
                _ch = 'w';
                Check();
            }
            
            //Ч
            if (Input.GetKeyDown("x"))
            {
                _ch = 'x';
                Check();
            }
            
            //Ш
            if (Input.GetKeyDown("i"))
            {
                _ch = 'i';
                Check();
            }
            
            //Щ
            if (Input.GetKeyDown("o"))
            {
                _ch = 'o';
                Check();
            }
            
            //Ъ
            if (Input.GetKeyDown("]"))
            {
                _ch = ']';
                Check();
            }
            
            //Ы
            if (Input.GetKeyDown("s"))
            {
                _ch = 's';
                Check();
            }
            
            //Ь
            if (Input.GetKeyDown("m"))
            {
                _ch = 'm';
                Check();
            }
            
            //Э
            if (Input.GetKeyDown("'"))
            {
                _ch = '\'';
                Check();
            }
            
            //Ю
            if (Input.GetKeyDown("."))
            {
                _ch = '.';
                Check();
            }
            
            //Я
            if (Input.GetKeyDown("z"))
            {
                _ch = 'z';
                Check();
            }
            
            //пробел
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _ch = ' ';
                Check();
            }
            
            //точка
            if (Input.GetKeyDown("/"))
            {
                _ch = '/';
                Check();
            }
            
            //enter
            if (Input.GetKeyDown(KeyCode.Return))//исправить тройной баг
            {
                _ch = '↵';
                Check();
                _ch = '\r';
                Check();
                _ch = '\n';
                Check();
            } 
            
            //1
            if (Input.GetKeyDown("1"))
            {
                _ch = '1';
                Check();
            }
            
            //2
            if (Input.GetKeyDown("2"))
            {
                _ch = '2';
                Check();
            }
            
            //3
            if (Input.GetKeyDown("3"))
            {
                _ch = '3';
                Check();
            }
            
            //4
            if (Input.GetKeyDown("4"))
            {
                _ch = '4';
                Check();
            }
            
            //5
            if (Input.GetKeyDown("5"))
            {
                _ch = '5';
                Check();
            }
            
            //6
            if (Input.GetKeyDown("6"))
            {
                _ch = '6';
                Check();
            }
            
            //7
            if (Input.GetKeyDown("7"))
            {
                _ch = '7';
                Check();
            }
            
            //8
            if (Input.GetKeyDown("8"))
            {
                _ch = '8';
                Check();
            }
            
            //9
            if (Input.GetKeyDown("9"))
            {
                _ch = '9';
                Check();
            }
            
            //0
            if (Input.GetKeyDown("0"))
            {
                _ch = '0';
                Check();
            }
            
            //тире
            if (Input.GetKeyDown("-"))
            {
                _ch = '-';
                Check();
            }
        }
    }
    
    private void CharacterInMinutes()
    {
        if (_str.Length == _lengthStr - 1)
            _stopWatch.Restart();
        
        if (_str.Length == 0)
        {
            _stopWatch.Stop();
            long seconds = _stopWatch.ElapsedMilliseconds/1000;
            long tempF = 60 * _lengthStr / seconds;
            textInform.text = tempF + " зн/m";
        }
        
    }
    
    private void CharacterInMinutes2_0()
    {
        if (_str.Length == _lengthStr - 1)
            _stopWatch.Restart();
        if (_str.Length < _lengthStr -2)
        {
            double seconds = _stopWatch.ElapsedMilliseconds / 1000;
            double tempF = 60 * _TEMPlengthStr / seconds;
            textInform.text = Math.Round(tempF,2) + " зн/m";
        }
    }

    public void PressStartButton()
    {
        _pressStartButton = true;
        _veryFirstLogin = true;
    }

    public void PressHomeButton()
    {
        _pressStartButton = false;
        _firstLogin = true;
    }

    // Update is calle once per frame
    private void Update()
    {
        if (_pressStartButton)
        {
            if (_firstLogin)
            {
                Start();
            }
            
            if (textButton.text == "Язык ru")
            {
                PressingKeyboard();
                CallingMainMethods("ru");
            }
            else if (textButton.text == "Язык eng")
            { 
                PressingKeyboardEng();
                CallingMainMethods("eng");
            } 
        }
        else
        {
            if (_veryFirstLogin)
            {
                item.statisticsFromFile = textStatistics.text;
                item.speedFromFile = textInform.text;
                SaveToFile();
            }
            string space = "  ";
            textMain.text = space;
        }
        
    }

    public void PressButtonStat1()
    {
        Item tempItem;
        tempItem = JsonUtility.FromJson<Item>(File.ReadAllText(Application.streamingAssetsPath + "/Text1.json"));
        textEnterStat.text = "\nText1\n\n" + tempItem.speedFromFile + "\n\n" + tempItem.statisticsFromFile;
    }
    
    public void PressButtonStat2()
    {
        Item tempItem;
        tempItem = JsonUtility.FromJson<Item>(File.ReadAllText(Application.streamingAssetsPath + "/Text2.json"));
        textEnterStat.text = "\nText2\n\n" + tempItem.speedFromFile + "\n\n" + tempItem.statisticsFromFile;
    }
    
    public void PressButtonStat3()
    {
        Item tempItem;
        tempItem = JsonUtility.FromJson<Item>(File.ReadAllText(Application.streamingAssetsPath + "/Text3.json"));
        textEnterStat.text = "\nText3\n\n" + tempItem.speedFromFile + "\n\n" + tempItem.statisticsFromFile;
    }
    
    public void PressButtonStat4()
    {
        Item tempItem;
        tempItem = JsonUtility.FromJson<Item>(File.ReadAllText(Application.streamingAssetsPath + "/Text4.json"));
        textEnterStat.text = "\nText4\n\n" + tempItem.speedFromFile + "\n\n" + tempItem.statisticsFromFile;
    }
    private void CallingMainMethods(string lungStr)
    {
        
        CharacterInMinutes();
        CharacterInMinutes2_0();
               
        if(_str.Length == 0)  //Сработывает только один раз
        {
            if(_oneEnter == 1)
            {
                if (lungStr == "ru")
                    EnterInform();
                else if (lungStr == "eng")
                    EnterInformEng();
            }
            _oneEnter--;
        }
    }

    private int NumChar(char tempChar)
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

    private void EnterInform()
    {
        for (int i = 0; i < 104; i++)
        {
            if (_numButton[i] != 0)
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

                if (_column)
                {
                    textStatistics.text = textStatistics.text  + tempChar + " = " + _numButton[i];
                    _column = false;
                }
                else
                {
                    textStatistics.text = textStatistics.text  + "|"+ tempChar + " = " + _numButton[i] + "\n";
                    _column = true;
                }
            }    
        }
    }
    
    private void EnterInformEng()
    {
        for (int i = 0; i < 104; i++)
        {
            if (_numButton[i] != 0)
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
                if (_column)
                {
                    textStatistics.text = textStatistics.text  + tempChar + " = " + _numButton[i];
                    _column = false;
                }
                else
                {
                    textStatistics.text = textStatistics.text  + "|"+ tempChar + " = " + _numButton[i] + "\n";
                    _column = true;
                }            }    
        }
    }
}