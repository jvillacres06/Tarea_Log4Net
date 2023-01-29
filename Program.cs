using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Log4Net
{
     class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {

            log.Info("Mensaje de Información");

            DivicionCero();
            FormatoIncorrecto();


            Console.ReadLine();

            
        }

        private static void FormatoIncorrecto()
        {
            try
            {
                int num;
                Console.Write("Ingrese un número: ");
                
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                log.InfoFormat("Formato incorrecto");
            }
            
        }

        private static void DivicionCero()
        {
            int num1 = 7, num2 = 0, division = 0;

            try
            {
                division = num1 / num2;
                Console.WriteLine("Resultado: " + division);
            }
            catch (Exception)
            {
                log.Error("Nose puede dividir para cero");
            }


        }


     }
}
