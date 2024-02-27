using System;
namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static Singleton Validator = null;

        private Singleton() { }
        public static Singleton GetValidationInstance()
        {
           
            if (Validator == null)
            {
                Validator = new Singleton();
            }
            return Validator;
        }
        

        public void PerformValidations() {
            //Validation Logic
            }

        }


        class Program
    {
        public static void Main(string[] args)
        {
            Singleton validator = Singleton.GetValidationInstance();
            validator.PerformValidations();
        }
    }
}