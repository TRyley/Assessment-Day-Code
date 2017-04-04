using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Spinner
    {
        public Spinner()
        {
            spinnerFrames = new[] { '|', '/', '-', '\\' };
        }
        private char[] spinnerFrames { get; set; }
        private int currentFrame;
        public void Run()
        {
            Console.CursorVisible = false;

            var originX = Console.CursorLeft;
            var originY = Console.CursorTop;

            Console.Write(spinnerFrames[currentFrame]);

            currentFrame++;
            if (currentFrame == spinnerFrames.Length)
            {
                currentFrame = 0;
            }

            Console.SetCursorPosition(originX, originY);
        }
    }
}
