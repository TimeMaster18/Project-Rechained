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
        /// Overrides the bytes with the ones given starting in the first of the bytes to find. 
        /// </summary>
        public void FindAndOverrideBytes(byte[] bytesToWrite, byte[] bytesToFind, int startSearchPosition)
        {
            int startPosition = FindBytesKMP(bytesToFind, startSearchPosition);

            OverrideBytes(bytesToWrite, startPosition);
        }

        /// <summary>
        /// Overrides the bytes with the ones given starting in given position (included). 
        /// </summary>
        public void OverrideBytes(byte[] bytesToWrite, int startPosition)
        {
            int length = bytesToWrite.Length;

            for(int i = 0; i < length; i++)
            {
                Bytes[startPosition + i] = bytesToWrite[i];
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
        /// Returns the index of the first position of the array occurrence.
        /// </summary>
        public int FindBytesNaive(byte[] needle, int start = 0)
        {
            byte[] haystack = bytes;

            for (int i = start; i <= haystack.Length - needle.Length; i++)
            {
                if (Match( needle, i))
                {
                    return i;
                }
            }
            return -1;
        }

        protected bool Match(byte[] needle, int start)
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

        public int FindBytesKMP(byte[] pat, int start = 0)
        {
            int M = pat.Length;
            int N = bytes.Length;

            // create lps[] that will hold the longest 
            // prefix suffix values for pattern 
            int[] lps = new int[M];
            int j = 0; // index for pat[] 

            // Preprocess the pattern (calculate lps[] 
            // array) 
            ComputeLPSArray(pat, M, lps);

            int i = start; // index for txt[] 
            while (i < N)
            {
                if (pat[j] == bytes[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    return i - j;
                }

                // mismatch after j matches 
                else if (i < N && pat[j] != bytes[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }

            return -1;
        }

        private void ComputeLPSArray(byte[] pat, int M, int[] lps)
        {
            // length of the previous longest prefix suffix 
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0 

            // the loop calculates lps[i] for i = 1 to M-1 
            while (i < M)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len]) 
                {
                    // This is tricky. Consider the example. 
                    // AAACAAAA and i = 7. The idea is similar 
                    // to search step. 
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        // Also, note that we do not increment 
                        // i here 
                    }
                    else // if (len == 0) 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }
    }
}

