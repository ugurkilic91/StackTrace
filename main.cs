using System;



namespace StackTrace

{

    class Program

    {

        static void Main(string [] args)

        {

            A();

        }

        static void A() {B();}

        static void B() {C();}

        static void C()

        {

            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(true);//stacktrace sınıfından bir obje oluşuturuldu true flagi ile scope data alındı

            int lineNumber = st.FrameCount;//toplam metod sayısı-threade ait-

            for (int i = 0; i < lineNumber; i++)//frameler arası iterasyon

            {

                Console.WriteLine($"[DosyaAdı] : {st.GetFrame(i).GetFileName()} [MetodAdı] : {st.GetFrame(i).GetMethod().Name} " +

                                  $"[SatırNo] : { st.GetFrame(i).GetFileLineNumber() } [KolonNo] : {st.GetFrame(i).GetFileColumnNumber()}"); 

            }

        }

    }

}
