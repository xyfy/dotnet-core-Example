﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestService
{
    public class test : Itest
    {
        public void demo()
        {
            Console.WriteLine(DateTime.Now);
        }
    }

    public interface Itest: IDependency
    {
        void demo();
    }
}
