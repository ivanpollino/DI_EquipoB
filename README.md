# ProyectoDI_GrupoB - Pruebas de Inicio de Sesión y Registro de Usuarios

Este repositorio contiene pruebas unitarias para las funcionalidades de inicio de sesión y registro de usuarios en el proyecto `ProyectoDI_GrupoD`. Estas pruebas ayudan a asegurar que las funciones críticas de autenticación y registro de la aplicación funcionen como se espera.

## Tecnologías y Herramientas

- **Lenguaje**: C#  
- **Framework de Pruebas**: MSTest
- **Entorno de Desarrollo**: Visual Studio
- **Dependencias**:
  - `Microsoft.VisualStudio.TestTools.UnitTesting`

## Estructura del Código

### Pruebas de Inicio de Sesión

El archivo `InicioSesionTests` contiene pruebas que verifican los casos de uso relacionados con la autenticación de usuario. La clase `UsuarioManagement` es responsable de validar las credenciales del usuario, y la clase `InicioSesion` administra la lógica de inicio de sesión.

#### Casos de Prueba

- **CP1_1_1**: Usuario y contraseña válidos.
- **CP1_1_2**: Usuario válido y contraseña inválida.
- **CP1_1_3**: Usuario no válido.
- **CP1_1_4**: Campos vacíos.

### Pruebas de Registro de Usuario

El archivo `RegistroUsuarioTests` contiene pruebas que validan diferentes casos de registro de usuario utilizando la clase `Registro`. Estas pruebas aseguran que todos los datos requeridos sean válidos antes de añadir un usuario al sistema.

#### Casos de Prueba

- **CP1_1_1**: Registrar usuario con todos los campos válidos.
- **CP1_1_2**: Registrar usuario sin dirección y teléfono.
- **CP1_1_3**: Registrar usuario con datos válidos.
- **CP1_1_4**: Registrar usuario con DNI inválido.
- **CP1_1_5**: Registrar usuario con email inválido.
- **CP1_1_6**: Registrar usuario con cuenta corriente inválida (CCC).
- **CP1_1_9**: Registrar usuario con contraseña débil.
- **CP1_1_10**: Registrar usuario con email ya registrado.
- **CP1_1_11**: Registrar usuario con DNI ya registrado.

## Ejecución de las Pruebas

Para ejecutar las pruebas:

1. Abre el proyecto en Visual Studio.
2. Navega a **Test > Run All Tests** para ejecutar todas las pruebas.
3. Observa los resultados en la ventana **Test Explorer** para verificar que todas las pruebas pasen o encuentren problemas específicos.

## Contribuciones

Las contribuciones son bienvenidas. Si tienes ideas para mejorar el sistema de pruebas o detectas errores, por favor crea un issue o envía un pull request.

## Licencia

Este proyecto está licenciado bajo MIT License.
