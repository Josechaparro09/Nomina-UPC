using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Generador
    {
        static Random random = new Random();
        static List<int> cedulasGeneradas = new List<int>();
        static List<int> telefonos = new List<int>();
        static List<string> correos = new List<string>();

        static string[] nombres = { 
            "Juan", 
            "María", 
            "Carlos", 
            "Ana", 
            "Pedro", 
            "Laura", 
            "Diego", 
            "Sofía", 
            "Luis", 
            "Elena" 
        };
        static string[] apellidos = { 
            "García", 
            "Rodríguez", 
            "Martínez", 
            "Fernández", 
            "López", 
            "Pérez", 
            "González", 
            "Díaz", 
            "Sánchez", 
            "Romero" 
        };

        static string[] dominios = { 
            "gmail.com", 
            "yahoo.com", 
            "hotmail.com", 
            "outlook.com", 
            "outlook.com",
            "unicesar.edu.co"
        };
        static string[] semilleros = {
            "A1" , 
            "A" , 
            "B", 
            "C", 
            "Reconocido por Colciencias", 
            "Semillero" 
        };

        static string[] postgrados = { 
            "Especializacion", 
            "Maestria", 
            "Doctorado", 
            "Postdoctorado" 
        };
        static string[] tiempo = {
            "Auxiliar de tiempo completo",
            "Auxiliar de medio tiempo" ,
            "Asistente de tiempo completo" ,
            "Asistente de medio tiempo",
            "Asociado de tiempo completo",
            "Titular de tiempo completo",
            "Titular de medio tiempo"
        };
        
        public string GenerarNombre()
        {
            string nombre = nombres[random.Next(nombres.Length)];

            return nombre;
        }
        public string GenerarApellido()
        {
            string apellido = apellidos[random.Next(nombres.Length)];

            return apellido;
        }
        public int GenerarCedula()
        {
            int cedulaAleatoria;
            do
            {
                cedulaAleatoria = random.Next(10000000, 99999999);
            } while (cedulasGeneradas.Contains(cedulaAleatoria));

            cedulasGeneradas.Add(cedulaAleatoria);

            return cedulaAleatoria;
        }
        public int GenerarTelefono()
        {
            int telAle;
            do
            {
                telAle = random.Next(5000000, 5999999);
            } while (telefonos.Contains(telAle));
            cedulasGeneradas.Add(telAle);

            return telAle;
        }
        public string GenerarCorreo(string nombre , string apellido)
        {
            string correoAleatorio;
            int cont = 0;
            do
            {
                string dominio = dominios[random.Next(dominios.Length)];
                correoAleatorio = $"{nombre}{apellido}@{dominio}";
                if (correos.Contains(correoAleatorio))
                {
                    cont++;
                    correoAleatorio = $"{nombre}{apellido}{cont}@{dominio}";
                }
            } while (correos.Contains(correoAleatorio));
            correos.Add(correoAleatorio);
            
            return correoAleatorio;
        }
        public string GenerarSemillero()
        {
            string semillero = semilleros[random.Next(semilleros.Length)];
            return semillero;
        }
        public string GenerarPostgrado()
        {
            string postgrado = postgrados[random.Next(postgrados.Length)];
            return postgrado;
        }
        public string GenerarTiempo()
        {
            string _tiempo = tiempo[random.Next(semilleros.Length)];
            return _tiempo;
        }
        public int GenerarRango(int min , int max)
        {

            int num = random.Next(min, max + 1);
            return num;
        }
    }
}
