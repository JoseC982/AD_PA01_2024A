/* ************************************************************************
Practica 07  
Integrantes: Jose Condor, Kevin Perez  
Fecha de realización: 11 / 06 / 2025  
Fecha de entrega: 18 / 06 / 2025  

RESULTADOS:  
- Se implementó una estructura de protocolo simple que permite enviar comandos desde el cliente al servidor de forma estructurada.
- Se facilita la descomposición y análisis de mensajes recibidos mediante las clases `Pedido` y `Respuesta`.

CONCLUSIONES:  
1. El diseño de un protocolo claro y estructurado mejora la legibilidad y mantenibilidad de la comunicación cliente-servidor.  
2. Separar el procesamiento del mensaje del resto de la lógica promueve la reutilización y el orden en el código.

RECOMENDACIONES:  
1. Validar la longitud y formato del mensaje en `Procesar()` para evitar errores por entradas incompletas.  
2. Ampliar la clase `Respuesta` con códigos de error estandarizados para facilitar el manejo automático en el cliente.

************************************************************************ */
using System.Linq;

namespace Protocolo
{
    public class Pedido
    {
        // El comando que se desea ejecutar (ej. "INGRESO", "CALCULO")
        public string Comando { get; set; }
        // Parámetros asociados al comando, separados como un arreglo de strings
        public string[] Parametros { get; set; }

        public static Pedido Procesar(string mensaje)
        {
            var partes = mensaje.Split(' ');
            return new Pedido
            {
                Comando = partes[0].ToUpper(),
                Parametros = partes.Skip(1).ToArray()
            };
        }
        // Convierte el pedido a una representación en cadena lista para enviar por red.
        public override string ToString()
        {
            return $"{Comando} {string.Join(" ", Parametros)}";
        }
    }

    public class Respuesta
    {
        // Indica si la operación fue exitosa ("OK") o no ("NOK")
        public string Estado { get; set; }
        // Mensaje descriptivo o datos adicionales
        public string Mensaje { get; set; }

        public override string ToString()
        {
            return $"{Estado} {Mensaje}";
        }
    }

}
