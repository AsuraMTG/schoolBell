using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Media;
using System.Diagnostics;
using System.Threading;


namespace schoolBell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string end = "00"; // csak az egyszeruseg miatt 2 nulla a masodperc pontossag erdekeben
            var beCsengo = new List<string>() // letrehoz egy beCsengo nevu listat es feltolti az alabbi elemekkel
                    {
                        "08:00", "08:55", // elso es masodik      be csengo idopontjai    0-1 es index
                        "09:50", "10:45", // harmadik es negyedik be csengo idopontjai    2-3 es index
                        "11:40", "12:40", // otodik es hatodik    be csengo idopontjai    4-5 es index
                        "13:35", "14:25", // hetedik es nyolcadik be csengo idopontjai    6-7 es index
                    }; // be csengo idopontok listaban
            var kiCsengo = new List<string>() // letrehoz egy kiCsengo nevu listat es feltolti az alabbi elemekkel
                    {
                        "08:45", "09:40", // elso es masodik      ki csengo idopontjai    0-1 es index
                        "10:35", "11:30", // harmadik es negyedik ki csengo idopontjai    2-3 es index
                        "12:25", "13:25", // otodik es hatodik    ki csengo idopontjai    4-5 es index
                        "14:20", "15:10", // hetedik es nyolcadik ki csengo idopontjai    6-7 es index
                    }; // ki csengo idopontok listaban

            while (true) // vegtelen ciklus nincs kilepo pont 
            {
                DateTime most = DateTime.Now; // aktualis ido a while segitsegevel ujra es ujra generalodik

                if (most.ToString("HH:mm:ss") == $"{beCsengo[0]}:{end}" ||  most.ToString("HH:mm:ss") == $"{beCsengo[1]}:{end}" ||    // a most azaz az ora erteket stringben jelzi HH- mint hour
                    most.ToString("HH:mm:ss") == $"{beCsengo[2]}:{end}" ||  most.ToString("HH:mm:ss") == $"{beCsengo[3]}:{end}" ||    // HH- mint hour mm- mint minute ss- mint secound 
                    most.ToString("HH:mm:ss") == $"{beCsengo[4]}:{end}" ||  most.ToString("HH:mm:ss") == $"{beCsengo[5]}:{end}" ||    // a secound == end valtozoval ami 2 nulla
                    most.ToString("HH:mm:ss") == $"{beCsengo[6]}:{end}" ||  most.ToString("HH:mm:ss") == $"{beCsengo[7]}:{end}")      // a beCsengo lista [elem szama]  

                    System.Diagnostics.Process.Start(@"/home/admin/Desktop/schoolBell/schoolBell/bin/Debug/Bell.wav"); // a raspberry pi-n levo mappaban elhelyezett .wav file eleresi utvonala

                if (most.ToString("HH:mm:ss") == $"{kiCsengo[0]}:{end}" ||  most.ToString("HH:mm:ss") == $"{kiCsengo[1]}:{end}" ||     // a most azaz az ora erteket stringben jelzi HH- mint hour
                    most.ToString("HH:mm:ss") == $"{kiCsengo[2]}:{end}" ||  most.ToString("HH:mm:ss") == $"{kiCsengo[3]}:{end}" ||     // HH- mint hour mm- mint minute ss- mint secound 
                    most.ToString("HH:mm:ss") == $"{kiCsengo[4]}:{end}" ||  most.ToString("HH:mm:ss") == $"{kiCsengo[5]}:{end}" ||     // a secound == end valtozoval ami 2 nulla
                    most.ToString("HH:mm:ss") == $"{kiCsengo[6]}:{end}" ||  most.ToString("HH:mm:ss") == $"{kiCsengo[7]}:{end}")       // a kiCsengo lista [elem szama]  

                    System.Diagnostics.Process.Start(@"/home/admin/Desktop/schoolBell/schoolBell/bin/Debug/Bell.wav"); // a raspberry pi-n levo mappaban elhelyezett .wav file eleresi utvonala

                Console.WriteLine(most.ToString("HH:mm:ss")); // kiirja a consolra az aktualais erteket a most-nak ami a while miatt mindig a gepen leveo pontos ido lesz
                Thread.Sleep(1000); // var 1 masodpercet a program ez azert kell hogy legyen egy kis ido a kiirasok kozott
                Console.Clear(); // kitorli a consol tartalmat igy mindig a pontos ido lesz kiirva a consolera 

            } // Maszntik Marton
        }     // 22:00 2023.09.30.
    }         // v1.0
}
