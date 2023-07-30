using System;
using System.Collections;
 
namespace InvestigateOfBoxingUnBoxing
{
    public struct Urun
    {
        private int m_Fiyat;
        public int Fiyat
        {
            get   
            {
                return m_Fiyat;
            }
            set
            {
                m_Fiyat=value;
            }
        }
 
        public Urun(int fiyat)
        {
            m_Fiyat=fiyat;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            #region ArrayList koleksiyonu kullanildiğinda
            ArrayList alUrun=new ArrayList();
            DateTime dtSuan=DateTime.Now;
            for(int i=1;i<500000;i++)
            {
                alUrun.Add(new Urun(i*1000)); // boxing olacaktir
            }
            TimeSpan tsFark=DateTime.Now-dtSuan;
            Console.WriteLine("ArrayList Kullanimi........."+tsFark.TotalMilliseconds.ToString());
            #endregion
 
            #region object dizisi kullanildiğinda
            object[] objUrunler=new object[500000];
            dtSuan=DateTime.Now;
            for(int i=1;i<500000;i++)
            {
                objUrunler[i]=new Urun(i*1000); // boxing olacaktir
            }
            tsFark=DateTime.Now-dtSuan;
            Console.WriteLine("Object Dizisi Kullanimi........."+tsFark.TotalMilliseconds.ToString());
            #endregion
 
            #region Struct tipinden bir dizi kullanildiğinda
            Urun[] urunList=new Urun[500000];
            dtSuan=DateTime.Now;
            for(int i=1;i<500000;i++)
            {
                urunList[i]=new Urun(i*1000); // değer türüne aktarma var. Yani boxing yok...
            }
            tsFark=DateTime.Now-dtSuan;
            Console.WriteLine("Struct Dizisi Kullanimi........."+tsFark.TotalMilliseconds.ToString());
            #endregion
         
        }
    }
}