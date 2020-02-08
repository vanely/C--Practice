using System;

namespace Learning {
    class Calculator {
        private int numOne;
        private int numTwo;
        private string operation;
        private int result;

        // public static void Main(String[] args) {
        //     Calculator calc = new Calculator();

        //     calc.DecideOperation();
        //     if (calc.operation.Equals("x")) {
        //         calc.Multiply();
        //     } else if (calc.operation == "/") {
        //         calc.Divide();
        //     } else if (calc.operation == "+") {
        //         calc.Add();
        //     } else if (calc.operation == "-") {
        //         calc.Subtract();
        //     } else {
        //         Console.WriteLine("\n"+calc.operation+" is an invalid operator, please enter one of the following.");
        //         Console.ReadKey();
        //         calc.DecideOperation();
        //     }
        // }

        public string DecideOperation() {
            Console.WriteLine("Enter an operator for the numbers you will enter.");
            Console.Write("E.X: 'x', '/', '+', '-': ");
            this.operation = Convert.ToString(Console.ReadLine());
            return this.operation;
        }

        public void EnterNumbers() {
            Console.Write("Enter a number: ");
            this.numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            this.numTwo = Convert.ToInt32(Console.ReadLine());
        }

        public int Multiply() {
            EnterNumbers();
            this.result = this.numOne * this.numTwo;

            Console.WriteLine(this.numOne + " multiplied by " + this.numTwo + " equals " + this.result);
            return this.result;
        }

        public int Divide() {
            EnterNumbers();
            this.result = this.numOne / this.numTwo;

            Console.WriteLine(this.numOne + " divided by " + this.numTwo + " equals " + this.result);
            return this.result;
        }

        public int Add() {
            EnterNumbers();
            this.result = this.numOne + this.numTwo;

            Console.WriteLine(this.numOne + " plus " + this.numTwo + " equals " + this.result);
            return this.result;
        }

        public int Subtract() {
            EnterNumbers();
            this.result = this.numOne - this.numTwo;

            Console.WriteLine(this.numOne + " minus " + this.numTwo + " equals " + this.result);
            return this.result;
        }
    }
}