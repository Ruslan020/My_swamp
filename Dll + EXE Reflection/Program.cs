using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace WorldAndWarEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> Words = new Dictionary<string, int>();
            //чтение файла и поиск слов
            string readPath = @"D:\Digital Design\DigDesignWithDll\WorldAndWarEXE\ВойнаИМир.txt";
            try
            {
                
                using (System.IO.StreamReader sr = new System.IO.StreamReader(readPath, System.Text.Encoding.Default))
                {
                    string line = sr.ReadToEnd();
                    
                    Class1 lib = new Class1();
                    Console.WriteLine("Чтение выолнено1");
                    var wordsInLine = lib.GetType().GetMethod("FindWords", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
                    Console.WriteLine("Чтение выолнено2");
                    Words =  (Dictionary<string, int>)wordsInLine.Invoke(lib, new object[] {line });
                    Console.WriteLine("Чтение выолнено3");
                    /*wordsInLine(line);
                        
                    if (Words.ContainsKey(word))
                    {
                        Words[word] += 1;
                    }
                    else Words[word] = 1;
                    word = "";*/
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Запись ответа
            string writePath = @"D:\Digital Design\DigDesignWithDll\WorldAndWarEXE\ВойнаИМир-повторяющиеся слова.txt";

            try
            {

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (KeyValuePair<string, int> keyValue1 in Words.OrderByDescending(keyValue1 => keyValue1.Value))
                    {
                        sw.WriteLine(keyValue1.Key + " - " + keyValue1.Value);
                    }
                }

                Console.WriteLine("Слова и количество их использования записаны\nФайл: " +  writePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
