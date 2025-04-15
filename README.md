# AppSaveMoney - Aplicación de Manejo de Presupuesto

## Descripción
AppSaveMoney es una aplicación de gestión de presupuestos personal que permite a los usuarios controlar sus finanzas, establecer metas de ahorro y realizar un seguimiento de sus gastos e ingresos de manera efectiva.

## Arquitectura
La aplicación está implementada siguiendo una arquitectura en N capas que proporciona una clara separación de responsabilidades y facilita el mantenimiento, testing y escalabilidad del sistema.

### Estructura del Proyecto

```
AppSaveMoney/
├── EntityLayer/            # Capa de Dominio (corresponde a la capa de dominio en la arquitectura)
│   ├── Entities/           # Entidades básicas del dominio
│   ├── Interfaces/         # Interfaces de servicios y repositorios
│   ├── Enums/              # Enumeraciones del dominio
│   └── Exceptions/         # Excepciones personalizadas
│
├── DomainLayer/            # Capa de Aplicación (corresponde a la capa de aplicación en la arquitectura)
│   ├── Services/           # Servicios de aplicación
│   ├── Interfaces/         # Interfaces de servicios de aplicación
│   ├── DTOs/               # Objetos de transferencia de datos
│   ├── Mappers/            # Conversión entre entidades y DTOs
│   └── Validators/         # Validación de entrada de datos
│
├── DataLayer/              # Capa de Infraestructura (corresponde a la capa de infraestructura en la arquitectura)
│   ├── Context/            # Contexto de base de datos
│   ├── Repositories/       # Implementaciones de repositorios
│   ├── Configurations/     # Configuración de entidades
│   ├── Migrations/         # Migraciones de base de datos
│   └── ExternalServices/   # Servicios externos (si son necesarios)
│
└── AppSaveMoney/           # Capa de Presentación (MVC)
    ├── Controllers/        # Controladores MVC
    ├── Models/             # ViewModels específicos de la UI
    ├── Views/              # Vistas
    ├── wwwroot/            # Archivos estáticos
    └── Program.cs          # Punto de entrada y configuración
```

## Ventajas de esta Arquitectura

1. **Separación de Responsabilidades**: Cada capa tiene un propósito específico.
2. **Mantenibilidad**: Los cambios en una capa tienen un impacto mínimo en las otras.
3. **Testabilidad**: Facilita la creación de pruebas unitarias para cada componente.
4. **Escalabilidad**: Permite que el sistema crezca y evolucione de manera ordenada.
5. **Independencia Tecnológica**: La lógica de negocio no depende de la infraestructura o la presentación.

## Requisitos del Sistema
- .NET 7.0 o superior
- SQL Server (o la base de datos configurada)
- Visual Studio 2022 o superior (recomendado)

## Instalación y Configuración

1. Clonar el repositorio
   ```bash
   git clone https://github.com/AlberthRuiz/AppSaveMoney.git
   ```

2. Abrir la solución `AppSaveMoney.sln` en Visual Studio

3. Configurar la cadena de conexión a la base de datos en `appsettings.json`

4. Aplicar las migraciones para crear la base de datos
   ```bash
   Update-Database
   ```

5. Ejecutar la aplicación

## Uso


## Contribución

1. Hacer un fork del proyecto
2. Crear una nueva rama (`git checkout -b feature/nueva-funcionalidad`)
3. Hacer commit de tus cambios (`git commit -m 'Añadir nueva funcionalidad'`)
4. Hacer push a la rama (`git push origin feature/nueva-funcionalidad`)
5. Abrir un Pull Request

## Licencia


## Contacto
- Desarrollador: Alberth Ruiz
- GitHub: [AlberthRuiz](https://github.com/AlberthRuiz)
