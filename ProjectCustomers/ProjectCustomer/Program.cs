using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar\n");

        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Customer customer = new Customer();
            Console.Write("Kode Customer : ");
            customer.KodeCustomer = Console.ReadLine();
            Console.Write("Nama Customer : ");
            customer.NamaCustomer = Console.ReadLine();
            Console.Write("Total Piutang : ");
            customer.TotalPiutang = Console.ReadLine();

            daftarCustomer.Add(customer);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.Write("Kode Customer : ");
            string kd = Console.ReadLine();
            Customer delPro = daftarCustomer.SingleOrDefault(f => f.KodeCustomer == kd);

            if (daftarCustomer.Contains(delPro) == true)
            {
                daftarCustomer.Remove(delPro);
                Console.WriteLine("Data customer berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Kode customer tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            int index = 0;
            foreach(Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", index + 1, customer.KodeCustomer, customer.NamaCustomer, customer.TotalPiutang);
                index++;
            }
            


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
