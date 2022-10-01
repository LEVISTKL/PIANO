using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace piano
{
    internal class Program
    {

        static async Task Main(string[] args)
            
        {
            string position = System.IO.Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string[] names;
            string MAIN = position+"\\MAIN.txt";
            System.ConsoleKeyInfo valt_;
            string valt;
            List<string> music = new List<string>();
            List<string> felvetel = new List<string>();
            bool lejatszas = false;
            bool test = false;
            bool felvevo = false;
            string b = " ";
            int szam = 0;
            while (true)
            {

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("| | | | | | | | |");
                Console.WriteLine("| | | | | | | | |");
                Console.WriteLine("|c|d|e|f|g|a|h|x|");
                Console.WriteLine("visszalépés q betűvel");
                if (felvevo == true)
                {
                    Console.WriteLine("felvevő: ON");
                }
                else
                {
                    Console.WriteLine("felvevő: OFF");
                }



                if (lejatszas == true)
                {

                    if (szam != music.Count)
                    {
                       
                        
                            b = music[szam];
                            szam++;
                        
                       
                    }
                    else
                    {
                        szam = 0;
                        lejatszas = false;
                        if (test == true)
                        {
                            test = false;
                            Console.Clear();
                            Console.WriteLine("tetszett? ha igen akkor el szeretnéd e menteni (i/n)");
                            valt_ = Console.ReadKey();
                            valt = valt_.Key.ToString();
                            Console.Clear();
                            if (Convert.ToString(valt).ToLower() == "i")//ha le szeretnénk menteni
                            {
                                Console.WriteLine("a felvétel el lett mentve..");
                                string datum_ = Convert.ToString(DateTime.Now);
                                string datum = Convert.ToString(datum_.Split(' ')[0] + datum_.Split(' ')[1] + datum_.Split(' ')[2] + datum_.Split(' ')[3].Split(':')[0] + datum_.Split(' ')[3].Split(':')[1] + datum_.Split(' ')[3].Split(':')[2]);
                                string path = position+"\\music" + datum + ".txt";
                                Console.WriteLine("a file: " + path);
                                File.WriteAllLines(path, music);//elmenti és alap helyzetbe áll
                                music.Clear();
                                names = File.ReadAllLines(MAIN);
                                List<string> name = new List<string>();
                                for (int i = 0; i < names.Length; i++)
                                {
                                    name.Add(names[i]);
                                }
                                name.Add("music" + datum);
                                File.WriteAllLines(position+"\\MAIN.txt", name);
                                felvetel.Clear();
                                await Task.Delay(1000);
                                
                            }
                            else//ha nem szeretnénk lementeni
                            {
                                Console.WriteLine("a felvétel nem került mentésre");//nem menti és alap helyzetbe áll
                                await Task.Delay(1000);
                                
                            }
                        }
                    }

                }
                else
                {
                    var a = Console.ReadKey();
                    b = a.Key.ToString();
                    if (felvevo == true)
                    {
                       
                        if (b.ToLower() == "a" || b.ToLower() == "x" || b.ToLower() == "c" || b.ToLower() == "d"
                        || b.ToLower() == "e" || b.ToLower() == "f" || b.ToLower() == "g" || b.ToLower() == "h")
                        {
                            felvetel.Add(b.ToLower());
                        }

                        
                    }
                }
                switch (b.ToLower())
                {
                    case "a":
                        Console.Beep(850,100);
                        Console.SetCursorPosition(10,0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(10,1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(10,2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;    
                        Console.WriteLine("|a|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();               
                        break;
                    case "x":
                        Console.Beep(1150, 100);
                        Console.SetCursorPosition(14, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(14, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(14, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|x|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "c":
                        Console.Beep(100, 100);
                        Console.SetCursorPosition(0, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(0, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(0, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|c|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "d":
                        Console.Beep(250, 100);
                        Console.SetCursorPosition(2, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(2, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(2, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|d|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "e":
                        Console.Beep(400, 100);
                        Console.SetCursorPosition(4, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(4, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(4, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|e|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "f":
                        Console.Beep(550, 100);
                        Console.SetCursorPosition(6, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(6, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(6, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|f|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "g":
                        Console.Beep(700, 100);
                        Console.SetCursorPosition(8, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(8, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(8, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|g|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "h":
                        Console.Beep(1000, 100);
                        Console.SetCursorPosition(12, 0);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(12, 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("| |");
                        Console.SetCursorPosition(12, 2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|h|");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        await Task.Delay(100);
                        Console.Clear();
                        break;
                    case "q":
                        Console.Clear();
                        Console.WriteLine("állista be a kívánt módot:");
                        Console.WriteLine("f = felvétel l = lejatszas, ENTER = vissza");
                        valt_ = Console.ReadKey();
                        valt = valt_.Key.ToString();
                        Console.Clear();
                        if (valt.ToLower() == "f")//ha felvétlt szeretnénk
                        {
                            
                            if (felvevo == true)//ha a felvétel már be van kapcsolva
                            {
                                Console.WriteLine("le szeretné állítani a felvételt? (i/n)");
                                valt_ = Console.ReadKey();
                                valt = valt_.Key.ToString();
                                Console.Clear();
                                if (Convert.ToString(valt).ToLower() == "i")//ha le szeretnénk állítani
                                {
                                    felvevo = false;
                                    Console.WriteLine("rendben, vissza szeretné halgatni a felvételt? (i/n)");
                                    valt_ = Console.ReadKey();
                                    valt = valt_.Key.ToString();
                                    Console.Clear();
                                    if (valt.ToLower() == "i")//ha vissza szeretnénk halgatni a felvételt
                                    {
                                        music.Clear();
                                        Console.WriteLine("felvétel lejátszása...");
                                        await Task.Delay(500);
                                        for (int i = 0; i < felvetel.Count; i++)
                                        {
                                            music.Add(felvetel[i]);
                                        }
                                        felvetel.Clear();
                                        lejatszas = true;
                                        test = true;
                                        break;
                                        
                                    }
                                    else//ha nem szeretnénk visszahalgatni a felvételt
                                    {
                                        Console.WriteLine("esetleg el szeretné menteni? (i/n)");
                                        valt_ = Console.ReadKey();
                                        valt = valt_.Key.ToString();
                                        Console.Clear();
                                        if (Convert.ToString(valt).ToLower() == "i")//ha le szeretnénk menteni
                                        {
                                            Console.WriteLine("a felvétel el lett mentve..");
                                            string datum_ = Convert.ToString(DateTime.Now);
                                            string datum = Convert.ToString(datum_.Split(' ')[0] + datum_.Split(' ')[1] + datum_.Split(' ')[2] + datum_.Split(' ')[3].Split(':')[0]+ datum_.Split(' ')[3].Split(':')[1]+ datum_.Split(' ')[3].Split(':')[2]);
                                            string path = position+"\\music"+datum+".txt";
                                            Console.WriteLine("a file: "+path);
                                            File.WriteAllLines(path, felvetel);//elmenti és alap helyzetbe áll
                                            names = File.ReadAllLines(MAIN);
                                            List<string> name = new List<string>();
                                            for (int i = 0; i < names.Length; i++)
                                            {
                                                name.Add(names[i]);
                                            }
                                            name.Add("music"+datum);
                                            File.WriteAllLines(position+"\\MAIN.txt",name);
                                            felvetel.Clear();
                                            await Task.Delay(1000);
                                            break;
                                        }
                                        else//ha nem szeretnénk lementeni
                                        {
                                            Console.WriteLine("a felvétel nem került mentésre");//nem menti és alap helyzetbe áll
                                            await Task.Delay(1000);
                                            break;
                                        }
                                        
                                    }
                                    
                                }
                                else//ha nem szeretnénk leállítani
                                {
                                    break;
                                }
                                
                                
                            }
                            else//ha nincs bekapcsolva a felvevő
                            {
                                Console.WriteLine("be akarja kapcsolni a felvevőt? (i/n)");//be szeretnénk e kapcsolni?
                                valt_= Console.ReadKey();
                                valt = valt_.Key.ToString(); 
                                if (Convert.ToString(valt).ToLower() == "i")
                                {

                                    felvevo = true;//ha igen akkor bekapcsol
                                    break;
                                }
                                else
                                {
                                    break;//ha nem akkor lépjen vissza alap állásba
                                }
                                
                            }

                        }
                        else if (valt.ToLower() == "l")
                        {
                            music.Clear();
                            Console.Clear();
                            Console.WriteLine("válassza ki a lejátszandó file -t ha vissza szeretne lépni nyomjon (0)");
                            names = File.ReadAllLines(MAIN);
                            if (names.Length > 0)
                            {
                                for (int i = 0; i < names.Length; i++)
                                {
                                    Console.SetCursorPosition(0, i + 1);
                                    Console.WriteLine(Convert.ToString(i + 1) + " " + names[i]);
                                }
                                valt_ = Console.ReadKey();
                                int valtI = int.Parse(valt_.KeyChar.ToString());
                                if (valtI == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    for (int i = 0; i < names.Length; i++)
                                    {
                                        if (valtI - 1 == i)
                                        {
                                            string[] music_ = File.ReadAllLines(position + "\\" + names[i] + ".txt");
                                            Console.WriteLine(music_.Length);
                                            for (int x = 0; x < music_.Length; x++)
                                            {
                                                music.Add(music_[x]);
                                            }
                                        }
                                    }
                                    lejatszas = true;
                                    break;
                                }
 
                            }
                            else
                            {
                                Console.WriteLine("jelenleg nincsen felvétel");
                                await Task.Delay(1000);
                                break;
                            }
                            
                            
                        }
                        else
                        {
                            break;

                        }


                }
            }
                

            
            
            
        }
    }
}
