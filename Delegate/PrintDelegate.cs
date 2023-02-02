using System;


namespace Delegate
{
    internal class PrintDelegate
    {
        private Action display;

        public PrintDelegate(Action display)
        {
            this.display = display;
        }
    }
}