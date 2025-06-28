using System;

namespace AL.Aplicacion.Excepciones;

public class AlojamientoConReservaEnCursoException : Exception
{
    public AlojamientoConReservaEnCursoException(string nombre)
        : base($"No se puede archivar la publicación '{nombre}' porque tiene una reserva en curso.")
    { }
}