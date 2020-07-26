using System;
using System.Collections.Generic;
using System.Text;

// Шифр Атбаш. Работает с русским текстом

namespace EnDeCryptor
{
    public class Atbasch : ICypher
    {
        Dictionary<char, char> dict;
        public Atbasch()
        {
            dict = new Dictionary<char, char>();
            dict.Add('А', 'Я');
            dict.Add('Б', 'Ю');
            dict.Add('В', 'Э');
            dict.Add('Г', 'Ь');
            dict.Add('Д', 'Ы');
            dict.Add('Е', 'Ъ');
            dict.Add('Ё', 'Щ');
            dict.Add('Ж', 'Ш');
            dict.Add('З', 'Ч');
            dict.Add('И', 'Ц');
            dict.Add('Й', 'Х');
            dict.Add('К', 'Ф');
            dict.Add('Л', 'У');
            dict.Add('М', 'Т');
            dict.Add('Н', 'С');
            dict.Add('О', 'Р');
            dict.Add('П', 'П');
            dict.Add('Р', 'О');
            dict.Add('С', 'Н');
            dict.Add('Т', 'М');
            dict.Add('У', 'Л');
            dict.Add('Ф', 'К');
            dict.Add('Х', 'Й');
            dict.Add('Ц', 'И');
            dict.Add('Ч', 'З');
            dict.Add('Ш', 'Ж');
            dict.Add('Щ', 'Ё');
            dict.Add('Ъ', 'Е');
            dict.Add('Ы', 'Д');
            dict.Add('Ь', 'Г');
            dict.Add('Э', 'В');
            dict.Add('Ю', 'Б');
            dict.Add('Я', 'А');

            dict.Add('а', 'я');
            dict.Add('б', 'ю');
            dict.Add('в', 'э');
            dict.Add('г', 'ь');
            dict.Add('д', 'ы');
            dict.Add('е', 'ъ');
            dict.Add('ё', 'щ');
            dict.Add('ж', 'ш');
            dict.Add('з', 'ч');
            dict.Add('и', 'ц');
            dict.Add('й', 'х');
            dict.Add('к', 'ф');
            dict.Add('л', 'у');
            dict.Add('м', 'т');
            dict.Add('н', 'с');
            dict.Add('о', 'р');
            dict.Add('п', 'п');
            dict.Add('р', 'о');
            dict.Add('с', 'н');
            dict.Add('т', 'м');
            dict.Add('у', 'л');
            dict.Add('ф', 'к');
            dict.Add('х', 'й');
            dict.Add('ц', 'и');
            dict.Add('ч', 'з');
            dict.Add('ш', 'ж');
            dict.Add('щ', 'ё');
            dict.Add('ъ', 'е');
            dict.Add('ы', 'д');
            dict.Add('ь', 'г');
            dict.Add('э', 'в');
            dict.Add('ю', 'б');
            dict.Add('я', 'а');

        }

        public string Decrypt(char[] text)
        {
            for (int i = 0; i < text.Length; ++i)
            {
                if (!isRussianLetter(text[i]))
                    continue;

                text[i] = dict[text[i]];
            }

            return new string(text);
        }

        public string Encrypt(char[] text)
        {
            return Decrypt(text);
        }

        private bool isRussianLetter(char letter)
        {
            if (dict.ContainsKey(letter))
                return true;
            return false;
        }
    }
}
