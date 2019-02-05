using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    interface IEmptyable
    {
        void empty();
    }

    interface IPrintale
    {
        void print();
    }

    interface ICountable
    {
        int count();
    }
}
