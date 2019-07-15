using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestingPractice
{
    public class Stack<T>
    {
        //#region Members
        private T[] stackArray;
        private int maximumLength;
        //#endregion

        //#region Properties
        public int Size { get; private set; }
        //#endregion

        //#region Constructor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        //#endregion

    }
}