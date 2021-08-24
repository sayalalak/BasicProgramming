using System;
using System.Collections;

namespace MesinAtm
{
    class Program 
    {
        static void Main(string[] args)
        {
            int pin;
            int balance = 500000;
            int deposit, withdrawal;
            ArrayList mutation = new ArrayList();
            Console.WriteLine("Silahkan Inputkan Pin Anda");
            pin = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            bool condition=true;


            while (ChekPin(pin)==true)
            {
                while (condition)
                {
                    Menu();
                    int choice;
                    Console.WriteLine("Silahkan pilih menu : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            break;
                        case 2:
                            Console.WriteLine("Silahkan input jumlah setoran : ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                            balance += deposit;
                            Console.WriteLine("Uang berhasil disetorkan");
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            mutation.Add($"Setor Tunai Rp. {deposit}");
                            break;
                        case 3:
                            Console.WriteLine("Silahkan input jumlah tarikan : ");
                            withdrawal = Convert.ToInt32(Console.ReadLine());
                            if (balance > withdrawal)
                            {
                                balance -= withdrawal;
                                Console.WriteLine("Uang berhasil ditarik");
                                mutation.Add($"Tarik Tunai Rp.{withdrawal} ");
                            }
                            else
                            {
                                Console.WriteLine("Saldo Tidak Cukup!!");
                                Console.WriteLine("Silahkan lakukan setoran");
                            }
                            Console.WriteLine($"Saldo anda adalah : Rp.{balance}");
                            break;
                        case 4:
                            Console.WriteLine("Data Mutasi Rekening Anda");
                            foreach (var data in mutation)
                            {
                                Console.WriteLine(data + "\n");
                            }
                            try 
                            {
                                if (mutation.Count == 0)
                                {
                                    Console.WriteLine(mutation[0]);
                                }
                            }
                            catch (Exception) 
                            { 
                                Console.WriteLine("ERROR : Belum ada riwayat Transaksi yang dilakukan "); 
                            }
                            break;
                        case 5:
                            Console.WriteLine("Terimakasih Telah Menggunakan Mesin ATM <3");
                            Environment.Exit(0);
                            break;
                    }
                    Console.WriteLine("Ingin Melakukan Transaksi Lain ? y/n");
                    string n = Console.ReadLine();
                    Console.Clear();
                    if (n == "y")
                    {
                        condition= true;
                    }
                    else
                    {
                        Console.WriteLine("Terimakasih Telah Menggunakan Mesin ATM <3");
                        condition = false;
                    }
                }
            } 
        }
        static void Menu()
        {
            Console.WriteLine("SELAMAT DATANG DI MESIN ATM");
            Console.WriteLine("===========================");

            Console.WriteLine("1. Cek Saldo");
            Console.WriteLine("2. Setor Tunai");
            Console.WriteLine("3. Tarik Tunai");
            Console.WriteLine("4. Cek Mutasi");
            Console.WriteLine("5. Exit");
        }
        static bool ChekPin(int pin) 
        {
            if (pin == 1234) { return true; }
            else {
                Console.WriteLine("Pin Salah, Silahkan input ulang");
                Environment.Exit(0);
                return false; }
        }
    }
}
