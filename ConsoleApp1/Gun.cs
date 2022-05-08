using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gun
    {
        public string Typee;
        public int TotalBulletSize;
        public  int MagazineSize;
        public int BylletLeft=0;
        public int Reloader=0;
        
        
        public Gun(string Type,int totalbulletsize,int magazinesize)
        {
            Typee = Type;
            TotalBulletSize = totalbulletsize;
            MagazineSize = magazinesize;
            
        }
        public void shoot() {
            if (BylletLeft >= 0 && MagazineSize >= 0)
            {
                
                if (BylletLeft <= 10 && BylletLeft>=0 && MagazineSize>0)
                {
                    BylletLeft = --MagazineSize;
                    if (Reloader<10)
                    {
                        ++Reloader;
                    }                    
                    Console.WriteLine("Ates olundu ve  " + BylletLeft + " eded gulle qaldi");
                }
                else
                {
                    Console.WriteLine(" ates olunmadi magazinde gulle yoxdur ve  Zehmet olmasa reload edin");
                }
            }          
                  
            
        }
        public void reload()
        {
            TotalBulletSize = TotalBulletSize - Reloader;
            MagazineSize = BylletLeft + Reloader;
            Reloader = 0;
            Console.WriteLine("Reload olundu ve total  " + TotalBulletSize + "  eded gullemiz qaldi");
            Console.WriteLine("Reload olundu ve magazin makslandi magazindeki gulle sayi " + MagazineSize);
        }
        public void FullShoot()
        {
            BylletLeft = MagazineSize-MagazineSize;
            Reloader = MagazineSize;
            Console.WriteLine("Ates olundu ve  " + BylletLeft + " eded gulle qaldi");
        }
        public void GetInformation() {
            Console.WriteLine("Silahin adi-  " + Typee +"\nTotal Gulle tutumu-  " + TotalBulletSize + "\nMagazinde olan gulle sayi-  "+MagazineSize );
        }
        
        

    }
    
}
