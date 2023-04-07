using System.Runtime.CompilerServices;

namespace ModulPBO
{
    class prossesor
    {
        public string merk;
        public string tipe;

    }
    class intel : prossesor
    {
        public intel()
        {
            base.merk = "Intel";
        }
    }
    class amd : prossesor
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }
    class corei3 : intel
    {
        public corei3()
        {
            base.tipe = "Core i3";
        }
    }
    class corei5 : intel
    {
        public corei5()
        {
            base.tipe = "Core i5";
        }
    }
    class corei7 : intel
    {
        public corei7()
        {
            base.tipe = "Core i7";
        }
    }
    class ryzen : amd
    {
        public ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    class athlon : amd
    {
        public athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    class VGA
    {
        public string merk;
    }

    class NVIDIA : VGA
    {
        public NVIDIA()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : VGA
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    class Laptop
    {
        public string merk;
        public string tipe;
        public VGA vga;
        public prossesor prossesor;
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} dimatikan");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }

    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }


    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    class Ideapad : Lenovo
    {
        public Ideapad()
        {
            base.tipe = "IdeaPad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Soal 1");
            //Laptop laptop2 = new Ideapad();
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();
            //Console.WriteLine("");

            //Console.WriteLine("Soal 2");
            //Laptop laptop1 = new Vivobook();
            //laptop1.vga = new NVIDIA();
            //laptop1.prossesor = new corei5();
            //laptop1.Ngoding();
            //Console.WriteLine("");

            //Console.WriteLine("Soal 3");
            //Console.WriteLine("Spesifikasi laptop1:");
            //Laptop laptop1 = new Vivobook();
            //laptop1.vga = new NVIDIA();
            //laptop1.prossesor = new corei5();
            //Console.WriteLine(laptop1.vga.merk);
            //Console.WriteLine(laptop1.prossesor.merk);
            //Console.WriteLine(laptop1.prossesor.tipe);
            //Console.WriteLine("");

            Console.WriteLine("Soal 4");
            Predator predator = new Predator();
            predator.vga = new AMD();
            predator.prossesor = new corei7();
            predator.BermainGame();
            Console.WriteLine("");


            //Console.WriteLine("Soal 5");
            //ACER acer = new Predator();
            //acer.BermainGame();
        }
    }
}

