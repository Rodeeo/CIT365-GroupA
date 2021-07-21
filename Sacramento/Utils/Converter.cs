using Sacramento.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sacramento.Utils
{
    public class Converter
    {

        public byte[] Serialize(String obj)
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(obj);
                }
                return m.ToArray();
            }
        }

        public static string Desserialize(byte[] data)
        {
            string result = "";
            using (MemoryStream m = new MemoryStream(data))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    result = reader.ReadString();
                }
            }
            return result;
        }

    }
}
