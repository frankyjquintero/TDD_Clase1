using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Clase1
{
    public class Aritmetica
    {

        public int Sumar(int v1, int v2) => v1 + v2;

        public int Restar(int v1, int v2) => v1 - v2;

        public object Multiplicar(int v1, int v2) => v1 * v2;

        public DividirResponse Dividir(int v1, int v2)
        {
            if (v2 == 0) return new DividirResponse(true, "Error division con 0 no valida");
            float resultado = (float)v1 / (float)v2; 
            return new DividirResponse(resultado,false, "");
        }
    }
    public class DividirResponse {
        public DividirResponse()
        {
        }

        public DividirResponse(bool error, string message)
        {
            Error = error;
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public DividirResponse(float resultado, bool error, string message)
        {
            Resultado = resultado;
            Error = error;
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        public float Resultado { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}
