using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public class UPKFile
    {
        private byte[] bytes;
        private readonly string filePath;
        private int fileLength = 0;
        public int nBytesRemoved = 0;

        /// <summary>
        ///   <para>
        ///  Initializes a new instance of the <see cref="UPKFile"/> class.
        /// </para>
        /// </summary>
        /// <param name="path">The file path.</param>
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
            set => bytes = value;
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


        /// <summary>Creates a zeroed byte array. (0x00 value)</summary>
        /// <param name="length">The length of the array to create.</param>
        /// <returns>Created Array with bytes of value 0x00.</returns>
        public byte[] CreateZeroedByteArray(int length)
        {
            byte[] arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0x00;
            }
            return arr;
        }

        /// <summary>
        /// Saves the file to disk.
        /// </summary>
        public void Save()
        {
            File.WriteAllBytes(filePath, Bytes);
        }

        public byte GetByte(int index)
        {
            return Bytes[index];
        }

        /// <summary>
        /// Overrides the bytes with the ones given starting in the given position (included). 
        /// </summary>
        public void OverrideBytes(byte[] bytesToWrite, int startPosition)
        {
            int length = bytesToWrite.Length;

            for (int i = 0; i < length; i++)
            {
                Bytes[startPosition + i] = bytesToWrite[i];
            }
        }

        /// <summary>
        /// Overrides the byte with the one given at the given index. 
        /// </summary>
        /// <param name="b"> Byte to set.</param>
        /// <param name="index"> Index of the byte to override.</param>
        public void OverrideSingleByte(byte b, int index)
        {
            Bytes[index] = b;
        }

        /// <summary>
        /// Overrides the bytes with the ones given starting in the first index of the bytes to find. 
        /// </summary>
        public void FindAndOverrideBytes(byte[] bytesToWrite, byte[] bytesToFind, int startSearchPosition)
        {
            int startPosition = FindBytesKMP(bytesToFind, startSearchPosition);

            OverrideBytes(bytesToWrite, startPosition);
        }

        /// <summary>
        /// Removes the bytes in the given index. 
        /// </summary>
        /// <param name="index"> Index to where start removing.</param>
        /// <param name="numberBytes"> Number of bytes to remove.</param>
        public void RemoveBytes(int index, int numberBytes)
        {
            List<byte> tmpBytes = new List<byte>(Bytes);
            tmpBytes.RemoveRange(index, numberBytes);
            Bytes = tmpBytes.ToArray();

            nBytesRemoved += numberBytes;
        }

        /// <summary>
        /// Inserts a number of 0x00 bytes at the given index. 
        /// </summary>
        /// <param name="index"> Index to where start inserting.</param>
        /// <param name="numberBytes"> Number of 00x0 bytes to insert. 
        /// (Optional) Default value is the number of bytes removed, the difference in size from the original version </param>
        public void InsertZeroedBytes(int index, int numberBytes)
        {
            if (numberBytes <= 0)
            {
                numberBytes = nBytesRemoved;
            }

            byte[] zeroedBytes = CreateZeroedByteArray(numberBytes);

            InsertBytes(zeroedBytes, index);
        }

        // TODO use a better way to "insert" bytes (like shifting positions)
        /// <summary>
        /// Inserts the given bytes at the given position. 
        /// </summary>
        public void InsertBytes(byte[] bytesToInsert, int position)
        {
            List<byte> tmpBytes = new List<byte>(Bytes);
            tmpBytes.InsertRange(position, bytesToInsert);
            Bytes = tmpBytes.ToArray();

            nBytesRemoved -= bytesToInsert.Length;
        }

        /// <summary>
        /// Finds the position of the given array in the UPK file. Uses Naive method. <para />
        /// <returns>
        /// Returns the index of the first position of the array occurrence.
        /// </returns>
        /// </summary>
        /// <param name="needle"> Array of bytes to find.</param>
        /// <param name="start"> Offset index of where to start the search.</param>
        public int FindBytesNaive(byte[] needle, int start = 0)
        {
            byte[] haystack = bytes;

            for (int i = start; i <= haystack.Length - needle.Length; i++)
            {
                if (Match(needle, i))
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

        /// <summary>
        /// Finds the position of the given array in the UPK file. Uses Knuth-Morris Patt (KMP) method. 
        /// <returns> Returns the index of the first position of the array occurrence or -1 if not found. </returns>
        /// </summary>
        /// <param name="pattern"> Array of bytes to find.</param>
        /// <param name="start"> Offset index of where to start the search.</param>
        /// <param name="length"> Number of bytes to search from the start index.</param>
        public int FindBytesKMP(byte[] pattern, int start = 0, int length = 0)
        {
            int M = pattern.Length;
            int N = bytes.Length;

            if (length > 0)
            {
                N = length + start;
            }

            // create lps[] that will hold the longest 
            // prefix suffix values for pattern 
            int[] lps = new int[M];
            int j = 0; // index for pat[] 

            // Preprocess the pattern (calculate lps[] 
            // array) 
            ComputeLPSArray(pattern, M, lps);

            int i = start; // index for txt[] 
            while (i < N)
            {
                if (pattern[j] == bytes[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    return i - j;
                }

                // missmatch after j matches 
                else if (i < N && pattern[j] != bytes[i])
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

        /// <summary>
        /// For Debugging purposes.
        /// Prints in a Mesage Box the indicated range, from stated index. 
        /// </summary>
        /// <param name="offset"> Offset index of where to start the print.</param>
        /// <param name="size"> Number of bytes to print from the start index.</param>
        internal void PrintBytes(int offset, int size)
        {
            byte[] arrToPrint = new byte[size];
            Array.Copy(Bytes, offset, arrToPrint, 0, size);
            MessageBox.Show(BitConverter.ToString(arrToPrint));
        }
    }
}

