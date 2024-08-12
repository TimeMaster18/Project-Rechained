﻿using SingleplayerLauncher.GameFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SingleplayerLauncher
{
    public class UPKFile
    {
        public byte[] Bytes { get; private set; }
        private readonly string FilePath;
        private readonly int FileLength = 0;
        public int RemovedBytesCount = 0;

        public class Section
        {
            public string Name { get; private set; }
            public int? Size { get; private set; }
            public byte[] Header { get; private set; }

            public Section(string name, int? size, byte[] header)
            {
                Name = name;
                Size = size;
                Header = header;
            }
        }

        /// <summary>
        ///   <para>
        ///  Initializes a new instance of the <see cref="UPKFile"/> class.
        /// </para>
        /// </summary>
        /// <param name="path">The file path.</param>
        public UPKFile(string path)
        {
            FilePath = path;
            Bytes = ReadAllBytes(path);
            FileLength = Bytes.Length;
        }

        /// <summary>
        ///   <para>
        ///  Initializes a new instance of the <see cref="UPKFile"/> class.
        /// </para>
        /// </summary>
        /// <param name="path">The file path.</param>
        public UPKFile(byte[] bytes)
        {
            FilePath = null;
            Bytes = bytes;
            FileLength = bytes.Length;
        }

        private byte[] ReadAllBytes(string fileName)
        {
            byte[] buffer = null;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, (int)fs.Length);
            }
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
            _ = FilePath ?? throw new ArgumentNullException(nameof(FilePath), "Mandatory parameter");
            File.WriteAllBytes(FilePath, Bytes);
        }

        public byte GetByte(int index)
        {
            return Bytes[index];
        }

        public byte[] GetSubArray(int startPosition, int length)
        {
            if (startPosition + length > FileLength)
            {
                throw new ArgumentException("UPKFile index is out of range", nameof(GetSubArray));
            }

            byte[] subArray = new byte[length];
            Buffer.BlockCopy(Bytes, startPosition, subArray, 0, length);

            return subArray;
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

            RemovedBytesCount += numberBytes;
        }


        public void RemoveByteSection(Section section)
        {
            int removeIndex = FindBytesKMP(section.Header);

            if (removeIndex != -1)
            {
                RemoveBytes(removeIndex, (int)section.Size);
            }
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
                numberBytes = RemovedBytesCount;
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

            RemovedBytesCount -= bytesToInsert.Length;
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
            byte[] haystack = Bytes;

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
            byte[] haystack = Bytes;

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
            int N = Bytes.Length;

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
                if (pattern[j] == Bytes[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    return i - j;
                }

                // missmatch after j matches 
                else if (i < N && pattern[j] != Bytes[i])
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
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

        /// <summary>
        /// Applies a modification by finding a unique byte sequence in a file, calculating the target index
        /// (rounded to the nearest lower thousand for robustness), and overriding it with a specified byte array
        /// if the modification has not already been applied.
        /// </summary>
        /// <param name="uniqueBytesReference">The unique sequence of bytes to locate in the file.</param>
        /// <param name="changeIndex">The approximate index in the file where the unique bytes sequence is located. This index will be rounded to the nearest lower thousand to ensure robustness in case the file size changes.</param>
        /// <param name="offsetFromUniqueBytes">The offset from the end of the found byte sequence to the target index.</param>
        /// <param name="bytesToWrite">The byte array to write at the target index.</param>
        public void ApplyModification(byte[] uniqueBytesReference, int changeIndex, int offsetFromUniqueBytes, byte[] bytesToWrite)
        {
            int bytesReferenceIndex = FindBytesKMP(uniqueBytesReference, FileUtils.RoundToNearestLowerThousandPessimistic(changeIndex));
            int indexToModify = bytesReferenceIndex + uniqueBytesReference.Length + offsetFromUniqueBytes;

            // Check if the modification is already applied
            byte[] currentBytes = GetSubArray(indexToModify, bytesToWrite.Length);
            if (AreBytesEqual(currentBytes, bytesToWrite))
            {
                return;
            }

            OverrideBytes(bytesToWrite, indexToModify);
        }

        /// <summary>
        /// Applies a modification by finding a unique byte sequence in a file, calculating the target index
        /// (rounded to the nearest lower thousand for robustness), and overriding it with a specified single byte
        /// if the modification has not already been applied.
        /// </summary>
        /// <param name="uniqueBytesReference">The unique sequence of bytes to locate in the file.</param>
        /// <param name="changeIndex">The approximate index in the file where the unique bytes sequence is located. This index will be rounded to the nearest lower thousand to ensure robustness in case the file size changes.</param>
        /// <param name="offsetFromUniqueBytes">The offset from the end of the found byte sequence to the target index.</param>
        /// <param name="byteToWrite">The single byte to write at the target index.</param>
        public void ApplyModification(byte[] uniqueBytesReference, int changeIndex, int offsetFromUniqueBytes, byte byteToWrite)
        {
            int bytesReferenceIndex = FindBytesKMP(uniqueBytesReference, FileUtils.RoundToNearestLowerThousandPessimistic(changeIndex));
            int indexToModify = bytesReferenceIndex + uniqueBytesReference.Length + offsetFromUniqueBytes;

            // Check if the modification is already applied
            byte currentByte = Bytes[indexToModify];
            if (currentByte == byteToWrite)
            {
                return;
            }

            OverrideSingleByte(byteToWrite, indexToModify);
        }

        private static bool AreBytesEqual(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

