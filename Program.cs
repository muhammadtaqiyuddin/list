﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LatihanList;

class Program
{

    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nim = "1234";
        mhs1.NamaMahasiswa = "Erik";

        Mahasiswa mhs2 = new Mahasiswa();
        mhs2.Nim = "1235";
        mhs2.NamaMahasiswa = "Wely";

        Dosen dosen = new Dosen();
        dosen.Nik = "0043";
        dosen.NamaDosen = "Jhono";

        List<Mahasiswa> list = new List<Mahasiswa>();

        list.Add(mhs1);
        list.Add(mhs2);

        Console.WriteLine("Nim    Nama");
        Console.WriteLine("===========");

        Mahasiswa mhs = list[1];
        Console.WriteLine("{0}   {1}",mhs.Nim, mhs.NamaMahasiswa);

        Mahasiswa mhsB = list[0];
        Console.WriteLine("{0}   {1}", mhsB.Nim, mhsB.NamaMahasiswa);

        Console.ReadLine();

    }
}