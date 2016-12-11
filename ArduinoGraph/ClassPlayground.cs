﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace ArduinoGraph
{
    class ClassPlayground
    {
        public static string output = "";

        static Stopwatch s = new Stopwatch();
        public static void Test(Action<object, EventArgs> callback)
        {
            ClassMultimediaTimer timer = new ClassMultimediaTimer() { Interval = 10 };
            timer.Elapsed += (o, e) => callback(o,e);
            s.Start();
            timer.Start();
            //Console.ReadKey();
            //timer.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
        }
    }


}
