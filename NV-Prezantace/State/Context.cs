using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.State
{
    class Context
    {
        private StateOfMind state;
        public Context()
        {
            state = new HappyState();
        }
        public void Express()
        {
            Console.WriteLine("I will tell my feelings.");
            state.Express();
        }
        public void ChangeMood()
        {
            Random rnd = new Random();
            if(rnd.Next(11) < 7)
            {
                Console.WriteLine("Now I will be happy.");
                state = new HappyState();
            }
            else
            {
                Console.WriteLine("Now I will be sad.");
                state = new SadState();
            }
        }
    }
}
