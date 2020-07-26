using System;
using System.Collections.Generic;
using System.Text;

namespace EnDeCryptor
{
    interface ICypher
    {
        public string Encrypt(char[] text);
        public string Decrypt(char[] text);
    }
}
