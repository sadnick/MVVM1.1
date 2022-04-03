using System;

namespace MVVM
{
    public class DelegateCommand<T>
    {
        private Action<object> p;

        public DelegateCommand(Action<object> p)
        {
            this.p = p;
        }
    }
}