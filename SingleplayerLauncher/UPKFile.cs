using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SingleplayerLauncher
{
    public class UPKFile
    {
        private byte[] bytes;
        private string filePath;
        private int fileLength = 0;

        public UPKFile(string path)
        {
            filePath = path;
            bytes = ReadAllBytes(path);
        }

        protected byte[] Bytes
        {
            get
            {
                if (bytes == null)
                    bytes = ReadAllBytes(filePath);
                return bytes;
            }
            set
            {
                bytes = value;
            }
        }


        public byte[] CreateZeroedByteArray(int length)
        {
            byte[] arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x00;
            }
            return arr;
        }

        public void Save()
        {           
            File.WriteAllBytes(filePath, Bytes);
        }

        public void RemoveBytes(int startPosition, int length)
        {
            var tmpBytes = new List<byte>(Bytes);
            tmpBytes.RemoveRange(startPosition, length);
            Bytes = tmpBytes.ToArray();
        }

        /// <summary>
        /// Overrides the bytes with the ones given starting in the next position of the bytes to find. 
        /// </summary>
        public void FindAndOverrideBytes(byte[] bytesToWrite, byte[] bytesToFind, int startSearchPosition)
        {
            int startPosition = FindBytes(bytesToFind, startSearchPosition);

            OverrideBytes(bytesToWrite, startPosition);
        }

        /// <summary>
        /// Overrides the bytes with the ones given starting in given position (included). 
        /// </summary>
        public void OverrideBytes(byte[] bytesToWrite, int startPosition)
        {
            int length = bytesToWrite.Length;

            for (int i = startPosition; i<length; i++)
            {
                Bytes[i] = bytesToWrite[i];
            }
        }

        /// <summary>
        /// Overrides the byte with the one given at the given position. 
        /// </summary>
        public void OverrideSingleByte(byte b, int position)
        {
            Bytes[position] = b;
        }

        // TODO use a better way to "insert" bytes (like shifting positions)
        /// <summary>
        /// Inserts the given bytes at the given position. 
        /// </summary>
        public void InsertBytes(byte[] bytesToInsert, int position)
        {
            var tmpBytes = new List<byte>(Bytes);
            tmpBytes.InsertRange(position, bytesToInsert);
            Bytes = tmpBytes.ToArray();
        }

        /// <summary>
        /// Inserts a number of 0x00 bytes at the given position. 
        /// </summary>
        public void InsertZeroedBytes(int position, int numberBytes)
        {
            byte[] zeroedBytes = CreateZeroedByteArray(numberBytes);

            InsertBytes(zeroedBytes, position);
        }

        /// <summary>
        /// Finds the position of the given array in the UPK file. 
        /// <para/>
        /// Returns the index of the first position after the array.
        /// </summary>
        public int FindBytes(byte[] needle, int start = 0)
        {
            byte[] haystack = bytes;

            for (int i = start; i <= haystack.Length - needle.Length; i++)
            {
                if (match( needle, i))
                {
                    return i;
                }
            }
            return -1;
        }

        protected bool match(byte[] needle, int start)
        {
            byte[] haystack = bytes;

            if (needle.Length + start > haystack.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < needle.Length; i++)
                {
                    if (needle[i] != haystack[i + start])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
            fileLength = buffer.Length;
            return buffer;
        }
    }
}

