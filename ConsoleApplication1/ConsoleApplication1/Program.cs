using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Speak("hello!");






        }
    }
}
