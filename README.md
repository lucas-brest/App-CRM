# App-CRM


Usuarios de la app
Servicios de la empresa
Clientes
Contratacion de un servicio

--Opcionales

Agenda de visitas técnicas
Promociones
Agendar llamadas


.Usuario

int IdUsuario
bool isAdminRol
string Nombre
string Usuario
string Contraseña
bool Estado (activado | desactivado)
DateTime Ultimo login

.Cliente
int DNI
string Nombre
string Telefono
string Mail
string Direccion
string Observaciones

.Servicio
int IdServicio
string Nombre

.Contrato
int IdContrato
int IdCliente
int IdServicio

HomePage
Usuarios
Clientes
Servicios
Contratos