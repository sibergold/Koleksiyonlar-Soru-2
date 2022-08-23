using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    public class Program
    {  
        static void Main(string[] args)
        {  
          ArrayList sayilar= new ArrayList();
          ArrayList enbuyuk3=new ArrayList();
          ArrayList enkucuk3=new ArrayList();
        double  kucuktoplam=0;
         double buyuktoplam=0;
           int  kronometre=1;
          
          while(kronometre<21){
            Console.WriteLine(kronometre + ". sayıyı girin.");
            int sayi=Convert.ToInt32(Console.ReadLine());
            sayilar.Add(sayi);
           kronometre++;
          }
        sayilar.Sort();
        for(int i=0;i<3;i++){
           enkucuk3.Add(sayilar[i]);
           kucuktoplam+=Convert.ToDouble(sayilar[i]);
        }
        sayilar.Reverse();
        for(int i=0;i<3;i++){
           enbuyuk3.Add(sayilar[i]);
          buyuktoplam+=Convert.ToDouble(sayilar[i]);
           }
       foreach(var item in enbuyuk3){
         Console.WriteLine("EN BÜYÜK 3 SAYI:" +item);
          
       
       }
        foreach(var item in enkucuk3){
         Console.WriteLine("EN KÜÇÜK 3 SAYI:" + item);
       }
        
        
        for(int i=0;i<3;i++){
            
        }
        double buyukort=(buyuktoplam/3);
        double kucukort=(kucuktoplam/3);
        double ortalamatoplam=kucukort+buyukort;
        Console.WriteLine("BÜYÜK SAYILARIN ORTALAMASI:" + buyukort);
        Console.WriteLine("KÜÇÜK SAYILARIN ORTALAMASI:" + kucukort);
        Console.WriteLine("ORTALAMALARIN TOPLAMI:" + ortalamatoplam);
       
        
        
        }
    }
}