using System;

namespace AL.Aplicacion.Excepciones;

public class UsuarioNoEncontradoException : Exception
{
    public UsuarioNoEncontradoException()
        : base("Usuario no encontrado.")
    {
    }
}
