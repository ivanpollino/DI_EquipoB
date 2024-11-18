using System;

namespace Negocio.EntitiesDTO
{
    /// <summary>
    /// Clase de transferencia de datos (DTO) que representa la información de un usuario.
    /// Almacena los datos personales y de contacto de un usuario del sistema.
    /// </summary>
    public class UsuarioDTO
    {
        /// <summary>
        /// DNI del usuario.
        /// </summary>
        public string DNI { get; set; }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellidos del usuario.
        /// </summary>
        public string Apellidos { get; set; }

        /// <summary>
        /// Número de teléfono del usuario. Puede ser nulo.
        /// </summary>
        public Nullable<int> Telefono { get; set; }

        /// <summary>
        /// Dirección del usuario.
        /// </summary>
        public string Direccion { get; set; }

        /// <summary>
        /// Cuenta corriente del usuario para fines de pago o facturación.
        /// </summary>
        public string Cuenta_Corriente { get; set; }

        /// <summary>
        /// Correo electrónico del usuario.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contraseña del usuario. Se recomienda gestionar la seguridad de este campo adecuadamente.
        /// </summary>
        public string Passwd { get; set; }

        /// <summary>
        /// Constructor completo que permite inicializar todas las propiedades del usuario.
        /// </summary>
        /// <param name="dNI">DNI del usuario.</param>
        /// <param name="nombre">Nombre del usuario.</param>
        /// <param name="apellidos">Apellidos del usuario.</param>
        /// <param name="telefono">Número de teléfono del usuario (puede ser nulo).</param>
        /// <param name="direccion">Dirección del usuario.</param>
        /// <param name="cuenta_Corriente">Cuenta corriente del usuario.</param>
        /// <param name="email">Correo electrónico del usuario.</param>
        /// <param name="passwd">Contraseña del usuario.</param>
        public UsuarioDTO(string dNI, string nombre, string apellidos, int? telefono, string direccion, string cuenta_Corriente, string email, string passwd)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Cuenta_Corriente = cuenta_Corriente;
            Email = email;
            Passwd = passwd;
        }

        /// <summary>
        /// Constructor vacío que permite crear una instancia de UsuarioDTO sin inicializar sus propiedades.
        /// </summary>
        public UsuarioDTO()
        {
        }

        /// <summary>
        /// Propiedad calculada que devuelve el nombre completo del usuario.
        /// </summary>
        public string NombreCompleto => $"{Nombre} {Apellidos}";
    }
}
