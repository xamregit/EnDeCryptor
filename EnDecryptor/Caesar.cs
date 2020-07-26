using System;
using System.Collections.Generic;
using System.Text;

namespace EnDeCryptor
{
    // Шифр Цезаря. Работает с русским текстом
    public class Caesar : ICypher
    {

        List<char> UpperCase = new List<char> { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        List<char> LowerCase = new List<char> { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
        public Caesar()
        {
            Shift = 3;
        }

        public Caesar(int _Shift)
        {
            Shift = _Shift;
        }

        // Сдвиг
        public int Shift { get; set; } 

        // Зашифровка
        public string Encrypt(char[] text) 
        {
            bool isUppercase;
            int index;
            for (int i = 0; i < text.Length; ++i)
            {
                if (!isRussianLetter(text[i], out isUppercase, out index))
                    continue;
                if (isUppercase)
                {
                    text[i] = UpperCase[(index + Shift) % UpperCase.Count];
                }
                else
                {
                    text[i] = LowerCase[(index + Shift) % LowerCase.Count];
                }
            }
            return new string(text);
        }

        // Дешифровка 
        public string Decrypt(char[] text)  
        {
            bool isUppercase;
            int index;
            for (int i = 0; i < text.Length; ++i)
            {
                if (!isRussianLetter(text[i], out isUppercase, out index))
                    continue;

                if (isUppercase)
                {
                    text[i] = UpperCase[((index - Shift) % UpperCase.Count + UpperCase.Count) % UpperCase.Count];
                }
                else
                {
                    text[i] = LowerCase[((index - Shift) % LowerCase.Count + LowerCase.Count) % LowerCase.Count];
                }
            }
            return new string(text);
        }

        private bool isRussianLetter(char letter, out bool isUppercase, out int index)
        {
            isUppercase = false;

            index = LowerCase.FindIndex(item => item == letter);
            if (index != -1)
            {
                return true;
            }

            index = UpperCase.FindIndex(item => item == letter);
            if (index != -1)
            {
                isUppercase = true;
                return true;
            }
            return false;
        }
    }
}
